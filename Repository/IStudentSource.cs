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
            string[] names = {
                "Shawnta Galindo", 
                "Curt Robichaud",   
                "Dominick Nightingale",   
                "Teresa Mcadoo",   
                "Zona Tolley",   
                "Lacie Mcateer",   
                "Dahlia Commons",   
                "Cherry Deremer",   
                "Randa Joplin",   
                "Wendell Hornung",   
                "Juliet Kirkley",   
                "Emmy Briski",   
                "Talisha Calle",   
                "Laila Windholz",   
                "Florentina Kinoshita",   
                "Alayna Garrick",   
                "Holly Devane",   
                "Amada Istre",   
                "Antonina Banach",   
                "Celsa Romney",   
            };
			for (int i = 0; i < names.Length; i++) 
			{
				Knowledge knowledge = this.GetRandomKnowLedge();
				Student student = new Student(names[i]);
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
        /*
            Lvl 1 - Low
            Lvl 2 - Mid
            Lvl 3 - High
            Lvl 4 - Pro
         */
		protected void GenerateKnowledges()
		{
			for (int i = 1; i <= 4; i++) {
				Knowledge knowledge = new Knowledge(i);
				this.knowledges.Add(knowledge);
			}
		}
    }
}
