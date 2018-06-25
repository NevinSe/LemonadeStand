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
        public List<Inventory> playerInventory;

        public Player()
        {
            this.Name = PromptForName();
            this.Money = 20.00;
            this.playerInventory = BuildInventory();
           
        }
        public List<Inventory> BuildInventory()
        {
            playerInventory = new List<Inventory>
            {
                new Inventory() {Name = "Lemons", Amount = 0},
                new Inventory() {Name = "Sugar", Amount = 0},
                new Inventory() {Name = "Ice", Amount = 0},
                new Inventory() {Name = "Cups", Amount = 0}
            };
            return playerInventory;
        }
        public virtual string PromptForName()
        {
            return "null";
        }
       
    }
}
