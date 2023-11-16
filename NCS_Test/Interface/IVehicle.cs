using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSC_Car.Interface
{
    public interface IVehicle
    {
        /// <summary>
        /// the direction
        /// </summary>
        char dir { get; set; }       
        

        /// <summary>
        /// Getting current position of the car
        /// </summary>
        /// <returns>string</returns>
        string GetCurrentLocation();

        /// <summary>
        /// Execute the given commands method
        /// </summary>
        /// <param name="drection"></param>
        IDriver Driver { get; set; }

        /// <summary>
        /// AreaMap
        /// </summary>
        public IAreaMap Location { get; set; }
    }
}
