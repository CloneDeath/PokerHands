using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers
{
	class HighCardComparer : ICompareHands
	{
		public Player GetPlayerWithBetterHand(Player left, Player right)
		{
			return (left.Hand.HighCard.Value > right.Hand.HighCard.Value) ? left : right;
		}
	}
}
