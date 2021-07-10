namespace Snakes
{
   public class FakeDice : IDice
   {
      private int _nextValue;

      public void Returns(int value)
      {
         _nextValue = value;
      }

      public int Roll()
      {
         return _nextValue;
      }
   }
}