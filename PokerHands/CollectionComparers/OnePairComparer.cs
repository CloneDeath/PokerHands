using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers
{
	class OnePairComparer : ICompareHands
	{
		public Player GetPlayerWithBetterHand(Player left, Player right)
		{
			if (EitherPlayerHasPair(left, right)){
				return GetPlayerWithBestPair(left, right);
			}

			return null;
		}

		private static bool EitherPlayerHasPair(Player one, Player two)
		{
			return one.Hand.BestPair != null || two.Hand.BestPair != null;
		}

		private static Player GetPlayerWithBestPair(Player one, Player two)
		{
			if (one.Hand.BestPair == null && two.Hand.BestPair != null) return two;
			if (one.Hand.BestPair != null && two.Hand.BestPair == null) return one;
			return (one.Hand.BestPair.HighCard.Value > two.Hand.BestPair.HighCard.Value) ? one : two;
		}

	}
}
