using Apps;
using CSHARPExamples.FirstConsoleExample.InterfacesExamples;

namespace WhatsAppLibrary {
    public class WhatsApp : IApp, INetworkComponent {
        public string Name { get; set; }

        public byte[] GetIcon() {
            throw new NotImplementedException();
        }

        public string[] GetPermissions() {
            throw new NotImplementedException();
        }

        public void NetworkIsOff() {
            throw new NotImplementedException();
        }

        public void NetworkIsOn() {
            throw new NotImplementedException();
        }

        public void UnpackFiles(string filePath) {
            throw new NotImplementedException();
        }
    }
}