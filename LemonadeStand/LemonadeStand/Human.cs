using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Human : Player
    {
        public Human()
        {
            
        }

        public override string PromptForName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
