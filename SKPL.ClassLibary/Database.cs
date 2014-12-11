using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Principal;

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
    //Makes the different tables in the database out of the models made
    public class Databasetable : DbContext 
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInstance> CourseInstances { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<LectureTeacher> LectureTeachers { get; set; }
        public DbSet<LectureCourse> LectureCourses { get; set; }

    }

    //we are missing a table that link student's to courseinstanses
    public class LectureTeacher
    {
        [Key] //Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)] //Makes the next value a Identity(auto incrementing value)
        public int LectureTeacherId { get; set; } //Primary ID
        public int TeacherId { get; set; } //Foreign key to the Teacher Table
        [Required]//makes the next line Required (is used to makes relations work, so they dont make errors)
        public virtual Teacher Teachers { get; set; }//reference to Teacher Table
        public int LectureId { get; set; } //Foreign key to the Lecture Table
        [Required]//makes the next line Required (is used to makes relations work, so they dont make errors)
        public virtual Lecture Lectures { get; set; } //Reference to Lecture Table
        
        //this is a reference to lecturecourse table and this don't need a Required tag,
        //because this table dont use anything from the LectureCourse table,
        //but LectureCourse use something from this
        public virtual LectureCourse LectureCourse { get; set; }
    }

    public class LectureCourse
    {
        [Key]//Primary Key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LectureCourseId { get; set; }//ID
        public int CourseId { get; set; }//FK KEY
        public int LectureTeacherId { get; set; } //FK KEY
        [Required]
        public virtual Course Course { get; set; }//Reference to Course table
        [Required]
        public virtual LectureTeacher LectureTeachers { get; set; }//Reference to LectureTeacher Table
        
        public virtual CourseInstance CourseInstance { get; set; } // Reference to CourceInstance
    }
    public class CourseInstance
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseInstanceId { get; set; } //id
        //public DateTime Date { get; set; } //need for start date but didn't have time to implement it proberly
        public int StudentCount { get; set; }//amount of students (gotten from a table we didn't make yet)
        public int CourseId { get; set; }//FK KEY
        [Required]
        public virtual Course Coursees { get; set; } //Reference to Courses
        public int LectureCourseId { get; set; }//FK KEY
        [Required]
        public virtual LectureCourse LectureCoursees { get; set; } //Reference to LectureCourses
    }
    //////////////////
    /*Content Tables*/
    //////////////////
    public class Course
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; } //ID
        public string CourseName { get; set; } //Name of the course
        public int CourseDuration { get; set; }//duration of the course (later would be a combination of all the Lecture's durations)
        public virtual LectureCourse LectureCourse { get; set; } //Reference to LectureCourse
    }
    public class Lecture
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int LectureId { get; set; }//ID
        public string LectureName { get; set; }//Name of LectureName
        public int Duration { get; set; }//Duration
        public virtual LectureTeacher LectureTeacher { get; set; }//Reference to LectureTeacher...... you get the point by now
    }
    public class Student
    {
        [Key] // Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; } //ID
        public string StudentName { get; set; } //Student name

    }
    public class Teacher
    {
        [Key]// Primary key
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }//ID
        public string TeacherName { get; set; } //TeacherName
        [Index(IsUnique = true)]
        [StringLength(4)]
        public string TeacherInitials { get; set; }//unique and was gonna be auto generated on creation
        public virtual LectureTeacher LectureTeacher { get; set; }//Reference to LectureTeacher
    }
}
