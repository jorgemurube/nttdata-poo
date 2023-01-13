using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student : NttDataBase 
    {

        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthay { get; set; }
        public Address address { get; set; }
        public int age { get; set; }

        public Student(string name, string surname, DateTime birthay, Address address) : base()
        {
            this.name = name;   
            this.surname = surname;
            this.birthay = birthay;
            this.address = address;
            this.age = int.Parse((DateTime.Now.Subtract(birthay)).ToString());
           
        }
    }
}
