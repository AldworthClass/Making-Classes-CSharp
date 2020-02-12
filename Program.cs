using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string fName, lName;


            students.Add(new Student("Oscar", "Grouch"));
            students.Add(new Student("Alfred", "Barkley"));
            students.Add(new Student("Steve", "Aldworth"));
            foreach (Student student in students)
                Console.WriteLine(student);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter a first name:");
                fName = Console.ReadLine();
                Console.WriteLine("Please enter a last name:");
                lName = Console.ReadLine();
                students.Add(new Student(fName, lName));
            }


            Console.WriteLine(students.IndexOf(person));
            students.Add(person);

            

            

            students.Sort();
           
            foreach (Student student in students)
                Console.WriteLine(student);

            Console.ReadLine();
        }
    }
}
