using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System.Collections.Generic;
using System.Threading;

namespace EmployeeLibraryTest
{
    [TestClass]
    public class EmployeeInfoTest
    {
        [TestMethod]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(59, true)]
        [DataRow(60, true)]
        [DataRow(61, false)]
        [DataRow(17, false)]
        public void CreateNewEmployeeInfo_DifferentAges(int age, bool expectedSuccess)
        {
            bool success = true;
            try
            {
                EmployeeInfo employeeInfo = new EmployeeInfo
                {
                    EmpNum = "1234",
                    Name = "Simon Westman",
                    Adress = "Kulls väg 8",
                    City = City.Nagpur,
                    State = State.MP,
                    DateOfBirth = new DateTime(2000, 08, 10),
                    Age = age,
                    Gender = Gender.Male,
                    Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
                };
            }
            catch (ArgumentOutOfRangeException)
            {
                success = false;
            }
            catch(Exception)
            {
                Assert.Fail();
            }

            Assert.AreEqual(expectedSuccess, success);
        }

        
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void CreateNewEmployeeInfo_IncorrectEmployeeNumberTooShort()
        {
            EmployeeInfo incorrectEmpNumberTooShort = new EmployeeInfo
            {
                EmpNum = "124",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void CreateNewEmployeeInfo_IncorrectEmployeeNumberToLong()
        {
            EmployeeInfo incorrectEmpNumberTooLong = new EmployeeInfo
            {
                EmpNum = "12455",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };
            Thread.Sleep(100000);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void CreateNewEmployeeInfo_IncorrectEmployeeNumberContainsLetters()
        {
            EmployeeInfo incorrectEmpNumberTooLong = new EmployeeInfo
            {
                EmpNum = "I2E4",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateNewEmployeeInfo_EmptyName()
        {
            EmployeeInfo employeeInfoEmptyName = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CreateNewEmployeeInfo_EmptyAdress()
        {
            EmployeeInfo employeeInfoEmptyAdress = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 19,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.Fail();
        }

        [TestMethod]
        public void EmployeeInfoToString_ReturnsCorrectString()
        {
            string expectedResult = "1234 : Simon Westman";
            EmployeeInfo employeeInfo = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 18,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.AreEqual(expectedResult, employeeInfo.ToString());
        }

        [TestMethod]
        public void EmployeeInfoToLongString_ReturnsCorrectString()
        {
            string expectedResult = "EmpNo: 1234"+"\r\nName: Simon Westman"
                                  + "\r\nAdress: Kulls väg 8"
                                  + "\r\nCity: Nagpur"
                                  + "\r\nState: MP"
                                  + "\r\nDOB: 2000-08-10"
                                  + "\r\nAge: 18"
                                  + "\r\nGender: Male"
                                  + "\r\nHobbies: Swimming"
                                  + "\r\n\tPainting"
                                  + "\r\n\t";
            EmployeeInfo employeeInfo = new EmployeeInfo
            {
                EmpNum = "1234",
                Name = "Simon Westman",
                Adress = "Kulls väg 8",
                City = City.Nagpur,
                State = State.MP,
                DateOfBirth = new DateTime(2000, 08, 10),
                Age = 18,
                Gender = Gender.Male,
                Hobbies = new List<Hobby> { Hobby.Swimming, Hobby.Painting }
            };

            Assert.AreEqual(expectedResult, employeeInfo.ToLongString());
        }
    }
}
