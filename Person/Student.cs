namespace InternshipTest.Person
{
    public class Student
    {
		protected Knowledge knowledge;
		public string name;

        public Student(string name)
        {
			this.name = name;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
			this.knowledge = knowledge;
        }

		public Knowledge GetKnowledge()
		{
			return this.knowledge;
		}
    }
}