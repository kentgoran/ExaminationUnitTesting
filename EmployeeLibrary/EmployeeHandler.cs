using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace EmployeeLibrary
{
    public class EmployeeHandler
    {
        List<EmployeeInfo> employees = new List<EmployeeInfo>();

        public EmployeeHandler()
        {

        }

        /// <summary>
        /// Attempts to add a new employeeInfo, and returns true if it's a success. Returns false if there already is an employee present with the same employeeNumber
        /// </summary>
        /// <param name="emp">the employee-info to add</param>
        /// <returns>true if successful, else false</returns>
        public bool AddEmployee(EmployeeInfo emp)
        {
            if (EmployeeNumberExists(emp.EmpNum))
            {
                return false;
            }
            else
            {
                employees.Add(emp);
            }
            return true;
        }

        /// <summary>
        /// Searches for, and returns an employeeInfo-instance with given employeeNumber. Returns null if none is found
        /// </summary>
        /// <param name="employeeNumber">the 4 number long string from which to search for an employee</param>
        /// <exception cref="InvalidCastException">Thrown if invalid employee number has been input</exception>
        /// <returns>an EmployeeInfo</returns>
        public EmployeeInfo SearchByEmployeeNumber(string employeeNumber)
        {
            if (!EmployeeNumberIsValid(employeeNumber))
            {
                throw new InvalidCastException("Invalid employee number, needs to be four digits(0000-9999).");
            }
            EmployeeInfo employeeToReturn = (from emp in employees
                                             where emp.EmpNum == employeeNumber
                                             select emp).FirstOrDefault();
            return employeeToReturn;
        }

        /// <summary>
        /// Searches for, and returns a list of employeeInfos which contains the given name, note: ignores case
        /// </summary>
        /// <param name="name">the search string</param>
        /// <exception cref="ArgumentNullException">Thrown if empty or null name has been input</exception>
        /// <returns>A list of employeeInfos</returns>
        public List<EmployeeInfo> SearchByName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name input can't be empty or null.");
            }
            List<EmployeeInfo> employeesToReturn = (from emp in employees
                                                    where emp.Name.ToLower().Contains(name.ToLower())
                                                    orderby emp.EmpNum ascending
                                                    select emp).ToList();


            return employeesToReturn;
        }

        /// <summary>
        /// Tries to update an instance of Employee which has the same empNum, if there is one. Else it returns false
        /// </summary>
        /// <param name="employee">The employee-info to update</param>
        /// <returns>true if success, else false (the employee doesn't exist)</returns>
        public bool UpdateEmployee(EmployeeInfo employee)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].EmpNum == employee.EmpNum)
                {
                    employees[i] = employee;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// A simple check for if the employeeNumber given exists in an existing employeeinfo-instance
        /// </summary>
        /// <param name="empNum">the number to check</param>
        /// <returns>true if it exists, else false</returns>
        public bool EmployeeNumberExists(string empNum)
        {
            foreach(var employee in employees)
            {
                if(employee.EmpNum == empNum)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Method used to validate a given employeeNumber with the given syntax (four digits)
        /// </summary>
        /// <param name="employeeNumber">the string to check for validity</param>
        /// <returns>Boolean. True if valid, else fail</returns>
        public bool EmployeeNumberIsValid(string employeeNumber)
        {
            Regex empNumMatcher = new Regex("[0-9]{4}");
            if (!empNumMatcher.IsMatch(employeeNumber) || employeeNumber.Length != 4)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a couple test-employees from a file, for testing purposes
        /// </summary>
        public void AddManualTestEmployees()
        {
            EmployeeFileReader reader = new EmployeeFileReader();
            employees = reader.GetEmployeeInfos();
        }
    }
}
