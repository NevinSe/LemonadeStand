using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Child : Customer
    {
        public Child()
        {
            this.Name = "Child";
            this.Wallet = 5;
        }
    }
}
