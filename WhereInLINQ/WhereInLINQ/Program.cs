using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereInLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var datasource = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var Querysyntax = (from number in datasource
                               where number > 6
                               select number).ToList();

            var methodsyntax = datasource.Where(num => num > 6).ToList();

            Console.ReadLine();
        }
    }
}
