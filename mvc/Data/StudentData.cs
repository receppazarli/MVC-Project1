using mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc.Data
{
    public class StudentData
    {
        public static List<Student> Students = new List<Student>() {

            new Student
            {
                Id = 1,
                Name = "Mehmet",
                Surname = "Yilmaz",
                DepartmentName = "Hukuk",
                IdentityNumber = "11111111111",
                EntryYear = 2010
            },

            new Student
            {
                Id = 2,
                Name = "Ali",
                Surname = "Yilmaz",
                DepartmentName = "Tip",
                IdentityNumber = "22222222222",
                EntryYear = 2014
            }

        };

    }
}