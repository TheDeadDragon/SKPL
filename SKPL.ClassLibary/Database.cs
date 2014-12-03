using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKPL.ClassLibary
{
    class Database : DbContext
    {

    }

    public class ClassInstance
    {
        public int CIId { get; set; }
        Class ClassId { get; set; }

    }
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public int ClassDuration { get; set; }
    }
    public class Lecture
    {
        public int LectureId { get; set; }
        public int TeacherId { get; set; }
        public string LectureName { get; set; }
        public int Duration { get; set; }
    }
    public class Students
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassInstanceId { get; set; } //can be null
        public int LectureId { get; set; } //can be null
    }
    public class Teachers
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public int ClassInstanceId { get; set; }
        public int LectureId { get; set; }
    }
}
