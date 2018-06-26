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
        public Customer customer;
        protected Store store;
        protected Inventory playerInventory;
        Day day;
        UserInterface userInterface;

        public Game()
        {
            playerOne = new Human();
            store = new Store();
            playerInventory = new Inventory();
            userInterface = new UserInterface();
            day = new Day();
        }
        public void BuildObjects()
        {
            store.EnterStore(playerOne, playerInventory);
            userInterface.SetLemonsPerPitcher(playerInventory);
            day.RunDay(playerOne, playerInventory, customer);
            Console.ReadLine();
        }
       

    }
}
