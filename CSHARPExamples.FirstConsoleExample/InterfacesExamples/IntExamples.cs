using InfoSupport.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InterfacesExamples {
    internal class IntExamples {
        public void Example01() {
            Phone phone = new Phone();
            phone.Install(new Calculator("Calc"));
        }
    }
}
