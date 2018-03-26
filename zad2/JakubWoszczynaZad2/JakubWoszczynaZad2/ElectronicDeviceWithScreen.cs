using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWoszczynaZad2
{
    abstract class ElectronicDeviceWithScreen
    {
        protected string ModelNumber { get; set; }
        protected int WeightGrams { get; set; }
        protected int ScreenSizeInches { get; set; }
        protected bool Bluetooth { get; set; }

        public ElectronicDeviceWithScreen() { }

       public ElectronicDeviceWithScreen(int weightGrams, int screenSizeInches, bool bluetooth)
        {
            WeightGrams = weightGrams;
            ScreenSizeInches = screenSizeInches;
            Bluetooth = bluetooth;
        }

        public virtual string ShowInformation()
        {

            return "";
        }

    }
}
