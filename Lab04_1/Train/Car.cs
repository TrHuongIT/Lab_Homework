using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Car : IMovable
    {
        private bool started = false;
        public void Start()
        {
            Console.WriteLine("This car Start");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("This car Stop");
            started = false;
        }
        public bool Started
        {
            get { return started; }
            //set { started = value; }
        }
        

        public void Accelerate()
        {
            Console.WriteLine("This car Accelerate");
        }

        public void Break()
        {
            Console.WriteLine("This car Break");
        }

        public void TurnLeft()
        {
            Console.WriteLine("This car TurnLeft");
        }

        public void TurnRight()
        {
            Console.WriteLine("This car TurnRight");
        }

        public void Display()
        {
            Start();
            Stop();
            Accelerate();
            Break();
            TurnLeft();
            TurnRight();
        }
    }
}
