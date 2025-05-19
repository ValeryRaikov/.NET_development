using SampleExam1.Models;
using System.Text.RegularExpressions;

namespace SampleExam1.Utils
{
    public static class Validator
    {
        public static bool IsValid(Person person)
        {
            string regex = "^[\\p{L} .'-]+$";

            if (person.Name == null || !Regex.Match(person.Name, regex).Success) 
                return false;

            if (person.Age == null || person.Age < 0 || person.Age > 130) 
                return false; 

            if(person.CityOfBirth == null) 
                return false; 
            
            if (person.PersonGender == null)
                return false; 
            
            return true;
        }
    }
}
