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
            weather.DisplayForcast();
            UserInterface.BeginningOfGame();
            while (dayCounter <= 13)
            {
                RunOneDay();
                dayCounter++;
            }
            
            
            
        }

        public void RunOneDay()
        {
                BuisnessOptions();
        }

        public void BuisnessOptions()
        {
            UserInterface.DisplayDayTempurature();
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
                default:
                    Console.WriteLine("Enter a valid choice please");
                    BuisnessOptions();
                    break;
            }
        }
       

    }
}
