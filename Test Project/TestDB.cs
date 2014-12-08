using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SKPL.ClassLibary;

namespace Test_Project
{
    [TestClass]
    public class TestDB
    {
        Databasetable context = new Databasetable();

        [TestMethod]
        public void TestAddTable()
        {
            var students = new List<Student>
            {
                new Student{StudentName = "Svend"},
                new Student{StudentName = "Ivan"},
                new Student{StudentName = "Michael"},
                new Student{StudentName = "Daniel"}
            };

            var teachers = new List<Teacher>
            {
                new Teacher{TeacherName = "Paul Saunders", TeacherInitials = "PS"},
                new Teacher{TeacherName = "Henrik Thomsen", TeacherInitials = "HT"}
            };

            var lectures = new List<Lecture>
            {
                new Lecture{LectureName = "Cisco CCNA Exploration 1", Duration = 5, TeacherId = 4},
                new Lecture{LectureName = "Cisco CCNA Exploration 2", Duration = 5, TeacherId = 4},
                new Lecture{LectureName = "Cisco CCNA Exploration 3", Duration = 7, TeacherId = 4},
                new Lecture{LectureName = "Cisco CCNA Exploration 4", Duration = 10, TeacherId = 4}
            };

            var classInstance = new List<ClassInstance>
            {

            };

            var classes =new List<Class>
            {
                
            };

            classes.ForEach(c => context.Class.Add(c));
            classInstance.ForEach(ci => context.ClassInstance.Add(ci));
            lectures.ForEach(l => context.Lecture.Add(l));
            students.ForEach(s => context.Students.Add(s));
            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();
        }
    }
}
