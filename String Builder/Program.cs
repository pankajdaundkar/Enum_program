using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static String_Builder.Employee;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Employee1 emp1 = new Employee1("Rajesh", 24000, Dept.Sales);
                emp1.CalculateSalary();
                Console.WriteLine(emp1.PrintEmpSalary());
                Console.WriteLine(emp1);

                Employee1 emp2 = new Employee1("Amol", 34000, Dept.Testing);
                emp2.CalculateSalary();
                Console.WriteLine(emp2.PrintEmpSalary());
                Console.WriteLine(emp2);

                Student s1 = new Student("PANKAJ",123,86,98,65,Streams.IT );
                s1.Calculate();
                Console.WriteLine(s1.ToString());

            }

        }
    }
}
