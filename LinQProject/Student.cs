using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQProject
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int age { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] studentArray = {
                    new Student() { StudentID = 1, StudentName = "will", age = 18 } ,
                    new Student() { StudentID = 2, StudentName = "smith",  age = 21 } ,
                    new Student() { StudentID = 3, StudentName = "blake",  age = 25 } ,
                    new Student() { StudentID = 4, StudentName = "scott" , age = 20 } ,
                    new Student() { StudentID = 5, StudentName = "root" , age = 31 } ,
                    new Student() { StudentID = 6, StudentName = "mike",  age = 17 } ,
                    new Student() { StudentID = 7, StudentName = "kane",age = 19  } ,
                };

            // Use LINQ to find adult students
            Student[] adultStd = studentArray.Where(s => s.age > 18 && s.age < 50).ToArray();
            Console.WriteLine("Use LINQ to find Adult students");
            foreach (Student sd in adultStd)
            {
                Console.WriteLine(sd.StudentID + " " + sd.StudentName);
            }

            // Use LINQ to find first student whose name is mike 
            Console.WriteLine("Use LINQ to find first student whose name is mike");
            Student b = studentArray.Where(s => s.StudentName == "mike").FirstOrDefault();

            Console.WriteLine("Student id is " + b.StudentID);

            // Use LINQ to find student whose StudentID is 5
            Console.WriteLine("Use LINQ to find student whose StudentID is 5");
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();

            Console.WriteLine("Student name is " + student5.StudentName);

        }
    }
}
