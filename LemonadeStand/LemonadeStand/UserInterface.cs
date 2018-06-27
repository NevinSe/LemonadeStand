using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static void BeginningOfGame()
        {
            Console.WriteLine("\r\n\r\n\tWelcome to Lemonade Stand!!");
            Console.WriteLine("\tPlease enter the number of days you wish to remain open:\r\n\t(7 days, 14 days)");
            string gameLength = Console.ReadLine();

        }

        public static void SetLemonsPerPitcher(Inventory playerInventory)
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

        public static string GetUserChoice()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter:\r\n'store' to visit shop\r\n'recipe' to change lemonade recipe\r\n'open' to begin the day");
            string userInput = Console.ReadLine().Trim().ToLower();
            return userInput;
        }
        public static void DisplayInventory(Player playerOne, Inventory playerInventory, double beginningWapum)
        {
            double netProfit = playerOne.Money - beginningWapum;
            Console.WriteLine("\r\nYou Made {0} Wampum today!",netProfit);
            Console.WriteLine("Your total Wampum is : {0}",playerOne.Money);
            Console.WriteLine("Lemons left {0}",playerInventory.Lemons);
            Console.WriteLine("Sugar left {0}lb", playerInventory.Sugar);
            Console.WriteLine("{0} ice cubes melted", playerInventory.Ice);
            Console.WriteLine("Cups left {0}", playerInventory.Cups);
            Console.ReadLine();
        }

        public static void DisplayDayTempurature()
        {
            Console.WriteLine("\r\nToday's tempurature is {0}\r\n", Weather.weatherForcast[Game.dayCounter]);
        }



    }
}
