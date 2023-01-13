using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Loops
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public Guid Guid { get; set; }

        public Product()
        {
            Guid= Guid.NewGuid();
        }
        
        public Product(int Id, String Name, float Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            Guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return "Product:" + this.Name + "," + this.Id+ "," + this.Price; 
        }
    }
}
