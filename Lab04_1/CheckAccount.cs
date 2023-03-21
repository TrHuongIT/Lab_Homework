using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class CheckAccount : Account
    {
        private int feeTransfer;

        public CheckAccount(int initialize, int feeTransfer) : base(initialize)
        {
            this.feeTransfer = feeTransfer;
        }

        public override int Deposit()
        {            
            base.Deposit();
            balance -= feeTransfer;
            return balance;
        }

        public override int WithDraw()
        {
            base.WithDraw();
            balance -= feeTransfer; 
            return balance;
        }

        public new void GetBalance()
        {
            Console.WriteLine("So tien co trong tai khoan la: " + balance);
        }
    }
}
