using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject
{
    internal class FirstMenu
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int add=0, case_1=0;
            Employee employee = new Employee();
            do
            {
                Console.Clear();

                Console.WriteLine("Welcome to your payroll program");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new employee");
                Console.WriteLine("2. Close program");
                add=int.Parse(Console.ReadLine());

                switch (add)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            employee.addData();
                            employee.printData();
                            employee.DocTXT();
                            Console.WriteLine("Would you like to add a new employee?");
                            Console.WriteLine("1. Yes");
                            Console.WriteLine("2. No");
                            case_1=int.Parse(Console.ReadLine());
                        } while (case_1!=2);
                        break;
                    case 2:
                        Console.WriteLine("Closing program");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please enter another value");
                        break;
                }

            } while (add!=2);
            Console.ReadKey();

        }
    }
}
