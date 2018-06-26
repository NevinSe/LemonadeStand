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
            bool tasteTolerance;
            bool purchaseTolerance;
            if (sugarTolerance <= lemonTolerance && sugarTolerance >= 2)
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
