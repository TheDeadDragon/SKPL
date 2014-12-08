using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKPL.ClassLibary
{
    public class Database
    {
        public static void Create()
        {
            using (var db = new Databasetable())
            {

            }
        }
    }

    public class Databasetable : DbContext
    {
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassInstance> ClassInstance { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherClass> TeacherClasseses { get; set; }
    }

    public class ClassInstance
    {
        [Key] // Primary key
        public int ClassInstanceId { get; set; }
        public DateTime Date { get; set; }
        public int StudentCount { get; set; }
        
        //[ForeignKey("Class")]
        //public int ClassId { get; set; }
        //public virtual Class Class { get; set; }
    }
    public class Class
    {
        [Key] // Primary key
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassDuration { get; set; }

        ////[ForeignKey("Lecture")]
        //public string Lectures { get; set; } // "2,6,12,36,6,2"
    }
    public class Lecture
    {
        [Key] // Primary key
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public int Duration { get; set; }

        public int TeacherId { get; set; }
        public virtual Teacher Teachers { get; set; }
    }
    public class Student
    {
        [Key] // Primary key
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        //[ForeignKey("ClassInstance")]
        //public int ClassInstanceId { get; set; }
        //public virtual ClassInstance ClassInstance { get; set; }
    }
    public class Teacher
    {
        [Key] // Primary key
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherInitials { get; set; }
    }
    public class TeacherClass
    {
        [Key] // Primary key
        public int TeacherClassId { get; set; }

        //[ForeignKey("ClassInstance")]
        //public int ClassInstanceId { get; set; }
        //public virtual ClassInstance ClassInstance { get; set; }

        //[ForeignKey("Lecture")]
        //public int LectureId { get; set; }
        //public virtual Lecture Lecture { get; set; }

        //[ForeignKey("Teacher")]
        //public int TeacherId { get; set; }
        //public virtual Teacher Teachers { get; set; }
    }
}
