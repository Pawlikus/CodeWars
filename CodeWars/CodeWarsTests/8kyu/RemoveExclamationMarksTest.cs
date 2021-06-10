using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class RemoveExclamationMarksTest
    {
        [Test]
        public static void MyTests()
        {
            Assert.AreEqual("", RemoveExclamationMarks.RemoveExclamationMark(""), "Input: Empty string");
            Assert.AreEqual("", RemoveExclamationMarks.RemoveExclamationMark("!"), "Input: " + "!");
            Assert.AreEqual("", RemoveExclamationMarks.RemoveExclamationMark("!!"), "Input: " + "!!");
            Assert.AreEqual("Hi", RemoveExclamationMarks.RemoveExclamationMark("Hi!"), "Input: " + "Hi!");
            Assert.AreEqual("?", RemoveExclamationMarks.RemoveExclamationMark("!?!"), "Input: " + "!?!");
        }
    }
}