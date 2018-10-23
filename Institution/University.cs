using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
		public string name;
		public List<Student> students;
        public University(string name)
        {
			this.name = name;
			this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
			this.students.Add(student);
        }

        public void SetStudents(List<Student> students)
        {
            this.students = students;
        }  
    }
}
