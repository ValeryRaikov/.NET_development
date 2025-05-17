namespace LINQ.Models
{
    public class Student : BasePerson
    {
        private string _schoolName = string.Empty;
        private int _grade;

        public string SchoolName
        {
            get => _schoolName;
            set
            {
                if (value != null &&  value.Length > 0 && value.Length < 100)
                {
                    _schoolName = value;
                }
            }
        }

        public int Grade
        {
            get => _grade;
            set
            {
                if (value > 0 && value < 13)
                {
                    _grade = value;
                }
            }
        }

        public Student(string fName, string lName, int age, string pin, string sName, int grade) 
            : base(fName, lName, age, pin)
        {
            SchoolName = sName;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | Student at {SchoolName} (Grade {Grade}) | PIN: {Pin}";
        }
    }
}
