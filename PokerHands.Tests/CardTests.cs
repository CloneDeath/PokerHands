using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PokerHands.Tests
{
	[TestFixture]
	public class CardTests
	{
		[Test]
		public void CanCreateCardFromString(){
			Card card = new Card("2H");
		}
	}
}
