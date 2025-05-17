namespace LINQ.Models
{
    public class UniversityStudent : BasePerson
    {
        private string _universityName = string.Empty;
        private string _specialtyName = string.Empty;
        private string _facultyNumber = string.Empty;
        private int _year;

        public string UniversityName
        {
            get => _universityName;
            set
            {
                if (value != null && value.Length > 0 && value.Length < 100)
                {
                    _universityName = value;
                }
            }
        }

        public string SpecialtyName
        {
            get => _specialtyName;
            set
            {
                if (value != null && value.Length > 0 && value.Length < 100)
                {
                    _specialtyName = value;
                }
            }
        }

        public string FacultyNumber
        {
            get => _facultyNumber;
            set
            {
                if (value.Length == 9)
                {
                    _facultyNumber = value;
                }
            }
        }

        public int Year
        {
            get => _year;
            set
            {
                if (value > 0 && value < 7)
                {
                    _year = value;
                } 
            }
        }

        public UniversityStudent(string fName, string lName, int age, string pin, string uName, string sName, string fNumber, int year) 
            : base(fName, lName, age, pin)
        {
            UniversityName = uName;
            SpecialtyName = sName;
            FacultyNumber = fNumber;
            Year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | University: {UniversityName} (Year {Year}) | Faculty #: {FacultyNumber}";
        }
    }
}
