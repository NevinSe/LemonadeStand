using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store : Game
    {
        private double lemonPrice = 0.25;
        private double icePrice = 0.15;
        private double cupsPrice = 0.60;
        private double sugarPrice = 0.25;
        private double wackyWavingInflatableArmFlailingTubeMan = 10;
        public void EnterStore()
        {
            Console.WriteLine("\r\nWelcome to the store!\r\nWe sell items at the lowest possible market value!\r\n(Just don't ask around too much)");
            Console.WriteLine("\r\nThe current market price of all our items are as follows:");
            NewPrices();
            DisplayItems();
            

        }

        public void DisplayItems()
        {
            int numberOfStacks;
            string purchaseItem;
            Console.WriteLine("10 Lemons: $" + lemonPrice);
            Console.WriteLine("5lb Sugar: $" + sugarPrice);
            Console.WriteLine("100 Ice: $" + icePrice);
            Console.WriteLine("100 Cups: $" + cupsPrice);
            Console.WriteLine("Wacky waveing inflatable arm flailing tube man: $" + wackyWavingInflatableArmFlailingTubeMan);
            Console.WriteLine("\r\nWhich item would you like to purchase?");
            purchaseItem = Console.ReadLine().Trim().ToLower();
            Console.WriteLine("How many stacks would you like to buy?");
            numberOfStacks = int.Parse(Console.ReadLine().Trim());
            PurchaseItem(purchaseItem, numberOfStacks);
            
        }
        public void PurchaseItem(string purchaseItem, int numberOfStacks)
        {
            
            switch(purchaseItem)
            {
                case "lemon":
                    playerOne.playerInventory[0].Amount += 10 * numberOfStacks;
                    playerOne.Money -= lemonPrice * numberOfStacks;
                    break;
                case "sugar":
                    playerOne.playerInventory[1].Amount += 5 * numberOfStacks;
                    playerOne.Money -= sugarPrice * numberOfStacks;
                    break;
                case "ice":
                    playerOne.playerInventory[2].Amount += 100 * numberOfStacks;
                    playerOne.Money -= icePrice * numberOfStacks;
                    break;
                case "cups":
                    playerOne.playerInventory[3].Amount += 10 * numberOfStacks;
                    playerOne.Money -= cupsPrice * numberOfStacks;
                    break;
                default:
                    Console.WriteLine("Enter a valid item\r\n");
                    break;
            }
            DisplayItems();
        }
        public void BuyCups()
        {

        }
        public void BuyIce()
        {

        }
        public void BuyWackyWavingInflatableArmFlailingTubeMan()
        {

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
