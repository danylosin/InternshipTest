using System;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;
using System.Collections.Generic;
using InternshipTest.Repository;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
			StudentRepository repository = new StudentRepository(new IStudentSource());
		
			List <Student> students = repository.getStudents();
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
