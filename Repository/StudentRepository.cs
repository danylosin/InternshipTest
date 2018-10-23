using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Repository
{
    public class StudentRepository 
    {
        private IStudentSource source;

        public StudentRepository(IStudentSource source)
        {
            this.source = source;
        }

		public List <Student> getStudents()
        {
            return this.source.load();
        }
    }
}
