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
                if (_universityName != null && _universityName.Length > 0 && _universityName.Length < 100)
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
                if (_specialtyName != null && _specialtyName.Length > 0 && _specialtyName.Length < 100)
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
                if (_facultyNumber.Length == 9)
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
                if (_year > 0 && _year < 7)
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
            return $"University Student: {FirstName} {LastName} from Univeristy: {UniversityName} with specialization of {SpecialtyName}";
        }
    }
}
