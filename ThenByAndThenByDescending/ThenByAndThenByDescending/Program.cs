using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenByAndThenByDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            var datasource = new List<Employee>
            {
                new Employee()
                {
                    Id=2,
                    Email="kishor@gmail.com",
                    FirstName="kishor",
                    LastName="bene"
                },
                 new Employee()
                {
                    Id=4,
                    Email="rohan@gmail.com",
                    FirstName="rohan",
                    LastName="gole"
                },
                  new Employee()
                {
                    Id=1,
                    Email="amit@gmail.com",
                    FirstName="amit",
                    LastName="gole"
                },
                   new Employee()
                {
                    Id=3,
                    Email="sumit@gmail.com",
                    FirstName="sumit",
                    LastName="bene"
                }

            };
            var ms = datasource.OrderBy(emp => emp.LastName).ThenBy(emp=>emp.FirstName).ToList();

            var qs = from emp in datasource
                     orderby emp.LastName descending, emp.FirstName ascending
                     select emp;

            foreach(var item in qs)
            {
                Console.WriteLine($"{item.Id},first name = {item.FirstName},last name ={item.LastName},email={item.Email}");
            }
            Console.ReadLine();
        }
    }
}
