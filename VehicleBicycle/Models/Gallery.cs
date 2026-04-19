using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleBicycle.Models
{
    internal class Gallery
    {
        List <Car> cars = new List<Car>();
        List <Bycycle> bi = new List<Bycycle>();
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
        public void AddBycycle(Bycycle bycycle) 
        {
            bi.Add(bycycle);
        }
    }
}
