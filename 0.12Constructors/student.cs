using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12Constructors
{
    class student
    {
        //Constructor
        public student()
        {

        }
        //Constructor2
        public student(string firstName)
        {
            this.FirstName = firstName;
        }

        public student(string lastName, int grade)
        {
            this.LastName = lastName;

            this.Grade = grade;
        }
        
        //Constructor3
        public student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        //Constructor4
        public student(string firstName, string lastName, int grade, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Age = age;

        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }





    }
}
