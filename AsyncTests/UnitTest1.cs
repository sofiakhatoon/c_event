using System;
using Xunit;

namespace AsyncTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
 string expected = "Woof!";
        string actual = "Meow";

        Assert.NotEqual(expected, actual);
        }
    }
}
