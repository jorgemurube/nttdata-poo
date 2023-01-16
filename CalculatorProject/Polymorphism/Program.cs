using CalculatorProject.PlanDePensiones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();  
            Student student = new Student();

            student.Name= "Pepe";

            //BOXING AND AUTOBOXING option 1
            arrayList.Add(student);

            Console.WriteLine(((Student)arrayList[0]).Name);

            //BOXING AND AUTOBOXING option 2

            object obj = new Student();                     //BOXING
            ((Student)obj).Name = "Alberto";                //UNBOXING
            Console.WriteLine(((Student)obj).Name);
        }
    }
}
