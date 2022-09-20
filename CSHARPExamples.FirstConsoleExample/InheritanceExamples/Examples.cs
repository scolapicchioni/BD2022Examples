using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample.InheritanceExamples {
    internal class Examples {
        public void Example02() {
            Cat cat = new Cat("Mr Wiggles");
        
        }

        //IS A
        public void Example01() { 
            Animal animal = new Animal("");
            animal.Legs = 4;
            //animal.Eat();

            Cat cat = new Cat() { Name = "Mr. Fluffy", Legs = 4 };
            Console.WriteLine($"{cat.Name} has {cat.Legs}");
            //cat.Eat();


            //Animal a = new Cat() { };
            
            UseAnimal(animal);
            UseAnimal(cat);
        }

        public void UseAnimal(Animal animal) {
            Console.WriteLine($"{animal.Name} has {animal.Legs}");
            animal.Eat();

            //if (animal is not null && animal is Cat) {
            //    Cat c = (Cat)animal;

            //}

            //ask, don't tell
            if (animal is Cat c) {
                //c.Eat();
                c.Meow();
            }
        }
        //public void UseAnimal(Cat animal) {
        //    Console.WriteLine($"{animal.Name} has {animal.Legs}");
        //    animal.Eat();
        //}
    }
}
