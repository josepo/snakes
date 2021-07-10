namespace Snakes
{
   public class Token
   {
      public int Position { get; private set; }

      public Token() : this(1) {}

      public Token(int position)
      {
         Position = position;
      }

      public void Move(int moves)
      {
         int position = Position + moves;

         if (position <= 100)
            Position = position;
      }
   }
}