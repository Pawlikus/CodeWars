using CodeWars.CodeWars._8kyu;
using NUnit.Framework;

namespace CodeWars.CodeWarsTests._8kyu
{
    internal class RockPaperScissorsTest
    {
        [Test]
        public void Player1Win()
        {
            Assert.AreEqual("Player 1 won!", RockPaperScissors.Rps("rock", "scissors"));
            Assert.AreEqual("Player 1 won!", RockPaperScissors.Rps("scissors", "paper"));
            Assert.AreEqual("Player 1 won!", RockPaperScissors.Rps("paper", "rock"));
        }

        [Test]
        public void Player2Win()
        {
            Assert.AreEqual("Player 2 won!", RockPaperScissors.Rps("scissors", "rock"));
            Assert.AreEqual("Player 2 won!", RockPaperScissors.Rps("paper", "scissors"));
            Assert.AreEqual("Player 2 won!", RockPaperScissors.Rps("rock", "paper"));
        }

        [Test]
        public void Draw()
        {
            Assert.AreEqual("Draw!", RockPaperScissors.Rps("rock", "rock"));
            Assert.AreEqual("Draw!", RockPaperScissors.Rps("scissors", "scissors"));
            Assert.AreEqual("Draw!", RockPaperScissors.Rps("paper", "paper"));
        }
    }
}