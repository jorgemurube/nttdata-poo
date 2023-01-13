using CalculatorProject.Loops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class PrintStudents
    {
       public static List<Student> StudentList = new List<Student>();
        public static List<Student> CreateStudentList(string name, string surname, DateTime birthday, Address address) 
        {
            
            var student = new Student(name, surname, birthday, address);
            StudentList.Add(student);
            return StudentList;
        }  

        public static List<Student> CreateFilterStudentList()
        {

            IEnumerable<Student> filterListLinq =
                                                from student in StudentList
                                                where student.age > 30 && student.name.Substring(0) == "S" && student.address.city == "Madrid"
                                                select student
                                                ;
            return filterListLinq.ToList();

        }
    }
}
