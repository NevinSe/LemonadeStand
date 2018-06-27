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
            BuildForcast();
        }
        public int RandomWeatherGenerator()
        {
            Random rng = new Random();
            int weatherDay = rng.Next(65, 110);
            return weatherDay;
        }

        public void BuildForcast()
        {
            for(int i = 0; i<14;i++)
            {
                weatherForcast.Add(RandomWeatherGenerator());
                System.Threading.Thread.Sleep(10);
            }
        }

        public void DisplayForcast()
        {
            Console.WriteLine("\r\nThe weather forcast for the week is as follows:\r\n");
            for(int i = 0;i<weatherForcast.Count;i++)
            {
                Console.Write(weatherForcast[i]+", ");
            }
        }
    }
}
