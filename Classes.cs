namespace LibraryOOP
{
    public class UniversityAttendee
    {
        public string LivingStatus { get; set; }
        public bool FullTimeEmployment { get; set; }

        public UniversityAttendee(string livingStatus, bool fullTimeEmployment)
        {
            LivingStatus = livingStatus;
            FullTimeEmployment = fullTimeEmployment;
        }

        public virtual string GetDetails()
        {
            return $"Living Status is {LivingStatus} and state of current full time employment : {FullTimeEmployment}";
        }
    }

    public class Student : UniversityAttendee
    {
        public string Name { get; set; }

        public Student(string name) : base("on-campus", false)
        {
            Name = name;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + "\n" + $"Name is {Name}";
        }
    }

    public class Professor : UniversityAttendee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Professor(string name, string department) : base("off-campus", true)
        {
            Name = name;
            Department = department;
        }

        public override string GetDetails()
        {
            return base.GetDetails() + "\n" + $"Name is {Name} and Department is {Department}";
        }
    }
    
    public class University
    {
        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }

        public University(List<Student> students, List<Professor> professors)
        {
            Students = students;
            Professors = professors;
        }
    }

    public class Department
    {
        public List<Professor> Professors { get; set; }

        public Department(List<Professor> professors)
        {
            Professors = professors;
        }
    }

    public class Course
    {
        public List<Student> Students { get; set; }

        public Course(List<Student> students)
        {
            Students = students;
        }
    }
}