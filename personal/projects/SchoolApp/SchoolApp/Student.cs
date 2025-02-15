using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Student : Person
    {
        private Hashtable noteBook;
        private int absenceCount;

        public Hashtable NoteBook
        {
            get { return noteBook; }
            protected set { noteBook = value; }
        }

        public int AbsenceCount
        {
            get { return absenceCount; }
            protected set { absenceCount = value; }
        }

        public Student(string name, int age, char gender, List<string> subjects) : base(name, age, gender)
        {
            InitializeSubjects(subjects);
            this.AbsenceCount = 0;
        }

        private void InitializeSubjects(List<string> subjects)
        {
            this.NoteBook = new Hashtable();
            foreach (string subject in subjects)
            {
                NoteBook.Add(subject, new List<Grade>());
            }
        }

        public override string ToString()
        {
            return $"Student: {Name}";
        }
    }
}
