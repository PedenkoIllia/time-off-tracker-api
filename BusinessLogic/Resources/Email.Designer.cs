﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessLogic.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Email {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Email() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BusinessLogic.Resources.Email", typeof(Email).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Бухгалтерия.
        /// </summary>
        internal static string Accountant {
            get {
                return ResourceManager.GetString("Accountant", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Отпуск] Заявка утверждена: {0} - {1}-{2}.
        /// </summary>
        internal static string ApprovedAuthorTheme {
            get {
                return ResourceManager.GetString("ApprovedAuthorTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Отпуск] Утверждена: {0} - {1} - {2}-{3}.
        /// </summary>
        internal static string ApprovedTheme {
            get {
                return ResourceManager.GetString("ApprovedTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Отпуск] Заявка отклонена: {0} - {1}-{2}.
        /// </summary>
        internal static string RejectedAuthorTheme {
            get {
                return ResourceManager.GetString("RejectedAuthorTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Отпуск] Отклонена: {0} - {1} - {2}-{3}.
        /// </summary>
        internal static string RejectedTheme {
            get {
                return ResourceManager.GetString("RejectedTheme", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HtmlTemplates/EmailAboutRequestUpdate_ru.html.
        /// </summary>
        internal static string UpdatedBody {
            get {
                return ResourceManager.GetString("UpdatedBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Отпуск] Новая: {0} - {1} - {2}-{3}.
        /// </summary>
        internal static string UpdatedTheme {
            get {
                return ResourceManager.GetString("UpdatedTheme", resourceCulture);
            }
        }
    }
}
