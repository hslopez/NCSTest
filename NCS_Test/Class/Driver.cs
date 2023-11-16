using NSC_Car.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSC_Car
{
    internal class Driver : IDriver
    {
        private IVehicle car;
        public Driver(IVehicle car)
        {
            this.car = car;
        }

        public void Drive(string? directions)
        {
            if (directions == null) return;

            foreach (char dir in directions)
            {
                try
                {
                    Execute(dir);
                }
                catch (Exception e)
                {
                    //log the error here.
                    Console.WriteLine(e.ToString());
                    throw;
                }
            }
        }

        /// <summary>
        /// Execute
        /// </summary>
        /// <param name="command"></param>
        private void Execute(char command)
        {
            switch (command)
            {
                case 'L':
                    RotateLeft();
                    break;
                case 'R':
                    RotateRight();
                    break;
                case 'F':
                    MoveForward();
                    break;
                default:
                    throw new ArgumentException("Invalid direction.");
            }
        }
        /// <summary>
        /// RotateLeft
        /// </summary>
        private void RotateLeft()
        {
            switch (car.dir)
            {
                case 'N':
                    car.dir = 'W';
                    break;
                case 'E':
                    car.dir = 'N';
                    break;
                case 'S':
                    car.dir = 'E';
                    break;
                case 'W':
                    car.dir = 'S';
                    break;
            }
        }

        /// <summary>
        /// RotateRight
        /// </summary>
        private void RotateRight()
        {
            switch (car.dir)
            {
                case 'N':
                    car.dir = 'E';
                    break;
                case 'E':
                    car.dir = 'S';
                    break;
                case 'S':
                    car.dir = 'W';
                    break;
                case 'W':
                    car.dir = 'N';
                    break;
            }
        }

        /// <summary>
        /// MoveForward
        /// </summary>
        private void MoveForward()
        {
            car.Location.SetCarLocation(car.dir);
        }

    }
}
