using System;

namespace Snakes
{
   public class Player
   {
      private IDice Dice { get; set; }
      public int Position { get; private set; }

      public Player(IDice dice) : this(dice, 1) {}

      public Player(IDice dice, int position)
      {
         Dice = dice ?? throw new ArgumentNullException(nameof(dice));
         Position = position;
      }

      public void Roll()
      {
         int newPosition = Position + Dice.Roll();

         if (newPosition <= 100)
            Position = newPosition;
      }

      public bool Won()
      {
         return Position == 100;
      }

      public override string ToString()
      {
         return $"\nYour current position is { Position }.";
      }
   }
}