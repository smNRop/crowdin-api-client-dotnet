﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Crowdin.Api.Tests.Core.Resources {
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
    internal class Distributions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Distributions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crowdin.Api.Tests.Core.Resources.Distributions", typeof(Distributions).Assembly);
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
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;hash&quot;: &quot;string&quot;,
        ///    &quot;name&quot;: &quot;string&quot;,
        ///    &quot;fileIds&quot;: [
        ///      0
        ///    ],
        ///    &quot;createdAt&quot;: &quot;2019-09-16T13:48:04+00:00&quot;,
        ///    &quot;updatedAt&quot;: &quot;2019-09-19T13:25:27+00:00&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string AddDistribution_Response {
            get {
                return ResourceManager.GetString("AddDistribution_Response", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;data&quot;: {
        ///    &quot;hash&quot;: &quot;someHash&quot;,
        ///    &quot;name&quot;: &quot;some name&quot;,
        ///    &quot;fileIds&quot;: [
        ///      0
        ///    ],
        ///    &quot;createdAt&quot;: &quot;2019-09-16T13:48:04+00:00&quot;,
        ///    &quot;updatedAt&quot;: &quot;2019-09-19T13:25:27+00:00&quot;
        ///  }
        ///}.
        /// </summary>
        internal static string EditDistribution_Response {
            get {
                return ResourceManager.GetString("EditDistribution_Response", resourceCulture);
            }
        }
    }
}