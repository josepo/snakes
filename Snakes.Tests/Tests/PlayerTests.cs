using Xunit;

namespace Snakes
{
   public class PlayerTests
   {
      [Fact]
      public void PlayerWins()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(3);

         Player player = new Player(dice, 97);

         player.Roll();

         Assert.True(player.Won());
      }

      [Fact]
      public void PlayerDoesNotWin()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(4);

         Player player = new Player(dice, 97);

         player.Roll();

         Assert.False(player.Won());
      }

      [Fact]
      public void PlayerRollsAndMovesToken()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(4);

         Player player = new Player(dice);

         player.Roll();

         Assert.Equal(5, player.Position);
      }
   }
}