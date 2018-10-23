using System.Collections.Generic;
using InternshipTest.Person;
using System;

namespace InternshipTest.Repository
{
    public class IStudentSource
    {
        protected List<Knowledge> knowledges;
        
        public IStudentSource()
        {
            this.knowledges = new List<Knowledge>();
            this.GenerateKnowledges();
        }
        public virtual List <Student> load()
        {
            List<Student> students = new List<Student>();
			for (int i = 0; i < 30; i++) 
			{
				Knowledge knowledge = this.GetRandomKnowLedge();
				Student student = new Student("Student with knowledge = " + knowledge.getLevel());
				student.SetKnowledge(knowledge);
				students.Add(student);
			}

			return students;
        }  

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
    }
}
