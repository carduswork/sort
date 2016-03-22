using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace sirt
{
    class Program
    {
        public static List<Employee> es = new List<Employee>();
        static void Main(string[] args)
        {
            es.Add(new Employee("1", "1", "1"));
            es.Add(new Employee("1", "1", "5"));
            es.Add(new Employee("1", "1", "3"));
            es.Sort(new SCompare());
            foreach (Employee e in es)
            { 
            Console.WriteLine(e.Salary);
            }
            Console.ReadKey();
        }
    }
}
