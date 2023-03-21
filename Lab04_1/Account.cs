using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Account
    {
        protected string accName;
        protected string accId;
        protected int balance;

        public Account(int initialize)
        {
            this.balance = initialize;
        }

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        public string AccId
        {
            get { return accId; }
            set { accId = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public virtual int Deposit()
        {
            int money;
            Console.WriteLine("Ban muon gui bao nhieu tien: ");
            money = int.Parse(Console.ReadLine());

            if (money > 0)
            {
                balance += money;
                Console.WriteLine("Ban vua gui vao tai khoan: "+money);
            } else
            {
                Console.WriteLine("So tien khong hop le!");
                balance += 0;
            }

            return money;
        }

        public virtual int WithDraw()
        {
            int money;
            Console.WriteLine("Ban muon rut bao nhieu tien: ");
            money = int.Parse(Console.ReadLine());

            if (money > 0)
            {
                balance -= money;
                Console.WriteLine("Ban vua rut: " + money);
            }
            else
            {
                Console.WriteLine("So tien khong hop le!");
                balance -= 0;
            }

            return money;
        }

        public int GetBalance()
        {
            return balance;
        }
        
    }
}
