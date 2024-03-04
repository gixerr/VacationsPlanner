using FluentAssertions;
using Xunit;

namespace VacationsPlanner.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var x = true;

        x.Should().BeTrue();
    }
}