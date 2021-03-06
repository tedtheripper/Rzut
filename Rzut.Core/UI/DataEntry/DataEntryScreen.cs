﻿using EmptyKeys.UserInterface;
using EmptyKeys.UserInterface.Controls;
using EmptyKeys.UserInterface.Data;
using EmptyKeys.UserInterface.Generated;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Media;
using EmptyKeys.UserInterface.Media.Imaging;
using EmptyKeys.UserInterface.Shapes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Rzut.Core.Prefab;
using Rzut.Core.Screens;
using Rzut.Interface.Data.i18n;
using Rzut.Interface.Data.UI;
using Rzut.Interface.Data.ViewModels.DataEntry;
using Rzut.Interface.Data.ViewModels.LanguageSelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tainicom.Aether.Physics2D.Samples.DrawingSystem;
using tainicom.Aether.Physics2D.Samples.ScreenSystem;
using Xamarin.Forms.Internals;

namespace Rzut.Core.UI.DataEntry
{
    public class DataEntryScreen : GameScreen
    {
        DataEntryForm Form;
        ItemsControl Items;
        DataEntryContext Context;
        ListBox Colors;
        Button Add;
        Button Remove;
        EmptyKeys.UserInterface.Shapes.Rectangle Preview;

        public readonly Dictionary<Color, Sprite> Previews = new Dictionary<Color, Sprite>();
        bool FirstTime;
        public static VirtualKeyboard Keyboard { get; set; }


        public DataEntryScreen(DataEntryContext ctx = null)
        {
            Context = ctx;
            FirstTime = Context == null;
        }

        public override void Draw(GameTime gameTime)
        {
            if (IsExiting)
                return;
            Form.Draw(gameTime.ElapsedGameTime.TotalMilliseconds);
            if(Colors.SelectedIndex != -1 && Colors.Items.Any())
            {
                var color = new Color((Colors.SelectedItem as SolidColorBrush).Color.PackedValue);
                ScreenManager.SpriteBatch.Begin();
                var txt = Previews[color];
                var p = Preview.VisualPosition;
                var s = Preview.Width;
                ScreenManager.SpriteBatch.Draw(txt.Texture, new Vector2(p.X, p.Y), null, Color.White, 0f, Vector2.Zero, s/txt.Texture.Width, SpriteEffects.None, 0);
                
                ScreenManager.SpriteBatch.End();
            }
            base.Draw(gameTime);
        }

        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {
            //UserInterface.Active.Update(gameTime);
            if (IsExiting) return;
            if (!coveredByOtherScreen)
            {
                Form.UpdateInput(gameTime.ElapsedGameTime.TotalMilliseconds);
                Form.UpdateLayout(gameTime.ElapsedGameTime.TotalMilliseconds);
            }

            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }

