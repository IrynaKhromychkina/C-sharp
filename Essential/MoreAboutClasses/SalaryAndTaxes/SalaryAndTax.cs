using System;

namespace SalaryAndTaxes
{
    public class SalaryAndTax
    {
        private const double taxRate = 0.38;

        double salary;
        double tax; //amount of tax to be deducted

        public SalaryAndTax(double salary)
        {
            this.salary = salary;
            tax = salary * taxRate;
        }
        public void ShowFiancialData()
        {
            if (salary > 0)
            {
                Console.WriteLine($"Salary is {salary} and tax is {tax}");
            }
            else
            {
                Console.WriteLine("Wrong position - can not calculate salary and tax");
            }
        }
    }
}
