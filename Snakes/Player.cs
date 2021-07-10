using System;

namespace Snakes
{
   public class Player
   {
      private IDice Dice { get; set; }
      public Token Token { get; private set; }

      public Player(IDice dice, Token token)
      {
         Dice = dice ?? throw new ArgumentNullException(nameof(dice));
         Token = token ?? throw new ArgumentNullException(nameof(token));
      }

      public int Roll()
      {
         return Dice.Roll();
      }

      public bool Won()
      {
         return Token.Position == 100;
      }
   }
}