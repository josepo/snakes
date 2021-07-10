using Xunit;

namespace Snakes
{
   public class PlayerTests
   {
      [Fact]
      public void PlayerWinsWhenTokenInFinalSquare()
      {
         Token token = new Token(97);
         Player player = new Player(token);

         token.Move(3);

         Assert.True(player.Won());
      }

      [Fact]
      public void PlayerDoesNotWinWhenTokenNotInFinalSquare()
      {
         Token token = new Token(97);
         Player player = new Player(token);

         token.Move(4);

         Assert.False(player.Won());
      }      
   }
}