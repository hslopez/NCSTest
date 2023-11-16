using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSC_Car.Interface;

namespace NSC_Car
{
    public class AreaMap : IAreaMap
    {
        public AreaMap(int areaWidth, int areaHeight, int x, int y)
        {
            this.areaWidth = areaWidth;
            this.areaHeight = areaHeight;
            CarXCoordinate = x;
            CarYCoordinate = y;
        }

        /// <summary>
        /// areaWidth
        /// </summary>
        public int areaWidth { get; set; }

        /// <summary>
        /// areaHeight
        /// </summary>
        public int areaHeight { get; set; }

        /// <summary>
        /// CarXCoordinate coordinate
        /// </summary>
        public int CarXCoordinate { get; set; }

        /// <summary>
        /// CarYCoordinate coordinate
        /// </summary>
        public int CarYCoordinate { get; set; }

        public string GetCarLocation()
        {
            return $"{CarXCoordinate} {CarYCoordinate}";
        }

        public void SetCarLocation(char dir)
        {
            switch (dir)
            {
                case 'N':
                    if (CarYCoordinate < areaHeight - 1)
                        CarYCoordinate++;
                    else throw new ArgumentException("Area upper limit reached");
                    break;
                case 'E':
                    if (CarXCoordinate < areaWidth - 1)
                        CarXCoordinate++;
                    else throw new ArgumentException("Area right limit reached");
                    break;
                case 'S':
                    if (CarYCoordinate > 0)
                        CarYCoordinate--;
                    else throw new ArgumentException("Area lower limit reached");
                    break;
                case 'W':
                    if (CarXCoordinate > 0)
                        CarXCoordinate--;
                    else throw new ArgumentException("Area left limit reached");
                    break;
            }
        }
    }
}
