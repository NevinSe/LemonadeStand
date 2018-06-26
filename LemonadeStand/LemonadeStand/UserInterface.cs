using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class UserInterface
    {
        public void BeginningOfGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand!!");
            Console.WriteLine("Please enter the number of days you wish to remain open:\r\n(7 days, 14 days, 16 days,");
            string gameLength = Console.ReadLine();

        }

        public void SetLemonsPerPitcher(Inventory playerInventory)
        {
            Console.WriteLine("Please enter how many Lemons per pitcher (defualt 4 lemons)");
            playerInventory.lemonsPerPitcher=int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter how much sugar per pitcher (defualt 4lbs)");
            playerInventory.sugarPerPitcher = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter how many ice cubes per pitcher (defualt 4 ice cubes)");
            playerInventory.icePerPitcher = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter the cost per cup (in wampum): ");
            playerInventory.Wampum = double.Parse(Console.ReadLine().Trim());
        }


    }
}
