using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;

namespace InternshipTest
{
    class Program
    {
		protected List<Knowledge> knowledges = new List<Knowledge>();
		
		protected Knowledge GetRandomKnowLedge()
		{
			Random rnd = new Random();
			int index = rnd.Next(0, 4);
			return this.knowledges[index];
		}

		protected void GenerateKnowledges()
		{
			for (int i = 1; i <= 4; i++) {
				Knowledge knowledge = new Knowledge(i);
				this.knowledges.Add(knowledge);
			}
		}

		protected List<Student> GenerateStudents()
		{
			List<Student> students = new List<Student>();
			for (int i = 0; i < 30; i++) 
			{
				Knowledge knowledge = this.GetRandomKnowLedge();
				Student student = new Student("Student with knowledge = " + knowledge.level);
				student.SetKnowledge(knowledge);
				students.Add(student);
			}

			return students;
		}

        static void Main(string[] args)
        {
			Program program = new Program();
			program.GenerateKnowledges();
			List <Student> students = program.GenerateStudents();
			University university = new University("CH.U.I.");
			university.SetStudents(students);
          
            Internship internship = new Internship("Interlink");
			internship.AddUniversity(university);
			internship.SetStudents();
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
    }
}
