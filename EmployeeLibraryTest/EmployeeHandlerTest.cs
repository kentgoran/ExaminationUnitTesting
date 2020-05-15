using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System.Collections.Generic;
using System.IO;

namespace EmployeeLibraryTest
{
    [TestClass]
    public class EmployeeHandlerTest
    {
        EmployeeHandler employeeHandler;
        [TestInitialize]
        public void Initialize()
        {
            employeeHandler = new EmployeeHandler();
            EmployeeInfo employee = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };
            employeeHandler.AddEmployee(employee);
        }

        [TestMethod]
        public void AddNewEmployee()
        {
            EmployeeInfo employee = new EmployeeInfo
            {
                EmpNum = "1235",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nainital,
                State = State.Karnataka,
                DateOfBirth = new DateTime(1988, 04, 16),
                Age = 32,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Sleeping, Hobby.Painting }
            };
            bool success = employeeHandler.AddEmployee(employee);

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void AddNewEmployee_EmployeeExistsAlready()
        {
            EmployeeInfo employee = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };
            bool success = employeeHandler.AddEmployee(employee);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void SearchByEmpNum_EmployeeExists()
        {
            EmployeeInfo employee = employeeHandler.SearchByEmployeeNumber("1234");

            Assert.AreEqual("Simon Westman", employee.Name);
        }

        [TestMethod]
        public void SearchByEmpNum_NonExisting()
        {
            EmployeeInfo employee = employeeHandler.SearchByEmployeeNumber("0000");

            Assert.AreEqual(null, employee);
        }

        [TestMethod]
        public void SearchByName_OneEmployeeFound()
        {
            List<EmployeeInfo> employeesFound = employeeHandler.SearchByName("Simon Westman");


            Assert.AreEqual(1, employeesFound.Count);
        }

        [TestMethod]
        public void SearchByName_SeveralEmployeesFound()
        {
            EmployeeInfo employeeNumTwo = new EmployeeInfo()
            {
                EmpNum = "1235",
                Name = "Simon Johansson",
                Adress = "Ekarevägen 18",
                City = City.Mumbai,
                State = State.Karnataka,
                DateOfBirth = new DateTime(1969, 12, 31),
                Age = 50,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };
            EmployeeInfo employeeNumThree = new EmployeeInfo()
            {
                EmpNum = "1236",
                Name = "Luna Simonsson",
                Adress = "Kärravägen 12E",
                City = City.Nagpur,
                State = State.Punjab,
                DateOfBirth = new DateTime(1995, 01, 28),
                Age = 25,
                Gender = Gender.Female,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }

            };
            employeeHandler.AddEmployee(employeeNumTwo);
            employeeHandler.AddEmployee(employeeNumThree);

            List<EmployeeInfo> employeesFound = employeeHandler.SearchByName("Simon");


            Assert.AreEqual(3, employeesFound.Count);
        }

        [TestMethod]
        public void SearchByName_NoEmployeeFound()
        {
            List<EmployeeInfo> employeesFound = employeeHandler.SearchByName("Petrus");

            Assert.AreEqual(0, employeesFound.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SearchByName_EmptyStringInput_ThrowsArgumentNullException()
        {
            employeeHandler.SearchByName("");

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SearchByName_NullInput_ThrowsArgumentNullException()
        {
            employeeHandler.SearchByName(null);

            Assert.Fail();
        }

        [TestMethod]
        public void UpdateEmployee_Success()
        {
            EmployeeInfo updateEmployeeExisting = new EmployeeInfo()
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(1988, 04, 16),
                Age = 32,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Sleeping, Hobby.Gardening }
            };

            bool success = employeeHandler.UpdateEmployee(updateEmployeeExisting);

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void UpdateEmployee_EmployeeNotFound()
        {
            EmployeeInfo updateEmployeeNotFound = new EmployeeInfo()
            {
                EmpNum = "1789",
                Name = "Victoria Wahlgren",
                Adress = "Kulls väg 8",
                City = City.Banglore,
                State = State.Punjab,
                DateOfBirth = new DateTime(1987, 09, 20),
                Age = 32,
                Gender = Gender.Female,
                Hobbies = new List<Hobby> { Hobby.Sleeping, Hobby.Shopping }
            };

            bool success = employeeHandler.UpdateEmployee(updateEmployeeNotFound);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void EmployeeNumberExists_DoesExist()
        {


            bool success = employeeHandler.EmployeeNumberExists("1234");

            Assert.IsTrue(success);
        }

        [TestMethod]
        public void EmployeeNumberExists_DoesNotExist()
        {
            bool success = employeeHandler.EmployeeNumberExists("1337");

            Assert.IsFalse(success);
        }

        [TestMethod]
        [DataRow("1234", true)]
        [DataRow("0000", true)]
        [DataRow("9999", true)]
        [DataRow("037x", false)]
        [DataRow("xjuy", false)]
        [DataRow("123", false)]
        [DataRow("12345", false)]
        public void EmployeeNumberIsValid_DifferentDatasets(string empNum, bool expectedSuccess)
        {
            bool success = employeeHandler.EmployeeNumberIsValid(empNum);

            Assert.AreEqual(expectedSuccess, success);
        }

        [TestMethod]
        public void AddManualTestEmployees_AddsEmployees()
        {
            employeeHandler.AddManualTestEmployees();

            bool success = employeeHandler.EmployeeNumberExists("1111");

            Assert.IsTrue(success);
        }

    }
}
