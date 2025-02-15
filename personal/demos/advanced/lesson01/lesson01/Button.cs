using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson01
{
    delegate void ButtonClick(Button button);

    class Button
    {
        private ButtonClick Click;

        public event ButtonClick _click
        {
            add { Click += value; }
            remove { Click -= value; }
        }

        public void SimulateClick()
        {
            if (Click != null)
                Click(this);
        }

        public void AppendToClick(ButtonClick click)
        {
            Click += click;
        }

        public void RemoveFromClick(ButtonClick click)
        {
            Click -= click;
        }
    }
}
