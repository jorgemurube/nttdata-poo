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
            Address adress = new Address("Calle Infantes 29", "Madrid", "España");
            if (PrintStudents.StudentList.Count == 0)
            {
                PrintStudents.CreateStudentList("Sergio", "Perez", DateTime.Parse((1966 / 05 / 30).ToString()), adress);
            }
            for(int i=0; i < PrintStudents.CreateFilterStudentList().Count;i++)
            {
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].name.Substring(0) == "S");
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].age > 30);
                Assert.IsTrue(PrintStudents.CreateFilterStudentList()[i].address.city == "Madrid");
            }
            
        }
    }
}