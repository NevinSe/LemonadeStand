using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface : Game
    {
        public void BeginningOfGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand!!");
            Console.WriteLine("Please enter the number of days you wish to remain open:\r\n(7 days, 14 days, 16 days,");
            string gameLength = Console.ReadLine();

        }

    }
}
