using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBicycle.Models
{
    public class Bycycle : Vehicle 
    {
        public int WheelNum { get; set; }
        public void ShowFullInfo() 
        {
            Console.WriteLine($"{Brand}, {Model}, {Mile}, {WheelNum}");
        }
    }
}
