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
        private double beginningWampum;
        public void RunDay(Player playerOne, Inventory playerInventory, Customer customer, Weather weather)
        {
            beginningWampum = playerOne.Money;
            CreateCustomers(playerOne, playerInventory, customer, 20);
            UserInterface.DisplayInventory(playerOne, playerInventory, beginningWampum);
            playerInventory.Ice = 0;
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
                switch (rng.Next(1, 5))
                {
                    case 1:
                        customer = new OldWoman();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        break;
                    case 2:
                        customer = new YoungMan();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        break;
                    case 3:
                        customer = new Child();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        break;
                    case 4:
                        customer = new Alien();
                        SetTolerance(customer, playerInventory);
                        SalesLogic(playerOne, playerInventory, customer);
                        break;
                }
                System.Threading.Thread.Sleep(10);

            }
        } 
        public void CustomerBuy(Player playerOne , Inventory playerInventory, Customer customerPerson)
        {
            if(customerPerson.BuyLogic(playerInventory) && playerInventory.Cups > 0)
            {
                playerOne.Money += playerInventory.Wampum;
                playerInventory.FilledCups--;
                Console.WriteLine("You made a sale! (" + customerPerson.Name + ")");
            }
        }
        public void SalesLogic(Player playerOne, Inventory playerInventory, Customer customerPerson)
        {
            if (playerInventory.FilledCups > 0)
            {
                CustomerBuy(playerOne, playerInventory, customerPerson);
            }
            else if (playerInventory.CanFillPitcher() && playerInventory.FilledCups == 0)
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
            customerPerson.heatTolerance = Weather.weatherForcast[Game.dayCounter];
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