        public override void LoadContent()
        {
            base.LoadContent();

            var font = ScreenManager.Content.Load<SpriteFont>("UI/Segoe_UI_30_Regular");
            FontManager.DefaultFont = Engine.Instance.Renderer.CreateFont(font);

            Context = Context ?? new DataEntryContext(Form);
            Context.TabClicked += Context_TabClicked1;

            var viewport = ScreenManager.GraphicsDevice.Viewport;
            Form = new DataEntryForm(viewport.Width, viewport.Height) { DataContext = Context };

            Context.Form = Form;
            FontManager.Instance.LoadFonts(ScreenManager.Content, "UI/");
            ImageManager.Instance.LoadImages(ScreenManager.Content, "UI/");

            Items = (ItemsControl)VisualTreeHelper.Instance.FindElementByName(Form, "tabItems");

            //var btn = (Button)VisualTreeHelper.Instance.FindElementByName(Form, "apply");
            //btn.Click += Btn_Click;

            var elements = new Stack<UIElement>();
            elements.Push(VisualTreeHelper.Instance.FindElementByName(Form, "entityEditor"));
            while (elements.Any())
            {
                var e = elements.Pop();
                var binds = BindingOperations.GetAllBindings(e);
                if (binds.Count == 1)
                {
                    if (binds[0].ParentBinding.Converter is SystemConvertConverter && binds[0].Target is TextBox b && b.Tag.ToString() == "float")
                        binds[0].ParentBinding.Converter = new FloatProxyConverter();
                }
                var children = VisualTreeHelper.Instance.GetChildren(e);
                if (children == null) continue;
                foreach (var c in children)
                    if (c is UIElement child)
                        elements.Push(child);
            }

            Colors = (ListBox)VisualTreeHelper.Instance.FindElementByName(Form, "color");
            Colors.PreviewTouchDown += Colors_PreviewTouchDown;

            Add = (Button)VisualTreeHelper.Instance.FindElementByName(Form, "add");
            Add.Click += Add_Click;
            Remove = (Button)VisualTreeHelper.Instance.FindElementByName(Form, "remove");
            Remove.Click += Remove_Click;

            Preview = (EmptyKeys.UserInterface.Shapes.Rectangle)VisualTreeHelper.Instance.FindElementByName(Form, "preview");

            foreach (var color in Context.AvailableColors)
            {
                var texture = Ball.CreateTexture(16, color, ScreenManager.Assets);
                Previews.Add(color, texture);
            }

            Context.SimulationStarted += Context_SimulationStarted;
            if (RzutGame.Platform == Platform.Android || RzutGame.Platform == Platform.Apple)
            {
                if(!FirstTime)
                {
                    //virtual keyboard hack
                    var field = typeof(EmptyKeys.UserInterface.Input.Keyboard).GetFields().Where(t => t.IsPrivate && t.FieldType == typeof(VirtualKeyboard)).FirstOrDefault();
                    field.SetValue(InputManager.Current.KeyboardDevice, null);
                    InputManager.Current.Focus(VisualTreeHelper.Instance.FindElementByName(Form, "Mass"));

                    InputManager.Current.KeyboardDevice.Update(Form, 100f, 1000f);
                    InputManager.Current.KeyboardDevice.ShowVirtualKeyboard();
                }


            }
        }

        private void Colors_PreviewTouchDown(object sender, RoutedEventArgs e)
        {
            if (e.Source is UIElement el && el.DataContext is SolidColorBrush brush)
            {
                Colors.SelectedItem = brush;
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Context.RemoveTab(Context.ActiveEntity);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (!Colors.Items.Any() || Colors.SelectedIndex == -1) return;
            
            var entity = Context.ActiveEntity.Clone();
            var selectedBrush = Colors.SelectedItem as SolidColorBrush;
            entity.Color = new Microsoft.Xna.Framework.Color(selectedBrush.Color.PackedValue);
            var nextColor = Context.AvailableBrushes.FirstOrDefault(t => t != selectedBrush);
            Context.AddTab(entity);
            Context.SetActive(entity);
            Colors.SelectedItem = nextColor;

        }

        private void Context_SimulationStarted(DataEntryContext context)
        {
            if (ScreenManager._screens.Last() is RzutScreen) return;
            if (!context.ValidateAll()) return;
            ScreenManager.AddScreen(new RzutScreen(context));
            ScreenManager.RemoveScreen(this);
        }

        private void Context_TabClicked1(EntityViewModel entity)
        {
            Context.SetActive(entity);
        }


        public void Tab_Click(EmptyKeys.UserInterface.Shapes.Rectangle sender)
        {

        }

        public void RegisterTab(EmptyKeys.UserInterface.Shapes.Rectangle r)
        {
            r.MouseDown += (s, e) => Tab_Click(s as EmptyKeys.UserInterface.Shapes.Rectangle);
            r.TouchDown += (s, e) => Tab_Click(s as EmptyKeys.UserInterface.Shapes.Rectangle);
        }


        private void LanguageClick(object sender)
        {
            var r = (EmptyKeys.UserInterface.Shapes.Rectangle)sender;
            InternationalizationHelper.Set(r.Name);
            (Form.DataContext as LanguageSelectionContext).Update();
        }

        public override void HandleInput(InputHelper input, GameTime gameTime)
        {
            if (input.IsNewButtonPress(Buttons.Back) || input.IsNewKeyPress(Keys.Escape))
            {
                if (!IsExiting)
                {
                    IsExiting = true;
                    Form.Visibility = Visibility.Collapsed;
                    Form = null;
                    ScreenManager.RemoveScreen(this);
                    ScreenManager.AddScreen(new LanguageSelectionScreen(this.Context));
                    
                }

            }
            base.HandleInput(input, gameTime);
        }
    }
}
