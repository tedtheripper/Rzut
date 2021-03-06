// -----------------------------------------------------------
//  
//  This file was generated, please do not modify.
//  
// -----------------------------------------------------------
namespace EmptyKeys.UserInterface.Generated {
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.ObjectModel;
    using EmptyKeys.UserInterface;
    using EmptyKeys.UserInterface.Charts;
    using EmptyKeys.UserInterface.Data;
    using EmptyKeys.UserInterface.Controls;
    using EmptyKeys.UserInterface.Controls.Primitives;
    using EmptyKeys.UserInterface.Input;
    using EmptyKeys.UserInterface.Interactions.Core;
    using EmptyKeys.UserInterface.Interactivity;
    using EmptyKeys.UserInterface.Media;
    using EmptyKeys.UserInterface.Media.Effects;
    using EmptyKeys.UserInterface.Media.Animation;
    using EmptyKeys.UserInterface.Media.Imaging;
    using EmptyKeys.UserInterface.Shapes;
    using EmptyKeys.UserInterface.Renderers;
    using EmptyKeys.UserInterface.Themes;
    
    
    [GeneratedCodeAttribute("Empty Keys UI Generator", "3.0.0.0")]
    public sealed class Dictionary : ResourceDictionary {
        
        private static Dictionary singleton = new Dictionary();
        
        public Dictionary() {
            this.InitializeResources();
        }
        
        public static Dictionary Instance {
            get {
                return singleton;
            }
        }
        
