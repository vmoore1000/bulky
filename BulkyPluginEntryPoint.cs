using System;
using System.Linq;
using System.Threading.Tasks;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Controller.Configuration;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Model.IO;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Tasks;

namespace Emby.Bulky
{
    public class BulkyPluginEntryPoint : IServerEntryPoint
    {
        public BulkyPluginEntryPoint(IServerConfigurationManager config, ITaskManager taskManager,
            IFileSystem fileSystem, ILogManager logManager, ILibraryMonitor libraryMonitor, ILibraryManager libraryManager)
        {
           
        }
        public void Run()
        {
            //Plugin.Instance.UpdateConfiguration(Plugin.Instance.Configuration);
            
        }

        private void LibraryManagerItemRemoved(object sender, ItemChangeEventArgs e)
        {
            
        }

        private async void LibraryManagerItemAdded(object sender, ItemChangeEventArgs e)
        {

            
        }

        public void Dispose()
        {
            //Plugin.Instance.UpdateConfiguration(Plugin.Instance.Configuration);
        }

        private void TaskManagerOnTaskCompleted(object sender, TaskCompletionEventArgs e)
        {
            
        }


    }
}
