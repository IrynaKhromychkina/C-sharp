using System;

namespace SalaryAndTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jeff", "Bezos"); //name and surname
            SalaryAndTax employeeFinancialData = employee.Calculate("CEO", 25); //position and years of experience
            employee.ShowData();
            employeeFinancialData.ShowFiancialData();

            Console.ReadKey();
        }
    }
}
