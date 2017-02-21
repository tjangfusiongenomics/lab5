using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5application.Models
{
    public class DummyData
    {
        public static List<Student> GetStudent() {
            List<Student> Students = new List<Student>()
            {
                 new Student
                 {
                     FirstName = "Ann",
                     LastName = "Lee",
                     Major = "Medicine",
                     DateOfBirth = Convert.ToDateTime("2004/09/09")
                 },
                  new Student
                  {
                      FirstName = "Bob",
                      LastName = "Doe",
                      Major = "Engineering",
                      DateOfBirth = Convert.ToDateTime("2005/09/09")
                  },
                  new Student
                  {
                      FirstName = "Sue",
                      LastName = "Douglas",
                      Major = "Pharmacy",
                      DateOfBirth = Convert.ToDateTime("2006/01/01")
                  },
                  new Student
                  {
                      FirstName = "Tom",
                      LastName = "Brown",
                      Major = "Business",
                      DateOfBirth = Convert.ToDateTime("2000/09/09")
                  },
                  new Student
                  {
                      FirstName = "Joe",
                      LastName = "Mason",
                      Major = "Health",
                      DateOfBirth = Convert.ToDateTime("2001/01/01")
                  }
            };
            return Students;
        }
    }
}