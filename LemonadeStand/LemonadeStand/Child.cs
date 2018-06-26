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

        public override bool BuyLogic()
        {
            HeatTolerance();
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance > lemonTolerance && sugarTolerance <= 10)
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
            if (heatTolerance < 60)
            {
                this.Wallet = 0;
            }
            else if (heatTolerance > 87)
            {
                this.Wallet = 3;
            }
            else
                this.Wallet = 2;
        }
    }
}
