using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.LinqExamples {
    internal class ArrayList<TheTypeOfTheItem> {
        private TheTypeOfTheItem[] array = new TheTypeOfTheItem[100];
        public int Count { get; private set; }
        public void Add(TheTypeOfTheItem item) {
            array[Count++] = item;
        }
        public TheTypeOfTheItem ItemAt(int index) {
            return array[index];
        }
        public void InsertAt(TheTypeOfTheItem item, int position) { 
            
        }
    }
}
