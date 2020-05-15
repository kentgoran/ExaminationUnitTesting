using System;
using System.Collections.Generic;
using System.IO;

namespace EmployeeLibrary
{
    internal class EmployeeFileReader
    {
        //filename is made with backing out of the path this way in order to be able to test
        private string filename = "..\\..\\..\\EmployeeInformation\\bin\\Debug\\testdata.txt";

        /// <summary>
        /// Reads from "filename" and turns it into a list of employeeInfo's
        /// </summary>
        /// <returns>a List of EmployeeInfos</returns>
        internal List<EmployeeInfo> GetEmployeeInfos()
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException($"The file \"{filename}\" has been removed. Contact support");
            }
            List<EmployeeInfo> toReturn = new List<EmployeeInfo>();
            using(StreamReader sr = new StreamReader(filename))
            {
                string readLine = sr.ReadLine();
                while(readLine != null)
                {
                    toReturn.Add(ConvertToEmployeeInfo(readLine));
                    readLine = sr.ReadLine();
                }
            }

            return toReturn;
        }

        /// <summary>
        /// Converts a string in the format 1234~Simon Westman~Kulls väg 8~0~0~2000-08-10~19~0~1,2,3 to an employeeInfo, and returns it
        /// </summary>
        /// <param name="info">the string to convert to an employeeInfo</param>
        /// <returns>an EmployeeInfo</returns>
        private EmployeeInfo ConvertToEmployeeInfo(string info)
        {
            //Manual test data is split up like this: 1234~Simon Westman~Kulls väg 8~0~0~2000-08-10~19~0~1,2,3
            try
            {
                string[] splitLine = info.Split('~');
                City city = (City)int.Parse(splitLine[3]);
                State state = (State)int.Parse(splitLine[4]);
                DateTime dateOfBirth = DateTime.Parse(splitLine[5]);
                int age = int.Parse(splitLine[6]);
                Gender gender = (Gender)int.Parse(splitLine[7]);
                List<Hobby> hobbies = new List<Hobby>();
                string[] splitHobbies = splitLine[8].Split(',');
                foreach (var hobby in splitHobbies)
                {
                    hobbies.Add((Hobby)int.Parse(hobby));
                }
                EmployeeInfo employeeToReturn = new EmployeeInfo()
                {
                    EmpNum = splitLine[0],
                    Name = splitLine[1],
                    Adress = splitLine[2],
                    City = city,
                    State = state,
                    DateOfBirth = dateOfBirth,
                    Age = age,
                    Gender = gender,
                    Hobbies = hobbies
                };
                return employeeToReturn;
            }
            catch(Exception ex)
            {
                throw new ArgumentException("The input data has been corrupted somehow.\n" + ex.Message);
            }

        }
    }
}
