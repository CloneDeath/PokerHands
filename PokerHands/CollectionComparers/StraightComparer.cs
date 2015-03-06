using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers
{
	class StraightComparer : ICompareHands
	{
		public Player GetPlayerWithBetterHand(Player left, Player right)
		{
			if (EitherPlayerHasStraight(left, right)){
				return GetPlayerWithBetterStraight(left, right);
			}

			return null;
		}

		private Player GetPlayerWithBetterStraight(Player left, Player right){
			return null;
		}

		private bool EitherPlayerHasStraight(Player left, Player right){
			return (GetStraight(left) != null || GetStraight(right) != null);
		}

		private object GetStraight(Player player){
			return null;
		}
	}
}
