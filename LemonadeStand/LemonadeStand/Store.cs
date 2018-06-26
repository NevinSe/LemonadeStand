using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        private double lemonPrice = 0.1;
        private double icePrice = 0.05;
        private double cupsPrice = 0.15;
        private double sugarPrice = 0.1;
        private int stackOfLemons = 10;
        private int stackOfSugar = 5;
        private int stackOfIce = 100;
        private int stackOfCups = 100;
        private double wackyWavingInflatableArmFlailingTubeMan = 10;
        public void EnterStore(Player playerOne, Inventory playerInventory)
        {
            Console.WriteLine("\r\nWelcome to the store!\r\nWe sell items at the lowest possible market value!\r\n(Just don't ask around too much)");
            Console.WriteLine("\r\nThe current market price of all our items are as follows:");
            NewPrices();
            DisplayItems(playerOne, playerInventory);
            

        }

        public void DisplayItems(Player playerOne , Inventory playerInventory)
        {
            int numberOfStacks;
            string purchaseItem;
            Console.WriteLine("Total money: $"+playerOne.Money+"\r\n");
            Console.WriteLine("10 Lemons: $" + lemonPrice+"       (Your inventory: "+playerInventory.Lemons+")");
            Console.WriteLine("5lb Sugar: $" + sugarPrice+"       (Your inventory: " + playerInventory.Sugar+")");
            Console.WriteLine("100 Ice: $" + icePrice+"           (Your inventory: " + playerInventory.Ice+")");
            Console.WriteLine("100 Cups: $" + cupsPrice+"         (Your inventory: " + playerInventory.Cups+")");
            Console.WriteLine("Wacky waveing inflatable arm flailing tube man: $" + wackyWavingInflatableArmFlailingTubeMan);
            Console.WriteLine("\r\nWhich item would you like to purchase?\r\n(or type 'all' to purchase 1 stack of each");
            purchaseItem = Console.ReadLine().Trim().ToLower();
            if (purchaseItem != "quit")
            {
                Console.WriteLine("How many stacks would you like to buy?");
                numberOfStacks = int.Parse(Console.ReadLine().Trim());
                PurchaseItem(purchaseItem, numberOfStacks, playerInventory, playerOne);
            }
           
            
        }
        public void PurchaseItem(string purchaseItem, int numberOfStacks, Inventory playerInventory, Player playerOne)
        {
            
            switch(purchaseItem)
            {
                case "lemon":
                    playerInventory.Lemons += AddToInventory(numberOfStacks, stackOfLemons, lemonPrice, playerOne, purchaseItem);
                    break;
                case "sugar":
                    playerInventory.Sugar += AddToInventory(numberOfStacks, stackOfSugar, sugarPrice, playerOne, purchaseItem);
                    break;
                case "ice":
                    playerInventory.Ice += AddToInventory(numberOfStacks, stackOfIce, icePrice, playerOne, purchaseItem);
                    break;
                case "cups":
                    playerInventory.Cups += AddToInventory(numberOfStacks, stackOfCups, cupsPrice, playerOne, purchaseItem);
                    break;
                case "all":

                default:
                    Console.WriteLine("Enter a valid item\r\n");
                    break;
            }
            DisplayItems(playerOne, playerInventory);
        }
        public int AddToInventory(int numberOfStacks, int stackOfItem, double itemPrice, Player playerOne, string itemName)
        {
            int addedValue = stackOfItem * numberOfStacks;
            playerOne.Money -= lemonPrice * numberOfStacks;
            Console.WriteLine("\r\nYou added " + (stackOfItem * numberOfStacks) +" "+itemName+" to your inventory\r\nCost: $" + (itemPrice * numberOfStacks) + "\r\n");
            return addedValue;
        }

        public void NewPrices()
        {
            lemonPrice = Math.Round(ChangingMarket(lemonPrice, RandomNumber()),2);
            cupsPrice = Math.Round(ChangingMarket(cupsPrice, RandomNumber()),2);
            sugarPrice = Math.Round(ChangingMarket(sugarPrice, RandomNumber()),2);
            icePrice = Math.Round(ChangingMarket(icePrice, RandomNumber()),2);
        }
        public double ChangingMarket(double marketItem, double modifier)
        {
            double taxedItem = marketItem + modifier;
            return taxedItem;
        }
        public double RandomNumber()
        {
            Random rng = new Random();
            double nextInt = rng.NextDouble();
            return nextInt;
        }
    }
}
