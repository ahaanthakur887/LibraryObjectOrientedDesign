namespace LibraryOOP
{
    internal class Program
    {
        static void Main()
        {
            // Inheritance example
            Student student = new Student("Ahaan");
            Console.WriteLine(student.GetDetails());
            Professor professor = new Professor("Rufus", "mog");
            Console.WriteLine(professor.GetDetails());

            // Association example
            List<Student> universityStudents = new List<Student>
            {
                new Student("Alice"),
                new Student("Bob")
            };

            List<Professor> universityProfessors = new List<Professor>
            {
                new Professor("Dr. Smith", "Physics"),
                new Professor("Dr. Johnson", "Chemistry")
            };

            University myUniversity = new University(universityStudents, universityProfessors);

            // Aggregation Example
            List<Professor> computerScienceProfessors = new List<Professor>
            {
                new Professor("Dr. Harris", "Computer Science"),
                new Professor ("Dr. Brown", "Computer Science")
            };

            Department computerScienceDepartment = new Department(computerScienceProfessors);

            // Composition Example
            List<Student> programmingCourseStudents = new List<Student>
            {
                new Student("David"),
                new Student("Ilias")
            };

            Course programmingCourse = new Course(programmingCourseStudents);
        }
    }
}