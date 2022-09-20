using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    public class Product {
        private static decimal interest;
        static Product() {
            interest = 45;   
        }
        public static void IncreaseInterest() {
            interest++;
        }

        private int id;
        private string brand;
        private bool something;
        private string name;
        private decimal price;

        public void Deconstruct(out int id, out string brand, out string name, out decimal price, out bool something) {
            id = this.id;
            brand = this.brand;
            name = this.name;
            price = this.price;
            something = this.something;
        }

        //public Product() {
        //    id = 4;
        //}
        public Product(int id, string brand, bool something) {
            this.id = id;
            Brand = brand;
            this.something = something;
        }
        public Product(int id, string brand) : this(id, brand, false){
            
        }
        //new Product(9)
        public Product(int id) : this(id, string.Empty) {
            
        }
        ~Product() {
            brand = null;
        }
        public void Dispose() { 
            GC.SuppressFinalize(this);
        }
        public int Id {
            //private set {
            //    id = value;
            //}
            get { return id; }
        }

        //Property Price
        
        public decimal Price {
            set { 
                if (value < 0) {
                    throw new ArgumentException("value cannot be negative!!");
                }
                
                price = value;
            }
            get { 
                return price;
            }
        }
        //end of property Price

        //property Name
        

        public string Name 
        {
            //void _setName(string value)
            set 
            {
                name = value;
            }
            //string _getName()
            get {
                return name;
            }
        }

        
        public string   Brand{
            get { return brand; }
            set {
                if (value.Length > 255) {
                    throw new ArgumentException();
                }
                brand = value; 
            }
        }

        //end of Property Name
        public bool Validate()
        {
            return price >= 0;
        }

        public decimal PriceWithVat() 
        {
            return price * 1.2M;
        }
    }
}
