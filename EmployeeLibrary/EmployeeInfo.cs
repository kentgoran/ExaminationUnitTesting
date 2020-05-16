using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EmployeeLibrary
{
    public class EmployeeInfo
    {
        private string empNum;
        private string name;
        private string adress;
        private int age;
        private Regex empNumMatcher = new Regex("^[0-9]{4}$");

        public string EmpNum
        {
            get
            {
                return empNum;
            }
            set
            {
                if (empNumMatcher.IsMatch(value))
                {
                    empNum = value;
                }
                else
                {
                    throw new InvalidCastException($"\"{value}\" is not a valid EmpNum. Needs to be 4 digits (0000-9999).");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentNullException("Name can't be null or empty.");
                }
            }
        }
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    adress = value;
                }
                else
                {
                    throw new ArgumentNullException("Adress can't be null or empty.");
                }
            }
        }
        public City City { get; set; }
        public State State { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 18 || value > 60)
                {
                    throw new ArgumentOutOfRangeException("Age needs to be between 18 and 60");
                }
                else
                {
                    age = value;
                }
            }
        }
        public Gender Gender { get; set; }
        public List<Hobby> Hobbies { get; set; }

        public EmployeeInfo()
        {

        }

        /// <summary>
        /// Returns a string containing employeeNumber and Name, separated by a colon(:)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{EmpNum} : {Name}";
        }

        /// <summary>
        /// Returns a string containing all the data correlating to the given employeeinfo
        /// </summary>
        /// <returns></returns>
        public string ToLongString()
        {
            StringBuilder details = new StringBuilder();
            details.Append("EmpNo: " + EmpNum);
            details.Append("\r\nName: " + Name);
            details.Append("\r\nAdress: " + Adress);
            details.Append("\r\nCity: " + City);
            details.Append("\r\nState: " + State);
            details.Append("\r\nDOB: " + DateOfBirth.ToShortDateString());
            details.Append("\r\nAge: " + Age);
            details.Append("\r\nGender: " + Gender);

            StringBuilder hobbies = new StringBuilder();
            foreach (Hobby h in Hobbies)
            {
                hobbies.Append(h);
                hobbies.Append("\r\n\t");
            }
            details.Append("\r\nHobbies: ");
            details.Append(hobbies.ToString());
            return details.ToString();
        }
    }
}
