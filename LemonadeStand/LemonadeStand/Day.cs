using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //Stopwatch timerDay = new Stopwatch();
        
        public void RunDay(Player playerOne, Inventory playerInventory, Customer customer)
        {
            CreateCustomers(playerOne, playerInventory, customer, 20);
            Console.WriteLine(playerOne.Money);
            Console.ReadLine();
        }

        public void CreateCustomers(Player playerOne, Inventory playerInventory, Customer customer, int spawnNumber)
        {
            if (playerInventory.CanFillPitcher())
            {
                playerInventory.FillAPitcher();
            }
            else
            {
                Console.WriteLine("You have no Lemonade to sell!");
            }
            Random rng = new Random();
            for (int i = 0; i< spawnNumber; i++)
            {
                switch(rng.Next(1, 5))
                {
                    case 1:
                        customer = new OldWoman();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        Console.WriteLine(customer.Name);
                        break;
                    case 2:
                        customer = new YoungMan();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        Console.WriteLine(customer.Name);
                        break;
                    case 3:
                        customer = new Child();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        Console.WriteLine(customer.Name);
                        break;
                    case 4:
                        customer = new Alien();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        Console.WriteLine(customer.Name);
                        break;
                }
                System.Threading.Thread.Sleep(10);

            }
        } 
        public void CustomerBuy(Player playerOne , Inventory playerInventory, Customer customerPerson)
        {
            if(customerPerson.BuyLogic() && playerInventory.Cups > 0)
            {
                playerOne.Money += playerInventory.Wampum;
            }
        }
        public void SalesLogic(Player playerOne, Inventory playerInventory, Customer customerPerson)
        {
            if (playerInventory.Pitcher > 0)
            {
                CustomerBuy(playerOne, playerInventory, customerPerson);
            }
            else if (playerInventory.CanFillPitcher())
            {
                playerInventory.FillAPitcher();
                CustomerBuy(playerOne, playerInventory, customerPerson);
            }
            else
            {
                Console.WriteLine("No Lemonade to Sell!");
            }

        }
        public void SetTolerance(Customer customerPerson, Inventory playerInventory)
        {
            customerPerson.lemonTolerance = playerInventory.lemonsPerPitcher;
            customerPerson.sugarTolerance = playerInventory.sugarPerPitcher;
            customerPerson.iceTolerance = playerInventory.icePerPitcher;
            customerPerson.wampumTolerance = playerInventory.Wampum;
        }
        //public void SpawnTimer()
        //{
        //    Random rng = new Random();
        //    int waitfortimer = (rng.Next(1, 7));
        //    System.Threading.Thread.Sleep(waitfortimer*1000);
        //}
        //public void DayTimer()
        //{
        //    timerDay.Start();
        //    if (timerDay.Equals(1000))
        //    {
        //        Console.WriteLine("this timer worked");
        //        timerDay.Stop();
        //    }
        //}
    }
}
