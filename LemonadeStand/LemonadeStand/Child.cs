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
            this.Wallet = 2;
        }

        public override bool BuyLogic(Inventory playerInvetory)
        {
            HeatTolerance(playerInvetory);
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance >= lemonTolerance && sugarTolerance <= 10)
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
            if (heatTolerance < 60)
            {
                this.Wallet = 0;
            }
            else if (heatTolerance > 87 && playerInvetory.icePerPitcher > 1)
            {
                this.Wallet = 3;
            }
            else if (heatTolerance > 95 && playerInvetory.icePerPitcher > 2)
            {
                this.Wallet = 4;
            }
            else
                this.Wallet = 2;
        }
    }
}
