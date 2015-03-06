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
	public class CardValueTest
	{
		[TestCase("K", "2", true)]
		[TestCase("2", "K", false)]
		public void ValueIsGreaterThanLessThan(string leftValue, string rightValue, bool leftGreater){
			CardValue highCard = new CardValue(leftValue);
			CardValue lowCard = new CardValue(rightValue);

			(highCard > lowCard).Should().Be(leftGreater);
			(highCard < lowCard).Should().Be(!leftGreater);
		}

		[TestCase("K", "K", true)]
		[TestCase("4", "4", true)]
		[TestCase("9", "J", false)]
		public void ValueIsEqual(string leftValue, string rightValue, bool isEqual){
			CardValue highCard = new CardValue(leftValue);
			CardValue lowCard = new CardValue(rightValue);

			(highCard == lowCard).Should().Be(isEqual);
			(highCard != lowCard).Should().Be(!isEqual);
		}
	}
}
