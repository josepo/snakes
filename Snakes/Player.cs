using System;

namespace Snakes
{
   public class Player
   {
      public Token Token { get; private set; }

      public Player(Token token)
      {
         Token = token ?? throw new ArgumentNullException(nameof(token));
      }

      public bool Won()
      {
         return Token.Position == 100;
      }
   }
}