using System;
using System.Collections.Generic;
using System.Linq;

namespace MVVMDemo.Models
{
    public class EmployeeService
    {
        private static List<Employee> EmployeesList;

        public EmployeeService()
        {
            EmployeesList = new List<Employee>()
            {
                new Employee(1, "Valery", 21),
            };
        }

        public List<Employee> GetAllEmployees()
        {
            return EmployeesList;
        }

        public bool AddEmployee(Employee newEmp)
        {
            if (EmployeesList.Contains(newEmp))
                return false;

            if (newEmp.Age < 18 || newEmp.Age > 66)
                throw new ArgumentException("Invalid age limit for employee!");

            EmployeesList.Add(newEmp);

            return true;
        }

        public bool UpdateEmployee(Employee empToUpdate)
        {
            bool isUpdated = false;
            Employee foundEmp = EmployeesList.FirstOrDefault(e => e.Id == empToUpdate.Id);

            if (foundEmp != null)
            {
                foundEmp.Name = empToUpdate.Name;
                foundEmp.Age = empToUpdate.Age;
                isUpdated = true;
            }

            return isUpdated;
        }

        public bool DeleteEmployee(int id)
        {
            bool isDeleted = false;
            Employee foundEmp = EmployeesList.FirstOrDefault(e => e.Id == id);

            if (foundEmp != null)
            {
                EmployeesList.Remove(foundEmp);
                isDeleted = true;
            }

            return isDeleted;
        }

        public Employee SearchEmployee(int id)
        {
            return EmployeesList.FirstOrDefault(e => e.Id == id);
        }
    }
}
