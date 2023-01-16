using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance.Tests
{
    [TestClass()]
    public class PrintStudentsTests
    {
        [TestMethod()]
        public void filterStudentTest()
        { 
            Address address = new Address("Calle Infantes 29", "Madrid", "España");

            
            if (PrintStudents.StudentList.Count == 0)
            {
                PrintStudents.CreateStudentList("Sergio", "Perez", DateTime.Parse("2002 / 4 / 3 "), address);
            }
            for(int i=0; i < PrintStudents.StudentList.Count;i++)
            {
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].name.Substring(0).Equals("S"));
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].age > 30);
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].address.city.Equals("Madrid"));
            }
            
        }
    }
}