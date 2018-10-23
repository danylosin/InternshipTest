using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
	public class Internship
	{
		public string name;
		public List<University> universities;
		public List<Student> students;

		public Internship(string name)
		{
			this.name = name;
			this.universities = new List<University>();
			this.students = new List<Student>();
		}

		public string GetStudents()
		{
			string str = "";
			foreach (Student student in this.students) 
			{
				str += student.name + "\n";               
			}
			return str;
		}

		public void AddUniversity(University university)
		{
			this.universities.Add(university);
		}

		public void SetStudents()
		{
			foreach (University university in this.universities)
			{
				foreach (Student student in university.students)
				{
					if (student.GetKnowledge().level > 2)
					{
						this.students.Add(student);
					}
				}
			}
		}
	}
}
