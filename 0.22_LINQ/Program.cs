using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);
                
            }

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1, Name="Johnboy",Hiredate=new DateTime(2015,3,5)},
                new Employee {ID=2, Name="Rolph",Hiredate=new DateTime(2016,9,23)},
                new Employee {ID=3, Name="Plank",Hiredate=new DateTime(2016,12,1)}

            };

            //draw employees that started in 2016 & alphabetize w 'orderby' and 'ascending'

            IEnumerable<Employee> queryTwo = from e in employees
                                             where e.Hiredate.Year == 2016
                                             orderby e.Name ascending
                                             select e;
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }
           
            Console.ReadLine();
            // pull employee with id bigger than 1
            IEnumerable<Employee> queryThree = from e in employees
                                               where e.ID > 1
                                               select e;

            foreach (Employee employee in queryThree)
            {
                Console.WriteLine(employee.ID);
            }

            Console.ReadLine();


        }
    }
}
