using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class SavingMoney : Account
    {
        private float rate;
        public SavingMoney(int initialize, float rate) : base(initialize)
        {
            this.rate = rate;
        }

        public void GetInterest()
        {
            Console.WriteLine("Tien lai ban nhan duoc la: "+base.balance*rate);
        }




    }
}
