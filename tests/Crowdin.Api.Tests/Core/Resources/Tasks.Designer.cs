﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
    internal class Tasks {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Tasks() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Crowdin.Api.Tests.Core.Resources.Tasks", typeof(Tasks).Assembly);
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
        ///   Looks up a localized string similar to {&quot;type&quot;:2,&quot;vendor&quot;:&quot;gengo&quot;,&quot;tone&quot;:&quot;Informal&quot;}.
        /// </summary>
        internal static string AddTask_RightRequestJson_VendorGengo_ToneInformal {
            get {
                return ResourceManager.GetString("AddTask_RightRequestJson_VendorGengo_ToneInformal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;type&quot;:2,&quot;vendor&quot;:&quot;gengo&quot;,&quot;tone&quot;:&quot;&quot;}.
        /// </summary>
        internal static string AddTask_RightRequestJson_VendorGengo_ToneNotSet {
            get {
                return ResourceManager.GetString("AddTask_RightRequestJson_VendorGengo_ToneNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;type&quot;:2,&quot;vendor&quot;:&quot;gengo&quot;,&quot;tone&quot;:&quot;other&quot;}.
        /// </summary>
        internal static string AddTask_RightRequestJson_VendorGengo_ToneOther {
            get {
                return ResourceManager.GetString("AddTask_RightRequestJson_VendorGengo_ToneOther", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///  &quot;title&quot;: &quot;My task&quot;,
        ///  &quot;languageId&quot;: &quot;es&quot;,
        ///  &quot;fileIds&quot;: [
        ///    1,2,3
        ///  ],
        ///  &quot;type&quot;: 2,
        ///  &quot;vendor&quot;: &quot;lingo24&quot;,
        ///  &quot;status&quot;: &quot;in_progress&quot;,
        ///  &quot;description&quot;: &quot;My amazing task&quot;,
        ///  &quot;skipAssignedStrings&quot;: true,
        ///  &quot;skipUntranslatedStrings&quot;: true,
        ///  &quot;labelIds&quot;: [
        ///    1
        ///  ],
        ///  &quot;assignees&quot;: [
        ///    {
        ///      &quot;id&quot;: 1,
        ///      &quot;wordsCount&quot;: 20
        ///    },
        ///
        ///    {
        ///      &quot;id&quot;: 2,
        ///      &quot;wordsCount&quot;: 30
        ///    }
        ///  ]
        ///}.
        /// </summary>
        internal static string AddTask_RightRequestJson_VendorManual {
            get {
                return ResourceManager.GetString("AddTask_RightRequestJson_VendorManual", resourceCulture);
            }
        }
    }
}