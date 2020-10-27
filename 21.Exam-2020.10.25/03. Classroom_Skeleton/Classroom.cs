using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {

        private List<Student> students;

        public Classroom(int capacity)
        {
            Capacity = capacity;
            this.students = new List<Student>();
        }
        public int Capacity { get; set; }

        public int Count =>
            this.students.Count;

        public string RegisterStudent(Student student)
        {
            if(students.Count< this.Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}";
            }
            else
            {
                return $"No seats in the classroom";
            }
        }

        public string DismissStudent(string firstName, string lastName)
        {
            bool  exist = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
            if (exist)
            {
                students = students.Where(x => x.FirstName != firstName && x.LastName != lastName).ToList();
                return $"Dismissed student {firstName} {lastName}";
            }
            else
            {
                return "Student not found";
            }
        }

        public string GetSubjectInfo(string subject)
        {
            bool exist = students.Any(x => x.Subject== subject);
            if (exist)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Subject: {subject}");
                sb.AppendLine("Students:");
                foreach (var item in students.Where(x => x.Subject == subject))
                {
                    sb.AppendLine($"{item.FirstName} {item.LastName}");
                }

                return sb.ToString().Trim();
            }
            else
            {
                return "No students enrolled for the subject";
            }
        }

        public int GetStudentsCount()
        {
            return students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            bool exist = students.Any(x => x.FirstName == firstName && x.LastName == lastName);
            if (exist)
            {
                var getStudent = students.Where(x => x.FirstName == firstName && x.LastName == lastName).First();

                return getStudent;
            }
            else
            {
                return null;
            }
        }
    }
}
