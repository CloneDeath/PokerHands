using FluentAssertions;
using NUnit.Framework;

namespace PokerHands.Tests{
	[TestFixture]
	public class SampleHands{
		[Test]
		public void CanMakeGame(){
			var game = new Game();
		}

		[Test]
		public void CanGetWinner(){
			var game = new Game();
			game.Player1.GiveCards("5H 5C 6S 7S KD");
			game.Player2.GiveCards("2C 3S 8S 8D QD");
			game.GetWinner().Should().Be(game.Player2);
		}
	}
}