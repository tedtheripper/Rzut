﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rzut.Interface.Data.i18n.Resources {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Rzut.Interface.Data.i18n.Resources.Strings", typeof(Strings).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Apply.
        /// </summary>
        public static string Button_Apply {
            get {
                return ResourceManager.GetString("Button_Apply", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mass [kg].
        /// </summary>
        public static string EntityViewModel_Mass {
            get {
                return ResourceManager.GetString("EntityViewModel_Mass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Radius [m].
        /// </summary>
        public static string EntityViewModel_Radius {
            get {
                return ResourceManager.GetString("EntityViewModel_Radius", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Choose language.
        /// </summary>
        public static string Header_ChooseLanguage {
            get {
                return ResourceManager.GetString("Header_ChooseLanguage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ball throw simulator.
        /// </summary>
        public static string Header_Title {
            get {
                return ResourceManager.GetString("Header_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ball {0}.
        /// </summary>
        public static string Tab_Ball {
            get {
                return ResourceManager.GetString("Tab_Ball", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} must be between {1:0.00} and {2:0.00}.
        /// </summary>
        public static string Validation_Range_float {
            get {
                return ResourceManager.GetString("Validation_Range_float", resourceCulture);
            }
        }
    }
}
