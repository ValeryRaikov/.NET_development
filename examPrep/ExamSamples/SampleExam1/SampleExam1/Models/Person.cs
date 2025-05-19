namespace SampleExam1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public City CityOfBirth { get; set; }
        public Gender PersonGender { get; set; }

        public Person(string name, int age, City city, Gender gender)
        {
            Name = name;
            Age = age;
            CityOfBirth = city;
            PersonGender = gender;
        }
    }
}
