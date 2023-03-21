using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    internal class Product
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price { get; set; }
        public double Quantly { get; set; }


        
        private int discount;
        public int Discount { set { discount = value; } }


        //private double total;
        public double Total { get { return Price * Quantly - discount; } }
    }

}
