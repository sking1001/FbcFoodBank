﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FbcFoodBank.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FbcFoodBank.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static System.Drawing.Bitmap active {
            get {
                object obj = ResourceManager.GetObject("active", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have unsaved changes.  Continuing will force all changes to be saved to the database.
        ///Do you want to continue?.
        /// </summary>
        internal static string AddVisitNowPrompt {
            get {
                return ResourceManager.GetString("AddVisitNowPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Food Bank Database.
        /// </summary>
        internal static string AppTitle {
            get {
                return ResourceManager.GetString("AppTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name cannot be changed until you save your changes..
        /// </summary>
        internal static string CantEditName {
            get {
                return ResourceManager.GetString("CantEditName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The visits cannot be changed until you save your changes..
        /// </summary>
        internal static string CantEditVisits {
            get {
                return ResourceManager.GetString("CantEditVisits", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your changes cannot be saved until you fix the following error:
        ///{0}.
        /// </summary>
        internal static string CantSaveChanges {
            get {
                return ResourceManager.GetString("CantSaveChanges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to If you continue, all reports will be close.
        ///Do you want to continue?.
        /// </summary>
        internal static string CloseReportsPrompt {
            get {
                return ResourceManager.GetString("CloseReportsPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FbcFoodBank.mdb.
        /// </summary>
        internal static string DatabaseName {
            get {
                return ResourceManager.GetString("DatabaseName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete this contact?.
        /// </summary>
        internal static string DeleteContactPrompt {
            get {
                return ResourceManager.GetString("DeleteContactPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to delete the selected visits?.
        /// </summary>
        internal static string DeleteVisitsPrompt {
            get {
                return ResourceManager.GetString("DeleteVisitsPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have unsaved changes, and they will be lost if you import a database.
        ///Do you want to lose your changes?.
        /// </summary>
        internal static string DiscardPrompt {
            get {
                return ResourceManager.GetString("DiscardPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database files (*.mdb)|*.mdb|All files (*.*)|*.*.
        /// </summary>
        internal static string DlgFilter {
            get {
                return ResourceManager.GetString("DlgFilter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This contact already has a visit for today.  Do you want to add a duplicate visit for today?.
        /// </summary>
        internal static string DuplicateVisitPrompt {
            get {
                return ResourceManager.GetString("DuplicateVisitPrompt", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap inactive {
            get {
                object obj = ResourceManager.GetObject("inactive", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;Name&apos; field cannot be empty.  You can either fill it in or delete the contact..
        /// </summary>
        internal static string NameEmpty {
            get {
                return ResourceManager.GetString("NameEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name &apos;{0}&apos; already exists.  You can either change the &apos;Name&apos; field or delete the contact..
        /// </summary>
        internal static string NameExists {
            get {
                return ResourceManager.GetString("NameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do you want to save your changes first?.
        /// </summary>
        internal static string SaveChangesPrompt {
            get {
                return ResourceManager.GetString("SaveChangesPrompt", resourceCulture);
            }
        }
    }
}
