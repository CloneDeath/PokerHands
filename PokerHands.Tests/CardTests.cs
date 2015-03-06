using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FluentAssertions;

namespace PokerHands.Tests
{
	[TestFixture]
	public class CardTests
	{
		[Test]
		public void CanCreateCardFromString(){
			Card card = new Card("2H");
			card.Value.Should().Be(new CardValue("2"));
			card.Suit.Should().Be("H");
		}

		//[Test]
		//public void CanTestForGreaterValue(){
		//	Card card2 = new Card("2H");
		//	Card cardK = new Card("KS");

		//	(card2.Value < cardK.Value).Should().Be(true);
		//}
	}
}
