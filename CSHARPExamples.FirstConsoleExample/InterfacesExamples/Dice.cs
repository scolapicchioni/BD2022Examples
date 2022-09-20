using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InterfacesExamples {
    public class Dice : IDice {
        private readonly Random random;
        public Dice(int size) {
            Size = size;
            random = new Random();
        }

        public int Size { get; }
        public int Roll() { 
            return random.Next(1, Size + 1);
        }
    }
}
