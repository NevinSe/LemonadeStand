using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string Name;
        public double Money;

        public Player()
        {
            this.Name = PromptForName();
            this.Money = 20.00; 
        }
        public virtual string PromptForName()
        {
            return "null";
        }
       
    }
}
