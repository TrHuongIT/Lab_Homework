using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    interface IMovable:IDrivable, ISteerable
    {
        void Accelerate(Object obj);
        void Brake(Object obj);
    }
}
