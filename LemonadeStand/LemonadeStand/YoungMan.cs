using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class YoungMan : Customer
    {
        public YoungMan()
        {
            this.Name = "Young Man";
            this.Wallet = 3;
        }

        public override bool BuyLogic(Inventory playerInvetory)
        {
            HeatTolerance(playerInvetory);
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance == lemonTolerance && sugarTolerance <= 10)
            {
                tasteTolerance = true;
            }
            else
            {
                Console.WriteLine("-------------------{0} says: Tastes Gross!", this.Name);
                tasteTolerance = false;
            }
            if (wampumTolerance <= Wallet)
            {
                purchaseTolerance = true;
            }
            else
            {
                Console.WriteLine("-------------------{0} says: Too Expensive!", this.Name);
                purchaseTolerance = false;
            }
            if (tasteTolerance && purchaseTolerance)
            {
                return true;
            }
            else return false;
        }
        public override void HeatTolerance(Inventory playerInvetory)
        {
            if (heatTolerance < 70 && playerInvetory.icePerPitcher <= 1)
            {
                Wallet = 1;
            }
            else if (heatTolerance > 90 && playerInvetory.icePerPitcher >= 2)
            {
                Wallet = 6;
            }
            else if (heatTolerance > 95 && playerInvetory.icePerPitcher >= 4)
            {
                this.Wallet = 6;
            }
            else
                Wallet = 3;
        }
    }
}
