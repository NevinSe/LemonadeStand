using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        public string Name;
        public int Wallet;
        public double wampumTolerance;
        public int lemonTolerance;
        public int sugarTolerance;
        public int iceTolerance;
        public int heatTolerance;

        public Customer()
        {
            this.Name = NameOfCustomer();
            this.Wallet = SizeOfWallet();
        }

        public virtual string NameOfCustomer()
        {
            return "null";
        }
        public virtual int SizeOfWallet()
        {
            return 5;
        }

        public virtual bool BuyLogic(Inventory playerInvetory)
        {
            return false;
        }

        public virtual void HeatTolerance(Inventory playerInvetory)
        {

        }
    }
}
