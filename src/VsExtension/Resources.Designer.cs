﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetVSExtension {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGetVSExtension.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Can not create tool window..
        /// </summary>
        internal static string CanNotCreateWindow {
            get {
                return ResourceManager.GetString("CanNotCreateWindow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package Manager.
        /// </summary>
        internal static string DialogTitle {
            get {
                return ResourceManager.GetString("DialogTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation failed.
        /// </summary>
        internal static string ErrorDialogBoxTitle {
            get {
                return ResourceManager.GetString("ErrorDialogBoxTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error occurred while restoring NuGet packages: {0}.
        /// </summary>
        internal static string ErrorOccurredRestoringPackages {
            get {
                return ResourceManager.GetString("ErrorOccurredRestoringPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ========== Finished ==========.
        /// </summary>
        internal static string Finished {
            get {
                return ResourceManager.GetString("Finished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage NuGet Packages for &amp;Solution....
        /// </summary>
        internal static string ManagePackageForSolutionLabel {
            get {
                return ResourceManager.GetString("ManagePackageForSolutionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Manage &amp;NuGet Packages....
        /// </summary>
        internal static string ManagePackageLabel {
            get {
                return ResourceManager.GetString("ManagePackageLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No project is selected for this operation..
        /// </summary>
        internal static string NoProjectSelected {
            get {
                return ResourceManager.GetString("NoProjectSelected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All packages are already installed and there is nothing to restore..
        /// </summary>
        internal static string NothingToRestore {
            get {
                return ResourceManager.GetString("NothingToRestore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to nuget.
        /// </summary>
        internal static string NuGetSearchProvider_CategoryShortcut {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_CategoryShortcut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search NuGet packages.
        /// </summary>
        internal static string NuGetSearchProvider_Description {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Packages.
        /// </summary>
        internal static string NuGetSearchProvider_DisplayText {
            get {
                return ResourceManager.GetString("NuGetSearchProvider_DisplayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search Online for NuGet Packages matching &apos;{0}&apos;.
        /// </summary>
        internal static string NuGetStaticResult_DisplayText {
            get {
                return ResourceManager.GetString("NuGetStaticResult_DisplayText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to One or more NuGet packages need to be restored but couldn&apos;t be because consent has not been granted. To give consent, open the Visual Studio Options dialog, click on the Package Manager node and check &apos;Allow NuGet to download missing packages during build.&apos; You can also give consent by setting the environment variable &apos;EnableNuGetPackageRestore&apos; to &apos;true&apos;. 
        ///
        ///Missing packages: {0}.
        /// </summary>
        internal static string PackageNotRestoredBecauseOfNoConsent {
            get {
                return ResourceManager.GetString("PackageNotRestoredBecauseOfNoConsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package restore canceled..
        /// </summary>
        internal static string PackageRestoreCanceled {
            get {
                return ResourceManager.GetString("PackageRestoreCanceled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restore failed for project {0}: {1}..
        /// </summary>
        internal static string PackageRestoreFailedForProject {
            get {
                return ResourceManager.GetString("PackageRestoreFailedForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package restore finished..
        /// </summary>
        internal static string PackageRestoreFinished {
            get {
                return ResourceManager.GetString("PackageRestoreFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restored finished for project {0}..
        /// </summary>
        internal static string PackageRestoreFinishedForProject {
            get {
                return ResourceManager.GetString("PackageRestoreFinishedForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package restore failed..
        /// </summary>
        internal static string PackageRestoreFinishedWithError {
            get {
                return ResourceManager.GetString("PackageRestoreFinishedWithError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet packages...
        ///To prevent NuGet from restoring packages during build, open the Visual Studio Options dialog, click on the Package Manager node and uncheck &apos;Allow NuGet to download missing packages during build.&apos;.
        /// </summary>
        internal static string PackageRestoreOptOutMessage {
            get {
                return ResourceManager.GetString("PackageRestoreOptOutMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restored NuGet package {0}..
        /// </summary>
        internal static string RestoredPackage {
            get {
                return ResourceManager.GetString("RestoredPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet packages....
        /// </summary>
        internal static string RestoringPackages {
            get {
                return ResourceManager.GetString("RestoringPackages", resourceCulture);
            }
        }
    }
}
