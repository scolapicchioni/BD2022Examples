using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps {
    public interface IApp {
        string Name { get; }
        string[] GetPermissions();
        void UnpackFiles(string filePath);
        byte[] GetIcon();
    }
}
