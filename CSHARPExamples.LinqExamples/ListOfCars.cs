using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.LinqExamples {
    internal class ListOfCars {
        private Car[] array = new Car[100];
        public int Count { get; private set; }
        public void Add(Car item) {
            array[Count++] = item;
        }
        public Car ItemAt(int index) {
            return array[index];
        }
        public void InsertAt(Car item, int position) {

        }
    }
}
