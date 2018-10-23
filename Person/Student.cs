namespace InternshipTest.Person
{
    public class Student
    {
		public Knowledge knowledge;
		public string name;

        public Student(string name)
        {
			this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
			this.knowledge = knowledge;
        }
    }
}