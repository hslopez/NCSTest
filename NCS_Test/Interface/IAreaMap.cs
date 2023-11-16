using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSC_Car.Interface
{
    public interface IAreaMap
    {
        /// <summary>
        /// the area width
        /// </summary>
        int areaWidth { get; set; }

        /// <summary>
        /// the area height
        /// </summary>
        int areaHeight { get; set; }

        /// <summary>
        /// the CarXCoordinate coordinate
        /// </summary>
        int CarXCoordinate { get; set; }

        /// <summary>
        /// the CarYCoordinate coordinate
        /// </summary>
        int CarYCoordinate { get; set; }

        /// <summary>
        /// Getting current position of the car
        /// </summary>
        /// <returns>string</returns>
        string GetCarLocation();

        /// <summary>
        /// SetCarLocation
        /// </summary>
        /// <param name="carLocation"></param>
        void SetCarLocation(char carLocation);
    }
}