        private void InitializeResources() {
            // Resource - [de] BitmapImage
            BitmapImage r_0_bm = new BitmapImage();
            r_0_bm.TextureAsset = "Images/de";
            this.Add("de", r_0_bm);
            // Resource - [en] BitmapImage
            BitmapImage r_1_bm = new BitmapImage();
            r_1_bm.TextureAsset = "Images/en";
            this.Add("en", r_1_bm);
            // Resource - [Group] Style
            Style r_2_s = new Style(typeof(GroupBox));
            Setter r_2_s_S_0 = new Setter(GroupBox.BorderThicknessProperty, new Thickness(5F));
            r_2_s.Setters.Add(r_2_s_S_0);
            Setter r_2_s_S_1 = new Setter(GroupBox.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            r_2_s.Setters.Add(r_2_s_S_1);
            Setter r_2_s_S_2 = new Setter(GroupBox.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            r_2_s.Setters.Add(r_2_s_S_2);
            Setter r_2_s_S_3 = new Setter(GroupBox.MarginProperty, new Thickness(5F));
            r_2_s.Setters.Add(r_2_s_S_3);
            this.Add("Group", r_2_s);
            // Resource - [imageContainerStyle] Style
            Style r_3_s = new Style(typeof(Rectangle));
            Setter r_3_s_S_0 = new Setter(Rectangle.SnapsToDevicePixelsProperty, false);
            r_3_s.Setters.Add(r_3_s_S_0);
            Setter r_3_s_S_1 = new Setter(Rectangle.HorizontalAlignmentProperty, HorizontalAlignment.Stretch);
            r_3_s.Setters.Add(r_3_s_S_1);
            Setter r_3_s_S_2 = new Setter(Rectangle.VerticalAlignmentProperty, VerticalAlignment.Stretch);
            r_3_s.Setters.Add(r_3_s_S_2);
            Setter r_3_s_S_3 = new Setter(Rectangle.RadiusXProperty, 10F);
            r_3_s.Setters.Add(r_3_s_S_3);
            Setter r_3_s_S_4 = new Setter(Rectangle.RadiusYProperty, 10F);
            r_3_s.Setters.Add(r_3_s_S_4);
            Setter r_3_s_S_5 = new Setter(Rectangle.MarginProperty, new Thickness(20F));
            r_3_s.Setters.Add(r_3_s_S_5);
            Setter r_3_s_S_6 = new Setter(Rectangle.StrokeProperty, new SolidColorBrush(new ColorW(128, 128, 128, 255)));
            r_3_s.Setters.Add(r_3_s_S_6);
            Setter r_3_s_S_7 = new Setter(Rectangle.StrokeThicknessProperty, 1F);
            r_3_s.Setters.Add(r_3_s_S_7);
            EventTrigger r_3_s_ET_0 = new EventTrigger(Rectangle.MouseEnterEvent);
            r_3_s.Triggers.Add(r_3_s_ET_0);
            BeginStoryboard r_3_s_ET_0_AC_0 = new BeginStoryboard();
            r_3_s_ET_0_AC_0.Name = "r_3_s_ET_0_AC_0";
            r_3_s_ET_0.AddAction(r_3_s_ET_0_AC_0);
            Storyboard r_3_s_ET_0_AC_0_SB = new Storyboard();
            r_3_s_ET_0_AC_0.Storyboard = r_3_s_ET_0_AC_0_SB;
            r_3_s_ET_0_AC_0_SB.Name = "r_3_s_ET_0_AC_0_SB";
            ThicknessAnimation r_3_s_ET_0_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_3_s_ET_0_AC_0_SB_TL_0.Name = "r_3_s_ET_0_AC_0_SB_TL_0";
            r_3_s_ET_0_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_0_AC_0_SB_TL_0.From = new Thickness(20F, 20F, 20F, 20F);
            r_3_s_ET_0_AC_0_SB_TL_0.To = new Thickness(10F, 10F, 10F, 10F);
            SineEase r_3_s_ET_0_AC_0_SB_TL_0_EA = new SineEase();
            r_3_s_ET_0_AC_0_SB_TL_0.EasingFunction = r_3_s_ET_0_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_0_AC_0_SB_TL_0, Rectangle.MarginProperty);
            r_3_s_ET_0_AC_0_SB.Children.Add(r_3_s_ET_0_AC_0_SB_TL_0);
            EventTrigger r_3_s_ET_1 = new EventTrigger(Rectangle.MouseLeaveEvent);
            r_3_s.Triggers.Add(r_3_s_ET_1);
            BeginStoryboard r_3_s_ET_1_AC_0 = new BeginStoryboard();
            r_3_s_ET_1_AC_0.Name = "r_3_s_ET_1_AC_0";
            r_3_s_ET_1.AddAction(r_3_s_ET_1_AC_0);
            Storyboard r_3_s_ET_1_AC_0_SB = new Storyboard();
            r_3_s_ET_1_AC_0.Storyboard = r_3_s_ET_1_AC_0_SB;
            r_3_s_ET_1_AC_0_SB.Name = "r_3_s_ET_1_AC_0_SB";
            ThicknessAnimation r_3_s_ET_1_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_3_s_ET_1_AC_0_SB_TL_0.Name = "r_3_s_ET_1_AC_0_SB_TL_0";
            r_3_s_ET_1_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_3_s_ET_1_AC_0_SB_TL_0.From = new Thickness(10F, 10F, 10F, 10F);
            r_3_s_ET_1_AC_0_SB_TL_0.To = new Thickness(20F, 20F, 20F, 20F);
            SineEase r_3_s_ET_1_AC_0_SB_TL_0_EA = new SineEase();
            r_3_s_ET_1_AC_0_SB_TL_0.EasingFunction = r_3_s_ET_1_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_3_s_ET_1_AC_0_SB_TL_0, Rectangle.MarginProperty);
            r_3_s_ET_1_AC_0_SB.Children.Add(r_3_s_ET_1_AC_0_SB_TL_0);
            this.Add("imageContainerStyle", r_3_s);
            // Resource - [InputBorder] Style
            Style r_4_s = new Style(typeof(Border));
            Setter r_4_s_S_0 = new Setter(Border.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            r_4_s.Setters.Add(r_4_s_S_0);
            Setter r_4_s_S_1 = new Setter(Border.BorderThicknessProperty, new Thickness(3F));
            r_4_s.Setters.Add(r_4_s_S_1);
            Setter r_4_s_S_2 = new Setter(Border.MarginProperty, new Thickness(3F));
            r_4_s.Setters.Add(r_4_s_S_2);
            this.Add("InputBorder", r_4_s);
            // Resource - [MyButtonStyle] Style
            Style r_5_s = new Style(typeof(Button));
            Setter r_5_s_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            r_5_s.Setters.Add(r_5_s_S_0);
            Setter r_5_s_S_1 = new Setter(Button.BorderThicknessProperty, new Thickness(3F));
            r_5_s.Setters.Add(r_5_s_S_1);
            Setter r_5_s_S_2 = new Setter(Button.MarginProperty, new Thickness(6F));
            r_5_s.Setters.Add(r_5_s_S_2);
            Func<UIElement, UIElement> r_5_s_S_3_ctFunc = r_5_s_S_3_ctMethod;
            ControlTemplate r_5_s_S_3_ct = new ControlTemplate(typeof(Button), r_5_s_S_3_ctFunc);
            Setter r_5_s_S_3 = new Setter(Button.TemplateProperty, r_5_s_S_3_ct);
            r_5_s.Setters.Add(r_5_s_S_3);
            Trigger r_5_s_T_0 = new Trigger();
            r_5_s_T_0.Property = Button.IsEnabledProperty;
            r_5_s_T_0.Value = true;
            Setter r_5_s_T_0_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(0, 0, 0, 255)));
            r_5_s_T_0.Setters.Add(r_5_s_T_0_S_0);
            r_5_s.Triggers.Add(r_5_s_T_0);
            Trigger r_5_s_T_1 = new Trigger();
            r_5_s_T_1.Property = Button.IsEnabledProperty;
            r_5_s_T_1.Value = false;
            Setter r_5_s_T_1_S_0 = new Setter(Button.BorderBrushProperty, new SolidColorBrush(new ColorW(100, 149, 237, 255)));
            r_5_s_T_1.Setters.Add(r_5_s_T_1_S_0);
            r_5_s.Triggers.Add(r_5_s_T_1);
            EventTrigger r_5_s_ET_2 = new EventTrigger(Button.MouseEnterEvent);
            r_5_s.Triggers.Add(r_5_s_ET_2);
            BeginStoryboard r_5_s_ET_2_AC_0 = new BeginStoryboard();
            r_5_s_ET_2_AC_0.Name = "r_5_s_ET_2_AC_0";
            r_5_s_ET_2.AddAction(r_5_s_ET_2_AC_0);
            Storyboard r_5_s_ET_2_AC_0_SB = new Storyboard();
            r_5_s_ET_2_AC_0.Storyboard = r_5_s_ET_2_AC_0_SB;
            r_5_s_ET_2_AC_0_SB.Name = "r_5_s_ET_2_AC_0_SB";
            ThicknessAnimation r_5_s_ET_2_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_2_AC_0_SB_TL_0.Name = "r_5_s_ET_2_AC_0_SB_TL_0";
            r_5_s_ET_2_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_2_AC_0_SB_TL_0.From = new Thickness(3F, 3F, 3F, 3F);
            r_5_s_ET_2_AC_0_SB_TL_0.To = new Thickness(6F, 6F, 6F, 6F);
            SineEase r_5_s_ET_2_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_2_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_2_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_2_AC_0_SB_TL_0, Button.BorderThicknessProperty);
            r_5_s_ET_2_AC_0_SB.Children.Add(r_5_s_ET_2_AC_0_SB_TL_0);
            EventTrigger r_5_s_ET_3 = new EventTrigger(Button.MouseLeaveEvent);
            r_5_s.Triggers.Add(r_5_s_ET_3);
            BeginStoryboard r_5_s_ET_3_AC_0 = new BeginStoryboard();
            r_5_s_ET_3_AC_0.Name = "r_5_s_ET_3_AC_0";
            r_5_s_ET_3.AddAction(r_5_s_ET_3_AC_0);
            Storyboard r_5_s_ET_3_AC_0_SB = new Storyboard();
            r_5_s_ET_3_AC_0.Storyboard = r_5_s_ET_3_AC_0_SB;
            r_5_s_ET_3_AC_0_SB.Name = "r_5_s_ET_3_AC_0_SB";
            ThicknessAnimation r_5_s_ET_3_AC_0_SB_TL_0 = new ThicknessAnimation();
            r_5_s_ET_3_AC_0_SB_TL_0.Name = "r_5_s_ET_3_AC_0_SB_TL_0";
            r_5_s_ET_3_AC_0_SB_TL_0.Duration = new Duration(new TimeSpan(0, 0, 0, 0, 500));
            r_5_s_ET_3_AC_0_SB_TL_0.From = new Thickness(6F, 6F, 6F, 6F);
            r_5_s_ET_3_AC_0_SB_TL_0.To = new Thickness(3F, 3F, 3F, 3F);
            SineEase r_5_s_ET_3_AC_0_SB_TL_0_EA = new SineEase();
            r_5_s_ET_3_AC_0_SB_TL_0.EasingFunction = r_5_s_ET_3_AC_0_SB_TL_0_EA;
            Storyboard.SetTargetProperty(r_5_s_ET_3_AC_0_SB_TL_0, Button.BorderThicknessProperty);
            r_5_s_ET_3_AC_0_SB.Children.Add(r_5_s_ET_3_AC_0_SB_TL_0);
            this.Add("MyButtonStyle", r_5_s);
            // Resource - [NakedButton] Style
            Style r_6_s = new Style(typeof(Button));
            Func<UIElement, UIElement> r_6_s_S_0_ctFunc = r_6_s_S_0_ctMethod;
            ControlTemplate r_6_s_S_0_ct = new ControlTemplate(typeof(Button), r_6_s_S_0_ctFunc);
            Setter r_6_s_S_0 = new Setter(Button.TemplateProperty, r_6_s_S_0_ct);
            r_6_s.Setters.Add(r_6_s_S_0);
            this.Add("NakedButton", r_6_s);
            // Resource - [Panel] Style
            Style r_7_s = new Style(typeof(StackPanel));
            Setter r_7_s_S_0 = new Setter(StackPanel.OrientationProperty, Orientation.Horizontal);
            r_7_s.Setters.Add(r_7_s_S_0);
            Setter r_7_s_S_1 = new Setter(StackPanel.BackgroundProperty, new SolidColorBrush(new ColorW(211, 211, 211, 255)));
            r_7_s.Setters.Add(r_7_s_S_1);
            this.Add("Panel", r_7_s);
            // Resource - [pl] BitmapImage
            BitmapImage r_8_bm = new BitmapImage();
            r_8_bm.TextureAsset = "Images/pl";
            this.Add("pl", r_8_bm);
            // Resource - [Tests] DataTemplate
            Func<UIElement, UIElement> r_9_dtFunc = r_9_dtMethod;
            this.Add("Tests", new DataTemplate(r_9_dtFunc));
            ImageManager.Instance.AddImage("Images/de");
            ImageManager.Instance.AddImage("Images/en");
            ImageManager.Instance.AddImage("Images/pl");
            FontManager.Instance.AddFont("Segoe UI", 20F, FontStyle.Regular, "Segoe_UI_15_Regular");
            FontManager.Instance.AddFont("Segoe UI", 100F, FontStyle.Regular, "Segoe_UI_75_Regular");
        }
        
        private static UIElement r_5_s_S_3_ctMethod(UIElement parent) {
            // e_0 element
            Grid e_0 = new Grid();
            e_0.Parent = parent;
            e_0.Name = "e_0";
            Binding binding_e_0_Background = new Binding("Background");
            binding_e_0_Background.Source = parent;
            e_0.SetBinding(Grid.BackgroundProperty, binding_e_0_Background);
            // e_1 element
            Border e_1 = new Border();
            e_0.Children.Add(e_1);
            e_1.Name = "e_1";
            Binding binding_e_1_BorderThickness = new Binding("BorderThickness");
            binding_e_1_BorderThickness.Source = parent;
            e_1.SetBinding(Border.BorderThicknessProperty, binding_e_1_BorderThickness);
            Binding binding_e_1_BorderBrush = new Binding("BorderBrush");
            binding_e_1_BorderBrush.Source = parent;
            e_1.SetBinding(Border.BorderBrushProperty, binding_e_1_BorderBrush);
            return e_0;
        }
        
        private static UIElement r_6_s_S_0_ctMethod(UIElement parent) {
            // e_2 element
            Grid e_2 = new Grid();
            e_2.Parent = parent;
            e_2.Name = "e_2";
            Binding binding_e_2_Background = new Binding("Background");
            binding_e_2_Background.Source = parent;
            e_2.SetBinding(Grid.BackgroundProperty, binding_e_2_Background);
            // e_3 element
            Border e_3 = new Border();
            e_2.Children.Add(e_3);
            e_3.Name = "e_3";
            Binding binding_e_3_BorderThickness = new Binding("BorderThickness");
            binding_e_3_BorderThickness.Source = parent;
            e_3.SetBinding(Border.BorderThicknessProperty, binding_e_3_BorderThickness);
            Binding binding_e_3_BorderBrush = new Binding("BorderBrush");
            binding_e_3_BorderBrush.Source = parent;
            e_3.SetBinding(Border.BorderBrushProperty, binding_e_3_BorderBrush);
            // e_4 element
            TextBlock e_4 = new TextBlock();
            e_3.Child = e_4;
            e_4.Name = "e_4";
            e_4.FontSize = 20F;
            Binding binding_e_4_Text = new Binding("Tag");
            binding_e_4_Text.Source = parent;
            e_4.SetBinding(TextBlock.TextProperty, binding_e_4_Text);
            return e_2;
        }
        
        private static UIElement r_9_dtMethod(UIElement parent) {
            // e_5 element
            Grid e_5 = new Grid();
            e_5.Parent = parent;
            e_5.Name = "e_5";
            // e_6 element
            TextBlock e_6 = new TextBlock();
            e_5.Children.Add(e_6);
            e_6.Name = "e_6";
            e_6.HorizontalAlignment = HorizontalAlignment.Center;
            e_6.VerticalAlignment = VerticalAlignment.Center;
            e_6.Text = "whatthefuckman";
            e_6.FontSize = 100F;
            Binding binding_e_6_Foreground = new Binding("ColorBrush");
            e_6.SetBinding(TextBlock.ForegroundProperty, binding_e_6_Foreground);
            return e_5;
        }
    }
}
