using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InheritanceExamples {
    internal class Cat : Animal
    {
        public Cat() : base("") {
            Console.WriteLine("A CAT IS BORN!");
        }
        public Cat(string name) : base (name)  {
            Console.WriteLine($"A NEW CAT with the name {name} IS BORN!!!!");
        }
        //public int Legs { get; set; }
        //public string Name { get; set; }
        public override void Eat() {
            base.Eat();
            //throw new NotImplementedException();
            Console.WriteLine("A cat eats like this: I eat mice!");
        }
        public void Meow() {
            Console.WriteLine("purrrr");
        }
    }
}
