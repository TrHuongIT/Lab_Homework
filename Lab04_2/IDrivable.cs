using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    interface IDrivable
    {
        void Start(Object obj);
        void Stop(Object obj);

        bool Started { get; }
    }
}
