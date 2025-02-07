using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStoreApp
{
    interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }

        void DisplayInfo();
        string ToString();
    }
}
