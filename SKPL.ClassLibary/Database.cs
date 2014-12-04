using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            using (var db = new Datebasetable())
            {

            }
        }
    }

    public class Datebasetable : DbContext
    {
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassInstance> ClassInstance { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }
        public DbSet<TeacherClasses> TeacherClasseses { get; set; }
    }

    public class ClassInstance
    {
        public int ClassInstanceId { get; set; }
        public DateTime Date { get; set; }
        public int StudentCount { get; set; }

        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassDuration { get; set; }
        public string Lectures { get; set; } // "2,6,l2,36,6,2"
    }
    public class Lecture
    {
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public int Duration { get; set; }

        public int TeacherId { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int ClassInstanceId { get; set; } //can be null
        public virtual ClassInstance ClassInstance { get; set; }
    }
    public class Teachers
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
    }
    public class TeacherClasses
    {
        public int TeacherClassId { get; set; }
        
        public int ClassInstanceId { get; set; }
        public virtual ClassInstance ClassInstance { get; set; }

        public int LectureId { get; set; }
        public virtual Lecture Lecture { get; set; }
        
        public int TeacherId { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
