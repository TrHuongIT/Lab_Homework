using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Car : IMovable
    {
        private bool started = false;
        public bool Started
        {
            get { return started; }
        }

        public void Start(object obj)
        {
            Car car = (Car)obj;
            Console.WriteLine("This car Started");
            car.started = true;
        }

        public void Stop(object obj)
        {
            Car car = (Car)obj;
            Console.WriteLine("This car Started");
            car.started = false;
        }

        public void TurnLeft(object obj)
        {
            Console.WriteLine("TurnLeft");
        }

        public void TurnRight(object obj)
        {
            Console.WriteLine("TurnRight");

        }
        public void Accelerate(object obj)
        {
            Console.WriteLine("Accelerate");

        }

        public void Brake(object obj)
        {
            Console.WriteLine("Brake");

        }
    }
}
