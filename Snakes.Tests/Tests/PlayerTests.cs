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

         Player player = new Player(dice, new Board(), 97);

         player.Roll();

         Assert.True(player.Won());
      }

      [Fact]
      public void PlayerDoesNotWin()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(4);

         Player player = new Player(dice, new Board(), 97);

         player.Roll();

         Assert.False(player.Won());
      }

      [Fact]
      public void PlayerRollsAndMovesToken()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(4);

         Player player = new Player(dice, new Board());

         player.Roll();

         Assert.Equal(5, player.Position);
      }

      [Fact]
      public void PlayerFallsOnSnake()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(1);

         Player player = new Player(dice, new Board(), 15);

         player.Roll();

         Assert.Equal(6, player.Position);     
      }

      [Fact]
      public void PlayerClimbsLadder()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(1);

         Player player = new Player(dice, new Board());

         player.Roll();

         Assert.Equal(38, player.Position);           
      }
   }
}