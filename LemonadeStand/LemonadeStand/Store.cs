using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        private double lemonPrice = 0.3;
        private double icePrice = 0.1;
        private double cupsPrice = 0.25;
        private double sugarPrice = 0.2;
        private int stackOfLemons = 10;
        private int stackOfSugar = 5;
        private int stackOfIce = 50;
        private int stackOfCups = 50;
        private double wackyWavingInflatableArmFlailingTubeMan = 20;
        public void EnterStore(Player playerOne, Inventory playerInventory)
        {
            ResetPrices();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n\t\tWelcome to the store!\r\n\t\tWe sell items at the lowest possible market value!\r\n\t\t(Just don't ask around too much)");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\r\nThe current market price of all our items are as follows:");
            Console.ResetColor();
            NewPrices();
            DisplayItems(playerOne, playerInventory);
            

        }
        public void ResetPrices()
        {
            lemonPrice = 0.3;
            icePrice = 0.15;
            cupsPrice = 0.25;
            sugarPrice = 0.2;
        }

        public void DisplayItems(Player playerOne , Inventory playerInventory)
        {
            int numberOfStacks;
            string purchaseItem;
           
            Console.WriteLine("10 Lemons: " + lemonPrice+" Wampum       (Your inventory: "+playerInventory.Lemons+")");
            Console.WriteLine("5lb Sugar: " + sugarPrice+" Wampum       (Your inventory: " + playerInventory.Sugar+")");
            Console.WriteLine("50 Ice: " + icePrice+" Wampum           (Your inventory: " + playerInventory.Ice+")");
            Console.WriteLine("50 Cups: " + cupsPrice+" Wampum         (Your inventory: " + playerInventory.Cups+")");
            Console.WriteLine("Wacky waving inflatable arm flailing tube man: " + wackyWavingInflatableArmFlailingTubeMan+" Wampum");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\r\nTotal money: " + playerOne.Money + " Wampum\r\n");
            Console.ResetColor();
            Console.WriteLine("\r\nWhich item would you like to purchase?\r\n----(or type 'all' to purchase all ingrediants at once)\r\nEnter 'quit' to leave store");
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
                case "wacky waving inflatable arm flailing tube man":
                    playerInventory.WWIFATM++;
                    playerOne.Money -= wackyWavingInflatableArmFlailingTubeMan;
                    Console.WriteLine("\r\nYou bought Wacky waveing inflatable arm flailing tube man");
                        break;
                case "all":
                    playerInventory.Lemons += AddToInventory(numberOfStacks, stackOfLemons, lemonPrice, playerOne, purchaseItem);
                    playerInventory.Sugar += AddToInventory(numberOfStacks, stackOfSugar, sugarPrice, playerOne, purchaseItem);
                    playerInventory.Ice += AddToInventory(numberOfStacks, stackOfIce, icePrice, playerOne, purchaseItem);
                    playerInventory.Cups += AddToInventory(numberOfStacks, stackOfCups, cupsPrice, playerOne, purchaseItem);
                    break;
                default:
                    Console.WriteLine("Enter a valid item\r\n");
                    break;
            }
            DisplayItems(playerOne, playerInventory);
        }
        public int AddToInventory(int numberOfStacks, int stackOfItem, double itemPrice, Player playerOne, string itemName)
        {
            if (playerOne.Money >= itemPrice * numberOfStacks)
            {
                int addedValue = stackOfItem * numberOfStacks;
                playerOne.Money -= itemPrice * numberOfStacks;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\r\nYou added " + (stackOfItem * numberOfStacks) + " " + itemName + " to your inventory\r\nCost: " + (itemPrice * numberOfStacks) + " Wampum\r\n");
                Console.ResetColor();
                return addedValue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Enough Wampum!!!!!!");
                Console.ResetColor();
                return 0;
            }
                
        }

        public void NewPrices()
        {
            lemonPrice = Math.Round(ChangingMarket(lemonPrice, RandomNumber()),2);
            System.Threading.Thread.Sleep(10);
            cupsPrice = Math.Round(ChangingMarket(cupsPrice, RandomNumber()),2);
            System.Threading.Thread.Sleep(10);
            sugarPrice = Math.Round(ChangingMarket(sugarPrice, RandomNumber()),2);
            System.Threading.Thread.Sleep(10);
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
