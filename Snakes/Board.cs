using System.Collections.Generic;

namespace Snakes
{
   public class Board
   {
      public int Start { get; private set; } = 1;
      public int End { get; private set; } = 100;

      private Dictionary<int, int> Snakes = new Dictionary<int, int>
      {
         { 16, 6 },
         { 46, 25 },
         { 49, 11 },
         { 62, 19 },
         { 64, 60 },
         { 74, 53 },
         { 89, 68 },
         { 92, 88 },
         { 95, 75 },
         { 99, 80 }
      };

      private Dictionary<int, int> Ladders = new Dictionary<int, int>
      {
         { 2, 38 },
         { 7, 14 },
         { 8, 31 },
         { 15, 26 },
         { 21, 42 },
         { 28, 84 },
         { 36, 44 },
         { 51, 67 },
         { 71, 91 },
         { 78, 98 },
         { 87, 94 }
      };
   }
}