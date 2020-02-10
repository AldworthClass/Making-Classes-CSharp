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
            GenerateEmail();
        }

        public string Email
        {
            get
            {
                return email;
            }
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
                GenerateEmail();
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
               GenerateEmail();
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

        public void ResetStudentNumber()
        {
            Random generator = new Random();
            this.studentNumber = generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }

        private void GenerateEmail()
        {
            email = firstName.Substring(0, 3) + lastName.Substring(0, 3) + (studentNumber + "").Substring(3) + "@ICS4U.com";
        }
    }
}
