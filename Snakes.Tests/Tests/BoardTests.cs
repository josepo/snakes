using Xunit;

namespace Snakes
{
   public class BoardTests
   {
      [Fact]
      public void FinalPositionForSnakeSquare()
      {
         Board board = new Board();

         Assert.Equal(88, board.FinalPositionFor(92));
      }

      [Fact]
      public void FinalPositionForLadderSquare()
      {
         Board board = new Board();

         Assert.Equal(42, board.FinalPositionFor(21));
      }

      [Fact]
      public void FinalPositionForRegularSquare()
      {
         Board board = new Board();

         Assert.Equal(11, board.FinalPositionFor(11));
      }
   }
}