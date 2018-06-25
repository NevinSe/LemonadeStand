using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Alien : Customer
    {
        public Alien()
        {
            this.Name = "Alien";
            this.Wallet = 5;
        }
    }
}
