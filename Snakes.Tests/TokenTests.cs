using Xunit;

namespace Snakes.Tests
{
    public class TokenTests
    {
        [Fact]
        public void NewTokenInStartingPosition()
        {
           Token token = new Token(0);

           Assert.Equal(1, token.Position);
        }
    }
}
