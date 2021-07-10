namespace Snakes
{
   public class Token
   {
      public int Position { get; private set; }

      public Token() : this(1) {}

      private Token(int position)
      {
         Position = position;
      }

      public Token Move(int moves)
      {
         return new Token(Position + moves);
      }
   }
}