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
   }
}