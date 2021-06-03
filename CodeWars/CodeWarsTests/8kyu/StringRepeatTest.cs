using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    [TestFixture]
    public class StringRepeatTest
    {
        [Test(Description = "Fixed Tests")]
        public void StringRepeatTest_ShouldSucceed()
        {
            Assert.AreEqual("***", StringRepeat.RepeatStr(3, "*"));
            Assert.AreEqual("#####", StringRepeat.RepeatStr(5, "#"));
            Assert.AreEqual("ha ha ", StringRepeat.RepeatStr(2, "ha "));
        }
    }
}
