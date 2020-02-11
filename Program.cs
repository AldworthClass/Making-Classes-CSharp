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
            
            students.Add(new Student("Oscar", "Grouch"));
            students.Add(new Student("Alfred", "Barkley"));
            students.Add(new Student("Steve", "Aldworth"));
            Student person = new Student("Steve", "Aldworth");
            Console.WriteLine(students.IndexOf(person));
            students.Add(person);

            

            

            students.Sort();
           
            foreach (Student student in students)
                Console.WriteLine(student);

            Console.ReadLine();
        }
    }
}
