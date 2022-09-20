using Apps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InterfacesExamples {
    internal class Calculator : IApp {
        public Calculator(string name) {
            Name = name;
        }
        public string Name { get; }
        public string[] GetPermissions() {
            return new string[] { "read", "write" };
        }
        public void UnpackFiles(string filePath) {
            Console.WriteLine($"unpacking files on {filePath}....");
        }
        public byte[] GetIcon() {
            return new byte[] { 0, 12, 1, 54, 7, 3, 33 };
        }
    }
}
