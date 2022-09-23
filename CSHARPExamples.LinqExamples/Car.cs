using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.LinqExamples {
    internal class Car {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        override public string ToString() => $"{Id} - {Brand} - {Name} - {Price}";
    }
}
