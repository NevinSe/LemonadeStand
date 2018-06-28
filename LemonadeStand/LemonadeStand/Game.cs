using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game 
    {
        protected Player playerOne;
        protected Weather weather;
        public Customer customer;
        protected Store store;
        protected Inventory playerInventory;
        Day day;
        public static int dayCounter = 0;
        public static double netProfit;
        public static double mafiaCut;
        public static double mafiaCutTotal;
        public static double totalNetProfits;

        public Game()
        {
            playerOne = new Human();
            customer = new Customer();
            store = new Store();
            playerInventory = new Inventory();
            weather = new Weather();
            day = new Day();
        }
        public void BuildObjects()
        {
            UserInterface.BeginningOfGame();
            weather.BuildForcast();
            weather.DisplayForcast();
            while (dayCounter < UserInterface.gameLength)
            {
                RunOneDay();
                dayCounter++;
            }
            UserInterface.EndOfGameResults(playerOne);
            Console.ReadLine();
            
            
        }

        public void RunOneDay()
        {
                BuisnessOptions();
        }

        public void BuisnessOptions()
        {
            UserInterface.DisplayDayTempurature();
            UserInterface.MainMenuDisplay();
            string userInput = UserInterface.GetUserChoice();
            switch (userInput)
            {
                case "store":
                    store.EnterStore(playerOne, playerInventory);
                    BuisnessOptions();
                    break;
                case "recipe":
                    UserInterface.SetLemonsPerPitcher(playerInventory);
                    BuisnessOptions();
                    break;
                case "open":
                    day.RunDay(playerOne, playerInventory, customer, weather);
                    break;
                case "weather":
                    Weather.DisplayRemainingForecast();
                    BuisnessOptions();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice please");
                    BuisnessOptions();
                    break;
            }
        }

        public static void MafiaCut(Player playerOne, double beginningWapum)
        {
            netProfit = playerOne.Money - beginningWapum;
            if (netProfit >= 10)
            {
                mafiaCut = netProfit * 0.35;
            }
            else mafiaCut = 15;
            mafiaCutTotal += mafiaCut;
            totalNetProfits += netProfit - mafiaCut;
            playerOne.Money -= mafiaCut;
        }
       

    }
}
