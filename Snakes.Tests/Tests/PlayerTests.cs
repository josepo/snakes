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
      public void PlayerRollsAndMovesToken()
      {
         FakeDice dice = new FakeDice();
         dice.Returns(4);

         Token token = new Token();
         Player player = new Player(dice, token);

         player.Roll();

         Assert.Equal(5, token.Position);
      }
   }
}