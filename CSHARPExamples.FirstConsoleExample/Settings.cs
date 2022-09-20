using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    public class Settings {
        private static Settings singletonInstance;
        private Settings() {

        }

        public static Settings MakeASettingsObject() {
            if (singletonInstance is null) { 
                singletonInstance = new Settings();
            }
            return singletonInstance;
        }

        public Color BackgroudColor { get; set; }
        public Color TextColor { get; set; }
    }
}
