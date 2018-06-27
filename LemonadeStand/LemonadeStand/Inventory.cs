using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public double Wampum = 2;
        public int WWIFATM = 0;
        public int Lemons;
        public int Sugar;
        public int Ice;
        public int Cups;
        public int Pitcher = 0;
        public int FilledCups = 0;
        public int cupsPerPitcher = 6;
        public int lemonsPerPitcher = 4;
        public int sugarPerPitcher = 2; 
        public int icePerPitcher = 4;

        public Inventory()
        {
            this.Lemons = 0;
            this.Sugar = 0;
            this.Ice = 0;
            this.Cups = 0;
        }

        public void FillAPitcher()
        {
                Lemons -= lemonsPerPitcher;
                Sugar -= sugarPerPitcher;
                Ice -= icePerPitcher * cupsPerPitcher;
                Cups -= cupsPerPitcher;
                FilledCups = cupsPerPitcher;
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
