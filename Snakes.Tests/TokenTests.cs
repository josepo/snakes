using Xunit;

namespace Snakes.Tests
{
   public class TokenTests
   {
      [Fact]
      public void NewTokenInStartingPosition()
      {
         Token token = new Token();

         Assert.Equal(1, token.Position);
      }

      [Fact]
      public void TokenMoves()
      {
         Token token = new Token().Move(3);

         Assert.Equal(4, token.Position);
      }
   }
}
