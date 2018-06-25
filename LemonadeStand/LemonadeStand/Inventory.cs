using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory : Player
    {
        public int Amount;


        public void DisplayInventory(Player playerOne)
        {
            foreach (Inventory I in playerOne.playerInventory)
            {
                Console.WriteLine(I.Name + ": " + I.Amount);
            }
        }
    }
}
