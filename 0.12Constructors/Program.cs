using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Did the same oberation in () below
            //student jayStudent = new student();
            //jayStudent.FirstName = "Jay";
            //jayStudent.LastName = "Jackson";
            //jayStudent.Grade = 1;
            //jayStudent.Age = 5;

            student jenn = new student("Jenn");

            student carr = new student("OConnor, 8");

            student jayStudent = new student("Jay", "Jackson", 5, 1);



            



        }
    }
}
