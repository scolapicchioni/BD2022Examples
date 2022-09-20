using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    internal class ReferenceTypesExamples {
        int myValueType; //000000000000000 => 0
        bool myBoolValue; //0000 => false
        string myStringValue = ""; // 0000000000000000 => null

        string[] strings = new string[100]; // 00000000 00000000 00000000 00000000 00000000 000000



        int stringsCounter = 0;

        public void DoSomethingWithMyString() {
            //NullReferenceException
            Console.WriteLine(myStringValue.Length); 
        }

        public void AddString(string stringToAdd) {
            //"hi" 00000 000000 00000 00000
            //"hi" "second" 000000 00000 00000
            strings[stringsCounter++] = stringToAdd;
        }

        public void PrintStrings() {
            foreach (string item in strings) {
                //NullReferenceException
                if(item is not null)
                    Console.WriteLine(item.Length);
                //if (item != null)
                //    Console.WriteLine(item.Length);

                int? lengthOfTheItem = item?.Length;
                //int? lengthOfTheItem = item is not null ? item.Length : null;

                string result = item ?? "";
                //string result = item is not null ? item : "";

                int length = item?.Length ?? 0;
                //int legth = item is not null ? item.Length : 0;
            }

            int length2 = strings[5]?.Length ?? 0;

            //strings[4] = null;


        }

        public void ExampleComparison() {
            Product productTheUserIsLookingFor = new Product(1);
            productTheUserIsLookingFor.Name = "Dell Laptop 5";
            productTheUserIsLookingFor.Price = 100;

            Product productFoundInTheDb = new Product(1);
            productFoundInTheDb.Name = "Dell Laptop 5";

            if (productTheUserIsLookingFor == productFoundInTheDb) {
                Console.WriteLine(productFoundInTheDb.Price);
            }

            Product temp = productTheUserIsLookingFor;

            temp.Name = "Something completely different";

            Console.WriteLine(productTheUserIsLookingFor.Name);

            ChangeProduct(productTheUserIsLookingFor);

        }
        public void ChangeProduct(Product productToChange) {
            productToChange.Price *= 2;
        }
    }
}
