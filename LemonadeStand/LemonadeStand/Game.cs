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
        UserInterface userInterface;
        private int dayCounter = 0;

        public Game()
        {
            playerOne = new Human();
            customer = new Customer();
            store = new Store();
            playerInventory = new Inventory();
            userInterface = new UserInterface();
            weather = new Weather();
            day = new Day();
        }
        public void BuildObjects()
        {
            weather.DisplayForcast();
            userInterface.BeginningOfGame();
            RunOneDay();
            
            
            
        }

        public void RunOneDay()
        {
            while(dayCounter < 13)
            {
                customer.heatTolerance = weather.weatherForcast[dayCounter];
                BuisnessOptions();
            }
            
        }

        public void BuisnessOptions()
        {
            string userInput = userInterface.GetUserChoice();
            switch (userInput)
            {
                case "store":
                    store.EnterStore(playerOne, playerInventory);
                    BuisnessOptions();
                    break;
                case "recipe":
                    userInterface.SetLemonsPerPitcher(playerInventory);
                    store.EnterStore(playerOne, playerInventory);
                    BuisnessOptions();
                    break;
                case "open":
                    day.RunDay(playerOne, playerInventory, customer);
                    break;
                default:
                    Console.WriteLine("Enter a valid choice please");
                    BuisnessOptions();
                    break;
            }
        }
       

    }
}
