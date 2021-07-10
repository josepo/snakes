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

      public void Roll()
      {
         Token.Move(Dice.Roll());
      }

      public bool Won()
      {
         return Token.Position == 100;
      }

      public override string ToString()
      {
         return $"\nYour current position is { Token.Position }.";
      }
   }
}