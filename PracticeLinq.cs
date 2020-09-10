using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        private static object game;

        static void Main(string[] args)
        {
            var gameList = new List<string> { "Mortal Kombat", "Donkey Kong", "Sonic", "Call Of Duty", "Medal Of Honor" };

            var nameLength = gameList.OrderBy(gameList => game);

            Console.ReadLine();
        }
    }
}
