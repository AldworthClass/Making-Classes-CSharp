using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;
        
        public Student(string firstName, string lastName)
        {
            Random generator = new Random();
            this.firstName = firstName;
            this.lastName = lastName;
            studentNumber = generator.Next(0, 1000) + 555000;
        }
        
        //Property to provide access to firstName
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        //Property to provide access to lastName
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
               lastName = value;
            }
        }

        //Property to provide access to studentNumber
        public int StudentNumber
        {
            get
            {
                return studentNumber;
            }
        }
       
        //Overrides ToString() 
         public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
