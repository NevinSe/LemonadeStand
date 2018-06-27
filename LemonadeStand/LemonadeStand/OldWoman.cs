using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class OldWoman : Customer
    {
        public OldWoman()
        {
            this.Name = "Old Woman";
            this.Wallet = 5;
        }

        public override bool BuyLogic(Inventory playerInvetory)
        {
            HeatTolerance(playerInvetory);
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance <= lemonTolerance && sugarTolerance >= 2)
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
            if (heatTolerance < 75)
            {
                this.Wallet = 0;
            }
            else if (heatTolerance > 85 && playerInvetory.icePerPitcher >= 2)
            {
                this.Wallet = 7;
            }
            else if (heatTolerance > 95 && playerInvetory.icePerPitcher >= 4)
            {
                this.Wallet = 10;
            }
            else
                this.Wallet = 5;
        }
    }
}
