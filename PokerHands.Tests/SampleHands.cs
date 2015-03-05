using NUnit.Framework;
using System;

namespace PokerHands.Tests
{
	[TestFixture]
	public class SampleHands
	{
		[Test]
		public void CanMakeGame()
		{
			Game game = new Game();
		}

		[Test]
		public void CanGetWinner(){
			Game game = new Game();
			game.Player1.GiveCards("5H 5C 6S 7S KD");
			game.Player2.GiveCards("2C 3S 8S 8D QD");
		}
	}
}
