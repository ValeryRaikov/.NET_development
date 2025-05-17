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
                if (_schoolName != null &&  _schoolName.Length > 0 && _schoolName.Length < 100)
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
                if (_grade > 0 && _grade < 13)
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
            return $"Student: {FirstName} {LastName} from school {SchoolName}";
        }
    }
}
