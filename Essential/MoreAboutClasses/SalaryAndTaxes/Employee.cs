using System;

namespace SalaryAndTaxes
{
    public class Employee
    {
        private const int ceoSalary = 15000;
        private const int finDirSalary = 10000;
        private const int pmSalary = 8000;
        private const int teamLeadSalary = 6000;
        private const int developerSalary = 5000;

        private readonly string name;
        private readonly string surname;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void ShowData() => Console.WriteLine($"The employee names is: {name} {surname}.");

        public SalaryAndTax Calculate(string position, int yearsOfExperience)
        {
            double salaryIndex = 1 + yearsOfExperience * 0.1;

            string positionInLowerCase = position.Trim().ToLower();
            switch (positionInLowerCase)
            {
                case "ceo":
                    {
                        
                        SalaryAndTax employeeFinances = new SalaryAndTax(ceoSalary * salaryIndex);
                        return employeeFinances;
                    }
                case "financial director":
                    {
                        SalaryAndTax employeeFinances = new SalaryAndTax(finDirSalary * salaryIndex);
                        return employeeFinances;
                    }
                case "project manager":
                    {
                        SalaryAndTax employeeFinances = new SalaryAndTax(pmSalary * salaryIndex);
                        return employeeFinances;
                    }
                case "team lead":
                    {
                        SalaryAndTax employeeFinances = new SalaryAndTax(teamLeadSalary * salaryIndex);
                        return employeeFinances;
                    }
                case "developer":
                    {
                        SalaryAndTax employeeFinances = new SalaryAndTax(developerSalary * salaryIndex);
                        return employeeFinances;
                    }
                default:
                    {
                        SalaryAndTax employeeFinances = new SalaryAndTax(0);
                        return employeeFinances;
                    }
            }
        }
    }
}
