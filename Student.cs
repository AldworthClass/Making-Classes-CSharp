using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Classes
{
    class Student
    {       
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;

        private string _email;
        private int _studentNumber;
        
        public Student(string firstName, string lastName)
        {
            //Random generator = new Random();
            _firstName = firstName.Trim();
            _lastName = lastName.Trim();
            _studentNumber = generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }

        public string Email
        {
            get
            {
                return _email;
            }
        }

        //Property to provide access to firstName
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                GenerateEmail();
            }
        }

        //Property to provide access to lastName
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
               _lastName = value;
               GenerateEmail();
            }
        }

        //Property to provide access to studentNumber
        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
        }
       
        //Overrides ToString() 
         public override string ToString()
        {
            return _firstName + " " + _lastName;
        }


        public void ResetStudentNumber()
        {
            _studentNumber = generator.Next(0, 1000) + 555000;
            GenerateEmail();
        }


        private void GenerateEmail()
        {
            string first, last;

            if (_firstName.Length <= 3)
                first = _firstName;
            else
                first = _firstName.Substring(0, 3);

            if (_lastName.Length <= 3)
                last = _lastName;
            else
                last = _lastName.Substring(0, 3);

            _email = first + last + (_studentNumber + "").Substring(3) + "@ICS4U.com";
            
        }



        //Comparison Section

        public int CompareTo(Student that)
        {
            if (this.LastName.CompareTo(that.LastName) == 0) //If last names are equal, compares first names
                return this.FirstName.CompareTo(that.FirstName);  

            return this.LastName.CompareTo(that.LastName);  //Otherwise compares last names
        }


        //Overrides Equals
        public override bool Equals(object obj)
        {
            Student student = obj as Student;   //cast object to Student for comparison
            if (student == null)
                return false;
            return this.FirstName == student.FirstName && this.LastName == student.LastName && this.StudentNumber == student.StudentNumber;
        }
        //Overrides hash code
        public override int GetHashCode()
        {
            return (_firstName+_lastName+_studentNumber).GetHashCode();
        }

    }
}
