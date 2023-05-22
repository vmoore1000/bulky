using System;
using System.Collections.Generic;
using System.IO;
using Emby.Bulky.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Emby.Bulky
{

    public class Plugin : BasePlugin<PluginConfiguration>, IHasThumbImage, IHasWebPages
    {
        public static Plugin Instance { get; set; }

        //You will need to generate a new GUID and paste it here - Tools => Create GUID
        public override Guid Id => new Guid("8A1C97CB-AF56-47FE-AC00-188D3776F9E4");


        public override string Name => "Bulky";
        public override string Description => "Mass Metadata Editor for Emby";

        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer, ILogManager logManager) : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }
        public ImageFormat ThumbImageFormat => ImageFormat.Jpg;

        //Display Thumbnail image for Plugin Catalogue  - you will need to change build action for thumb.jpg to embedded Resource
        public Stream GetThumbImage()
        {
            Type type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.jpg");
        }

        //Web pages for Server UI configuration
        public IEnumerable<PluginPageInfo> GetPages() => new[]
        {
            //MAIN PLUGIN PAGES
            new PluginPageInfo
            {
                //html File
                //If in a folder in your project you must include the FolderName as well as the File name.
                Name = "BulkyConfigurationPage",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.BulkyConfigurationPage.html",
                EnableInMainMenu = true,
                DisplayName = "Bulky Editor",
                MenuIcon = "edit_note",
            },
            new PluginPageInfo
            {
                //javascript file
                Name = "BulkyConfigurationPageJS",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.BulkyConfigurationPage.js"
            },
            new PluginPageInfo
            {
                //html File
                Name = "customFiltersPage",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.customFiltersPage.html",
                EnableInMainMenu = false,
                DisplayName = "Custom Filter",
                MenuIcon = "edit_note",
            },
            //ADDITIONAL PAGES - MUST BE USED INSIDE THE MAIN JS PAGE
            new PluginPageInfo
            {
            //javascript file
                Name = "customFiltersPageJS",
                EmbeddedResourcePath = GetType().Namespace + ".Configuration.customFiltersPage.js"
            }
        };
    }
}
