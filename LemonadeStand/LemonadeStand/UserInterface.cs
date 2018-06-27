using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int gameLength;
        public static void BeginningOfGame()
        {
            Console.WriteLine("\r\n\r\n\tWelcome to Lemonade Stand!!");
            Console.WriteLine("\tPlease enter the number of days you wish to remain open:\r\n\t(7 days, 14 days)");
            gameLength = int.Parse(Console.ReadLine().Trim());

        }

        public static void SetLemonsPerPitcher(Inventory playerInventory)
        {
            Console.WriteLine("Please enter how many Lemons per pitcher (defualt 4 lemons)");
            playerInventory.lemonsPerPitcher=int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter how much sugar per pitcher (defualt 2 lbs)");
            playerInventory.sugarPerPitcher = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter how many ice cubes per pitcher (defualt 4 ice cubes)");
            playerInventory.icePerPitcher = int.Parse(Console.ReadLine().Trim());
            Console.WriteLine("Please enter the cost per cup (in wampum): ");
            playerInventory.Wampum = double.Parse(Console.ReadLine().Trim());
        }

        public static string GetUserChoice()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Enter:\r\n'store' to visit shop\r\n'recipe' to change lemonade recipe\r\n'open' to begin the day\r\n'weather' to display the weather forcast");
            string userInput = Console.ReadLine().Trim().ToLower();
            return userInput;
        }
        public static void DisplayInventory(Player playerOne, Inventory playerInventory, double beginningWapum)
        {
            Game.MafiaCut(playerOne, beginningWapum);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\nYou Made {0} Wampum today!",Game.netProfit);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The local mafia took {0} Wampum from your daily profits for 'Protection'",Game.mafiaCut);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your total Wampum is: {0}",playerOne.Money);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Lemons left {0}",playerInventory.Lemons);
            Console.WriteLine("Sugar left {0} lb", playerInventory.Sugar);
            Console.WriteLine("{0} ice cubes melted", playerInventory.Ice);
            Console.WriteLine("Cups left {0}", playerInventory.Cups);
            Console.ResetColor();
            Console.ReadLine();
        }

        public static void DisplayDayTempurature()
        {
            Console.WriteLine("Day: {0}", Game.dayCounter + 1);
            Console.Write("\r\nToday's tempurature is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(Weather.weatherForcast[Game.dayCounter]+"\r\n\r\n");
            Console.ResetColor();
        }

        public static void EndOfGameResults(Player playerOne)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congradulations on finishing the game!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your total Wampum was {playerOne.Money}!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"The mafia took a total of: {Game.mafiaCutTotal} Wampum (for 'protection')");
            Console.ResetColor();
        }
        public static void MainMenuDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t-MAIN MENU-");
            Console.ResetColor();
        }



    }
}
