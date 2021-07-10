using Xunit;

namespace Snakes
{
   public class PlayerTests
   {
      [Fact]
      public void PlayerWins()
      {
         Token token = new Token(97);
         Player player = new Player(new Dice(), token);

         token.Move(3);

         Assert.True(player.Won());
      }

      [Fact]
      public void PlayerDoesNotWin()
      {
         Token token = new Token(97);
         Player player = new Player(new Dice(), token);

         token.Move(4);

         Assert.False(player.Won());
      }

      [Fact]
      public void PlayerRolls()
      {
         Player player = new Player(new Dice(), new Token());
         
         int moves = player.Roll();

         Assert.InRange(moves, 1, 6);
      }
   }
}