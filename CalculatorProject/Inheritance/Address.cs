using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Address : NttDataBase
    {
        public string street { get; set; }
        public string city { get; set; }
        public string region { get; set; }

        public Address(string street, string city, string region) :base()
        {
            this.street = street;
            this.city = city;
            this.region = region;
        }
    }
}
