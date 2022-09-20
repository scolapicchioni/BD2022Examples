using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InheritanceExamples {
    internal class TextBox : Control {
        public override void Draw() {
            base.Step01OfTheDraw();
            Console.WriteLine("Draw of a textbox");
        }
    }
}
