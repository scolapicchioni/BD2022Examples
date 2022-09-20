using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InheritanceExamples {
    internal class Animal {
        public int Legs { get; set; }
        public string Name { get; set; }
        public virtual void Eat() {
            Console.WriteLine("An animal ets like this: Yummi!!");
        }
        //public Animal() {
        //    Console.WriteLine("A NEW ANIMAl IS BORN!!!!");
        //}
        public Animal(string name) {
            Console.WriteLine($"A NEW ANIMAl with the name {name} IS BORN!!!!");
            this.Name = name;
        }
    }
}
