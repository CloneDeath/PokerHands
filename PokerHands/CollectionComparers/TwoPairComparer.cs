using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers
{
	class TwoPairComparer : ICompareHands
	{
		public Player GetPlayerWithBetterHand(Player left, Player right)
		{
			if (EitherPlayerHasTwoPairs(left, right)){
				return PlayerWithBetterTwoPairs(left, right);
			}

			return null;
		}

		private static Player PlayerWithBetterTwoPairs(Player one, Player two)
		{
			if (two.Hand.BestTwoPair == null) return one;
			if (one.Hand.BestTwoPair == null) return two;
			return (one.Hand.BestTwoPair.HighCard.Value > two.Hand.BestTwoPair.HighCard.Value) ? one : two;
		}

		private static bool EitherPlayerHasTwoPairs(Player one, Player two)
		{
			return (one.Hand.BestTwoPair != null || two.Hand.BestTwoPair != null);
		}
	}
}
