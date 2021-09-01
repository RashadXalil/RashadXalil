using System;
using System.Collections.Generic;
using System.Text;

namespace Rashadxalilovconsoleapp.Models
{
    class Department
    {
        
        public string Name;
        public int WorkerLimit;
        public double SalaryLimit;
        public Employee[] Employees;

        public Department(string name,int workerlimit,double salarylimit  )
        {
            Name = name;
            WorkerLimit = workerlimit;
            SalaryLimit = salarylimit;
            Employees = new Employee[0];
        }
        // arayi resize etmek ucun method(elave etmek ucun)
        public void AddEmployye(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;

        }
        // Ortalama maasi hesablamaq ucun method
        public double CalcSum()
        {
            double sum = 0;
            foreach (var item in Employees)
            {
                sum += item.Salary;
            }
            double average = sum / Employees.Length;
            return average;
        }

       
    }
}
