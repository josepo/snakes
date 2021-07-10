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
         Token token = new Token();
         token.Move(3);

         Assert.Equal(4, token.Position);
      }

      [Fact]
      public void TokenMovesTwice()
      {
         Token token = new Token();
         token.Move(3);
         token.Move(4);

         Assert.Equal(8, token.Position);
      }

      [Fact]
      public void TokenWontMovePastBoardLimit()
      {
         Token token = new Token(97);
         token.Move(4);

         Assert.Equal(97, token.Position);
      }
   }
}
