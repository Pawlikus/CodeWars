using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

[TestFixture]
public class MultiplyNumbersTest
{
    [Test]
    public void ShouldMultiple()
    {
        Assert.AreEqual(2, MultiplyNumbers.Multiply(2, 1));
        Assert.AreEqual(8, MultiplyNumbers.Multiply(2, 4));
    }
}