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

        public override bool BuyLogic()
        {
            HeatTolerance();
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance <= lemonTolerance && sugarTolerance >= 2)
            {
                tasteTolerance = true;
            }
            else tasteTolerance = false;
            if (wampumTolerance <= Wallet) 
            {
                purchaseTolerance = true;
            }
            else purchaseTolerance = false;

            if (tasteTolerance && purchaseTolerance)
            {
                return true;
            }
            else return false;
        }
        public override void HeatTolerance()
        {
            if (heatTolerance < 75)
            {
                this.Wallet = 0;
            }
            else if (heatTolerance > 85)
            {
                this.Wallet = 10;
            }
            else
                this.Wallet = 5;
        }
    }
}
