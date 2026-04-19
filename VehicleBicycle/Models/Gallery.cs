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
        public void AddCar(Car car)
        {
            cars.Add(car);
        }
    }
}
