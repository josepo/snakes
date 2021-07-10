using System;

namespace Snakes
{
   public interface IDice
   {
      int Roll();
   }

   public class Dice : IDice
   {
      public int Roll()
      {
         return new Random().Next(1, 6);
      }
   }
}