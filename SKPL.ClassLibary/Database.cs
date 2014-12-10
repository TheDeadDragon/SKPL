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
        public DbSet<Course> Course { get; set; }
        public DbSet<CourseInstance> CourseInstance { get; set; }
        public DbSet<Lecture> Lecture { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<LectureTeacher> LectureTeachers { get; set; }
    }

    
    public class LectureTeacher
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LectureTeacherId { get; set; }
        public int TeacherId { get; set; }
        [Required]
        public virtual Teacher Teachers { get; set; }

        public int LectureId { get; set; }
        [Required]
        public virtual Lecture Lectures { get; set; }
        
        public virtual LectureCourse LectureCourse { get; set; }
    }

    public class LectureCourse
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LectureCourseId { get; set; }
        public int CourseId { get; set; }
        public int LectureTeacherId { get; set; }
        [Required]
        public virtual Course Course { get; set; }
        [Required]
        public virtual LectureTeacher LectureTeachers { get; set; }
        
        public virtual CourseInstance CourseInstance { get; set; }
    }
    public class CourseInstance
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseInstanceId { get; set; }
        public DateTime Date { get; set; }
        public int StudentCount { get; set; }
        public int CourseId { get; set; }
        [Required]
        public virtual Course Coursees { get; set; }
        public int LectureCourseId { get; set; }
        [Required]
        public virtual LectureCourse LectureCoursees { get; set; }
    }
    //////////////////
    /*Content Tables*/
    //////////////////
    public class Course
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        //public string Lectures { get; set; } // "2,6,12,36,6,2"
        public virtual LectureCourse LectureCourse { get; set; }
    }
    public class Lecture
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LectureId { get; set; }
        public string LectureName { get; set; }
        public int Duration { get; set; }
        public virtual LectureTeacher LectureTeacher { get; set; }
    }
    public class Student
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

    }
    public class Teacher
    {
        [Key]// Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        [Index(IsUnique = true)]
        [StringLength(4)]
        public string TeacherInitials { get; set; }
        public virtual LectureTeacher LectureTeacher { get; set; }
    }
}
