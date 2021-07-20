using System;

namespace Snakes
{
   public class Player
   {
      private IDice Dice { get; set; }
      private Board Board { get; set; }
      public int Position { get; private set; }

      public Player(IDice dice, Board board) : this(dice, board, board.Start) {}

      public Player(IDice dice, Board board, int position)
      {
         Dice = dice ?? throw new ArgumentNullException(nameof(dice));
         Board = board ?? throw new ArgumentNullException(nameof(board));
         Position = position;
      }

      public void Roll()
      {
         int newPosition = Position + Dice.Roll();

         if (newPosition <= Board.End)
            Position = Board.FinalPositionFor(newPosition);
      }

      public bool Won()
      {
         return Position == Board.End;
      }

      public override string ToString()
      {
         return $"\nYour current position is { Position }.";
      }
   }
}