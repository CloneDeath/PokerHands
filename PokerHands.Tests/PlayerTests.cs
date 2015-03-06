using NUnit.Framework;
using FluentAssertions;

namespace PokerHands.Tests{
	[TestFixture]
	internal class PlayerTests{
		[TestCase("5D 8C 9S JS AC", "AC")]
		[TestCase("5D 8C 9S JS 2D", "JS")]
		public void TestHighestCard(string hand, string bestcard){
			Player player = new Player();
			player.GiveCards(hand);
			player.Hand.HighCard.ToString().Should().Be(bestcard);
		}
	}
}