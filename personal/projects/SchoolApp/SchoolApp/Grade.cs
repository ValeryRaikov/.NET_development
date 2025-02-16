using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Grade
    {
        private string subject;
        private double value;

        public string Subject
        {
            get { return subject; }
            protected set { subject = value; }
        }

        public double Value
        {
            get { return value; }
            protected set { this.value = value; }
        }

        public Grade(string subject, double value)
        {
            Subject = subject;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
