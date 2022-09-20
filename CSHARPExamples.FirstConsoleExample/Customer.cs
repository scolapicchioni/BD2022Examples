using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    internal class Customer {
        public int Id { get; set; }
        public string Name { get; set; }

        //HAS A
        public Address HouseAddress { get; set; }

        public Customer() {
            HouseAddress = new Address();
        }
    }
}
