using FluentAssertions;
using Xunit;

namespace Capoccione.Test
{
    public class DummyTest
    {
        [Fact]
        public void dummy_passing_test()
        {
            "friends".Should().Be("friends");
        }
    }
}

