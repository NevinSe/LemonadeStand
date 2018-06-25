using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Player playerOne;
        public Store store;

        public void BuildObjects()
        {
            playerOne = new Human();
            store = new Store();
            store.EnterStore();
            Console.ReadLine();

        }

    }
}
