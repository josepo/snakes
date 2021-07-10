using Xunit;

namespace Snakes
{
   public class DiceTests
   {
      [Fact]
      public void RollsValidValue()
      {
         Dice dice = new Dice();

         Assert.InRange(dice.Roll(), 1, 6);
      }
   }
}