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
            //Test to set data to lists for later adding it to table
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
                new Lecture{LectureName = "Cisco CCNA Exploration 1", Duration = 5},
                new Lecture{LectureName = "Cisco CCNA Exploration 2", Duration = 5},
                new Lecture{LectureName = "Cisco CCNA Exploration 3", Duration = 7},
                new Lecture{LectureName = "Cisco CCNA Exploration 4", Duration = 10}
            };
            
            
            var course = new List<Course>
            {
                new Course{CourseName = "Cisco", CourseDuration = 14}
            };

            var lectureTeacher = new List<LectureTeacher>
            {
                new LectureTeacher{TeacherId = 2, LectureId = 1}
            };

            var lectureCourse = new List<LectureCourse>
            {
                new LectureCourse{CourseId = 1, LectureTeacherId = 1}
            };

            var courseInstance = new List<CourseInstance>
            {
                new CourseInstance{StudentCount = 15, CourseId = 1, LectureCourseId = 1}
            };

            //Test to add data to database tables
            students.ForEach(s => context.Students.Add(s));
            teachers.ForEach(t => context.Teachers.Add(t));
            lectures.ForEach(l => context.Lecture.Add(l));
            lectureTeacher.ForEach(lt => context.LectureTeachers.Add(lt));
            lectureCourse.ForEach(lc => context.LectureCourses.Add(lc));
            course.ForEach(c => context.Course.Add(c));
            courseInstance.ForEach(ci => context.CourseInstance.Add(ci));

            //Saves to database
            context.SaveChanges();
        }
    }
}
