using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public double Wampum;
        public int Lemons;
        public int Sugar;
        public int Ice;
        public int Cups;
        public int Pitcher;
        private int cupsPerPitcher = 6;
        public int lemonsPerPitcher = 4;
        public int sugarPerPitcher = 4;
        public int icePerPitcher = 4;

        public Inventory()
        {
            this.Lemons = 0;
            this.Sugar = 0;
            this.Ice = 0;
            this.Cups = 0;
        }

        public void DisplayInventory(Human player)
        {
            Console.WriteLine("Your total money: $"+player.Money+"\r\n");
            Console.WriteLine("The amount of Lemons you have is: "+Lemons);
            Console.WriteLine("The amount of Sugar you have is: " + Sugar);
            Console.WriteLine("The amount of Ice you have is: " + Ice);
            Console.WriteLine("The amount of Cups you have is: " + Cups);
        }

        public void FillAPitcher()
        {
                Lemons -= lemonsPerPitcher;
                Sugar -= sugarPerPitcher;
                Ice -= icePerPitcher;
                Cups -= cupsPerPitcher;
                Pitcher++;
        }
        public bool CanFillPitcher()
        {
            if (Lemons >= lemonsPerPitcher && Sugar >= sugarPerPitcher && Ice >= icePerPitcher && Cups >= cupsPerPitcher)
            {
                return true;
            }
            else return false;
        }
    }
}
