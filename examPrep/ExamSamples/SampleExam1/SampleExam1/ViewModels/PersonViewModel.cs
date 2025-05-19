using SampleExam1.Models;
using SampleExam1.Utils;
using System.ComponentModel;
using System.Windows.Input;

namespace SampleExam1.ViewModels
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _newPerson;
        
        public Person NewPerson
        {
            get => _newPerson;
            set
            {
                _newPerson = value;
                OnPropertyChanged(nameof(NewPerson));
            }
        }

        public ICommand SubmitCommand { get; set; }

        public PersonViewModel()
        {
            NewPerson = new Person(NewPerson.Name, NewPerson.Age, City.Sofia, Gender.Male);
            SubmitCommand = new Command(SubmitPerson);
        }

        private void SubmitPerson(object obj)
        {
            if (Validator.IsValid(NewPerson))
            {
                // SaveToDB(); -> need implementation
                NewPerson = new Person(NewPerson.Name, NewPerson.Age, City.Sofia, Gender.Male);
            }
        }

        // private void SaveToDB()
        // {
        //     using (var ctx = new PersonContext())
        //     {
        //         ctx.People.Add(NewPerson);
        //         ctx.SaveChanges();
        //     }
        // }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
