namespace LINQ.Models
{
    public abstract class BasePerson
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _age;
        private string _pin = string.Empty;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (value != null && value.Length > 2 && value.Length < 50)
                {
                    _firstName = value;
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (value != null && value.Length > 2 && value.Length < 50)
                {
                    _lastName = value;
                }
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value < 110)
                {
                    _age = value;
                }
            }
        }

        public string Pin
        {
            get => _pin;
            set
            {
                if (value.Length == 10)
                {
                    _pin = value;
                }
            }
        }

        public BasePerson(string fName, string lName, int age, string pin)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Pin = pin;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (BasePerson)obj;

            return Pin == other.Pin;
        }

        public override int GetHashCode()
        {
            return Pin.GetHashCode();
        }

        public override string ToString()
        {
            return $"Person: {FirstName} {LastName}";
        }
    }
}
