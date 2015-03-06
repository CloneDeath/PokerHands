using FluentAssertions;
using NUnit.Framework;

namespace PokerHands.Tests{
	[TestFixture]
	public class SampleHands{
		private Game game;

		[SetUp]
		public void CanMakeGame(){
			game = new Game();
		}

		[Test]
		public void CanGetWinner(){
			game.Player1.GiveCards("5H 5C 6S 7S TD");
			game.Player2.GiveCards("2C 3S 8S 8D QD");
			game.GetWinner().Should().Be(game.Player2);
		}

		[Test]
		public void TestHighestCard(){
			game.Player1.GiveCards("5D 8C 9S JS AC");
			game.Player2.GiveCards("2C 5C 7D 8S QH");
			game.GetWinner().Should().Be(game.Player1);
		}

		[Test]
		public void TestPair(){
			game.Player1.GiveCards("5H 5C 6S 7S KD");
			game.Player2.GiveCards("2C 3S 8S 8D TD");
			game.GetWinner().Should().Be(game.Player2);
		}

		[Test]
		public void TestTwoPair(){
			game.Player1.GiveCards("5H 3S 5D 3H KJ");
			game.Player2.GiveCards("6D 2C 6H 4D JS");
			game.GetWinner().Should().Be(game.Player1);
		}

		[Test]
		public void TestThreeOfAKind(){
			game.Player1.GiveCards("2H 2C 2S KH QH");
			game.Player2.GiveCards("4H 3S JS 3C 4S");
			game.GetWinner().Should().Be(game.Player1);
		}

		[Test]
		public void TestStraight(){
			game.Player1.GiveCards("2C 2H 2S 9H 9S");
			game.Player2.GiveCards("4C 2H 6D 5S 3H");
			game.GetWinner().Should().Be(game.Player2);
		}
	}
}