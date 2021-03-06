//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.ApiManagement.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.ApiManagement.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Region with location &apos;{0}&apos; already added..
        /// </summary>
        internal static string AddRegionExistsMessage {
            get {
                return ResourceManager.GetString("AddRegionExistsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location &apos;{0}&apos; does not fall within the range: {1}.
        /// </summary>
        internal static string InvalidLocation {
            get {
                return ResourceManager.GetString("InvalidLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing Microsoft Azure API Management &quot;{0}&quot;..
        /// </summary>
        internal static string RemoveAzureApiManagementDescription {
            get {
                return ResourceManager.GetString("RemoveAzureApiManagementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Microsoft Azure API Management &quot;{0}&quot;?.
        /// </summary>
        internal static string RemoveAzureApiManagementWarning {
            get {
                return ResourceManager.GetString("RemoveAzureApiManagementWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing master region in location &apos;{0}&apos; is not allowed..
        /// </summary>
        internal static string RemoveRegionCannotRemoveMasterRegion {
            get {
                return ResourceManager.GetString("RemoveRegionCannotRemoveMasterRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set an API Management service..
        /// </summary>
        internal static string SetApiManagementService {
            get {
                return ResourceManager.GetString("SetApiManagementService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string ShouldProcessCaption {
            get {
                return ResourceManager.GetString("ShouldProcessCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File at path &apos;{0}&apos; does not exist.
        /// </summary>
        internal static string SourceFileNotFound {
            get {
                return ResourceManager.GetString("SourceFileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update an Api Management Service..
        /// </summary>
        internal static string UpdateApiManagementService {
            get {
                return ResourceManager.GetString("UpdateApiManagementService", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region with location &apos;{0}&apos; not found..
        /// </summary>
        internal static string UpdateRegionDoesNotExistsMessage {
            get {
                return ResourceManager.GetString("UpdateRegionDoesNotExistsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Get operation state in &apos;{0}&apos;.
        /// </summary>
        internal static string VerboseGetOperationStateTimeoutMessage {
            get {
                return ResourceManager.GetString("VerboseGetOperationStateTimeoutMessage", resourceCulture);
            }
        }
    }
}
