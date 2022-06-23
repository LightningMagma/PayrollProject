using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject
{
    internal class Employee
    {
        Data data = new Data();
        const double auxtrans = 117172;
        public void addData()
        {
            Console.WriteLine("Type the ID:");
            data.Document=Console.ReadLine();
            Console.WriteLine("Type the firstname:");
            data.First_name = Console.ReadLine();
            Console.WriteLine("Type the lastname:");
            data.Last_name = Console.ReadLine();
            Console.WriteLine("Type the salary");
            data.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Type the worked days");
            data.Worked_days = double.Parse(Console.ReadLine());

            if (data.Salary<=2000000)
            {
                data.BasicPay = data.Salary + auxtrans;
            }
            else
            {
                data.BasicPay=data.Salary;
            }
            data.Incomes = data.Salary / 30;
            data.Incomes = data.Incomes * data.Worked_days;

            data.Trans = auxtrans / 30;
            data.Trans = data.Trans * data.Worked_days;

            data.Health = data.Salary * 0.04;
            data.Pension = data.Salary * 0.04;

            data.Fullpayment = data.Incomes + data.Trans + data.Health + data.Pension;

            data.Discount = data.Health + data.Pension;

            data.Finalpayment = data.Fullpayment - data.Discount;
        }

        public void printData()
        {
            Console.WriteLine($"ID: {data.Document}");
            Console.WriteLine($"Firstname: {data.First_name}");
            Console.WriteLine($"Lastname: {data.Last_name}");
            Console.WriteLine($"Incomes: {data.Fullpayment}");
            Console.WriteLine($"Payment for worked days: {data.Incomes}");
            Console.WriteLine($"Payment for transportation assistance: {data.Trans}");
            Console.WriteLine($"Contribution to health: {data.Health}");
            Console.WriteLine($"Contribution to pension: {data.Pension}");
            Console.WriteLine($"Final payment: {data.Finalpayment}");
        }

        public void DocTXT()
        {
            StreamWriter newEmployee = new StreamWriter("EmployeeData.TXT", true);
            newEmployee.WriteLine($"Employee ID: {data.Document}");
            newEmployee.WriteLine($"Employee Firstname: {data.First_name}");
            newEmployee.WriteLine($"Employee Lastname: {data.Last_name}");
            newEmployee.WriteLine($"Employee Payment: {data.Fullpayment}");
            newEmployee.WriteLine($"Worked days: {data.Worked_days}");
            newEmployee.WriteLine($"Transportation assistance: {data.Trans}");
            newEmployee.WriteLine($"Contribution to health: {data.Health}");
            newEmployee.WriteLine($"Contribution to Pension: {data.Pension}");
            newEmployee.WriteLine($"Final payment: {data.Finalpayment}");
            newEmployee.Close();
        }

    }
}
