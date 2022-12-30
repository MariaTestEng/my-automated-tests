using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;

namespace MyTests
{
    internal class UniversityTests
    {
        [Test]
        public void CheckCreateStudent()
        {
            //arrange
            var student = new Student(3, "Franek");
            //assert
            Assert.IsInstanceOf<Student>(student);
            Assert.IsTrue(student.Id== 3&&student.Name=="Franek");
        }

        [Test]
        public void CheckCreateDepartment()
        {
            //Arrange
            var student1 = new Student(2, "Ala");
            var student2 = new Student(3, "Olek");
            var students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            var department = new Department(5, "polonistyka", students);
            //Assert
            Assert.IsInstanceOf<Department>(department);
            Assert.IsTrue(department.Id == 5 && department.Name == "polonistyka" && department.Students.Any(s => s.Id == 2 && s.Name == "Ala") && department.Students.Any(s => s.Id == 3 && s.Name == "Olek"));
        }

        [Test]
        public void CheckCreateUniversity()
        {
            var student1 = new Student(2, "Andrzej");
            var student2 = new Student(3, "Halina");
            var students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            var department1 = new Department(2, "informatyka", students);
            var department2 = new Department(3, "matematyka", students);
            var departments= new List<Department>();
            departments.Add(department1);
            departments.Add(department2);
            var university = new University(6, "politechnika gdanska", departments);
            //Assert
            Assert.IsInstanceOf<University>(university);
            Assert.IsTrue(university.Id == 6 && university.Name == "politechnika gdanska" && university.Departments.Any(d => d.Name == "informatyka" && d.Id == 2 && d.Students.Any(s => s.Id == 2 && s.Name == "Andrzej") && d.Students.Any(s => s.Id == 3 && s.Name == "Halina")) && university.Departments.Any(d => d.Name == "matematyka" && d.Id == 3 && d.Students.Any(s => s.Name == "Andrzej" && s.Id == 2) && d.Students.Any(s => s.Name == "Halina" && s.Id == 3)));
        }

    }
}
