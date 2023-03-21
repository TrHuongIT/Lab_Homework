using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class StoreItem
    {
        public int ItemNo { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

namespace Supply
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}

namespace Business
{
    public class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; }
    }

    namespace DealerShip
    {
        public class Car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; }
        }
    }
}
