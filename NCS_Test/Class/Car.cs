using NSC_Car;
using NSC_Car.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSC_Car
{
    public class Car : IVehicle
    {
        //private IAreaMap location { get; set; }
        public IDriver Driver { get; set; }

        public IAreaMap Location { get; set; }

        /// <summary>
        /// directions
        /// </summary>        
        public char dir { get; set; }
        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="areaWidth"></param>
        /// <param name="areaHeight"></param>
        /// <param name="initialX"></param>
        /// <param name="initialY"></param>
        /// <param name="direction"></param>
        public Car(int areaWidth, int areaHeight, int initialX, int initialY, char direction)
        {
            Location = new AreaMap(areaWidth, areaHeight, initialX, initialY);
            Driver = new Driver(this);

            dir = direction;
        }

        /// <summary>
        /// GetCarLocation
        /// </summary>
        /// <returns></returns>
        public string GetCurrentLocation()
        {
            return $"{Location.GetCarLocation()} {dir}";
        }
    }
}
