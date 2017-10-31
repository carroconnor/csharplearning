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

        public student(string firstName)
        {
            this.FirstName = FirstName;
        }

        public student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }
        
        //Constructor
        public student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        
        ////Constructor 2
        //public student(string firstName, string lastName, int age, int grade)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Age = age;
        //    this.Grade = grade;
        //}

        ////links constructor to strings, int etc

        ////Properties
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public int Grade { get; set; }

        

       
        
    }
}
