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

        public override bool BuyLogic()
        {
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance == lemonTolerance && sugarTolerance <= 10)
            {
                tasteTolerance = true;
            }
            else tasteTolerance = false;
            if (wampumTolerance >= Wallet)
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
    }
}
