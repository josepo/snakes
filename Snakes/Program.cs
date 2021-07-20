using System;

namespace Snakes
{
   class Program
   {
      static void Main(string[] args)
      {
         bool quit = false;
         Player player = new Player(new Dice(), new Board());

         while (!quit)
         {
            Console.WriteLine(player);
            Console.WriteLine("(r)oll dice - (q)uit\n");

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.KeyChar)
            {
               case 'r':
                  player.Roll();

                  if (player.Won())
                  {
                     Console.WriteLine("Congrats! You won!");
                     quit = true;
                  }

                  break;

               case 'q':
                  quit = true;
                  break;
            }
         }
      }
   }
}
