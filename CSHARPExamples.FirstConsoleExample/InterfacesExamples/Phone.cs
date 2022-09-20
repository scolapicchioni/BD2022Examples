using Apps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSupport.System {
    public class Phone {
        private IApp[] apps = new IApp[10];
        public int Count { get; private set; } = 0;
        public void Install(IApp appToInstall) {
            Console.WriteLine($"Installing app {appToInstall.Name}");
            string[] permissionRequested = appToInstall.GetPermissions();
            appToInstall.UnpackFiles(@"c:\apps\");
            byte[] icon = appToInstall.GetIcon();
            apps[Count++] = appToInstall;
        }

        public IApp[] GetApps() {
            return apps;
        }
    }
}

namespace Microsoft  {
    class ClassB { 
        
    }
}
