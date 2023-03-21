using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    public interface IMovable : IDrivable, ISteerable
    {

        void Accelerate();
        void Break();
    }
}
