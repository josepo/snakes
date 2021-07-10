namespace Snakes
{
   public class Token
   {
      public int Id { get; private set; }
      public int Position { get; private set; }

      public Token(int id)
      {
         Id = id;
         Position = 1;
      }
   }
}