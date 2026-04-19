using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBicycle.Models
{
    internal class Car : Vehicle
    {
        public int DoorsNum { get; set; }
        public void ShowFullInfo()
        { 
            Console.WriteLine($"Car: {Brand}, Model: {Model}, Doors: {DoorsNum}");
        }
    }
}
