using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollProject
{
    internal class Data
    {
        string document;
        string first_name;
        string last_name;
        double salary;
        double worked_days;
        double health;
        double pension;
        double basicPay;
        double incomes;
        double trans;
        double fullpayment;
        double discount;
        double finalpayment;

        public Data() { }

        public string Document { get => document; set => document = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Worked_days { get => worked_days; set => worked_days = value; }
        public double Health { get => health; set => health = value; }
        public double Pension { get => pension; set => pension = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }
        public double Incomes { get => incomes; set => incomes = value; }
        public double Trans { get => trans; set => trans = value; }
        public double Fullpayment { get => fullpayment; set => fullpayment = value; }
        public double Discount { get => discount; set => discount = value; }
        public double Finalpayment { get => finalpayment; set => finalpayment = value; }
    }
}
