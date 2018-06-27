using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        static public List<int> weatherForcast;
        public Weather()
        {
            weatherForcast = new List<int>();
        }
        public int RandomWeatherGenerator()
        {
            Random rng = new Random();
            int weatherDay = rng.Next(65, 110);
            return weatherDay;
        }

        public void BuildForcast()
        {
            for(int i = 0; i<UserInterface.gameLength;i++)
            {
                weatherForcast.Add(RandomWeatherGenerator());
                System.Threading.Thread.Sleep(10);
            }
        }

        public void DisplayForcast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nThe weather forcast for the week is as follows:\r\n");
            for(int i = 0;i<weatherForcast.Count;i++)
            {
                if(i == weatherForcast.Count - 1)
                {
                    Console.Write(weatherForcast[i]);
                }
                else
                Console.Write(weatherForcast[i]+", ");
            }
            Console.WriteLine("\r\n");
            Console.ResetColor();
        }
        public static void DisplayRemainingForcast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\nThe weather forcast for the rest of the week is as follows:\r\n");
            for (int i = Game.dayCounter+1; i < weatherForcast.Count; i++)
            {
                if (i == weatherForcast.Count - 1)
                {
                    Console.Write(weatherForcast[i]);
                }
                else
                    Console.Write(weatherForcast[i] + ", ");
            }
            Console.WriteLine("\r\n");
            Console.ResetColor();
        }
    }
}
