using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers{
	internal class ThreeOfAKindComparer : ICompareHands{
		public Player GetPlayerWithBetterHand(Player left, Player right){
			if (EitherPlayerHasThreeOfAKind(left, right)){
				return PlayerWithBetterThreeOfAKind(left, right);
			}

			return null;
		}

		private static Player PlayerWithBetterThreeOfAKind(Player one, Player two){
			if (GetBestThreeOfAKind(two.Hand) == null) return one;
			if (GetBestThreeOfAKind(one.Hand) == null) return two;
			return (GetBestThreeOfAKind(one.Hand).HighCard.Value > GetBestThreeOfAKind(two.Hand).HighCard.Value) ? one : two;
		}

		private static bool EitherPlayerHasThreeOfAKind(Player one, Player two)
		{
			return (GetBestThreeOfAKind(one.Hand) != null || GetBestThreeOfAKind(two.Hand) != null);
		}

		private static CardCollection GetBestThreeOfAKind(CardCollection available){
			foreach (var card1 in available.Cards){
				foreach (var card2 in available.Cards){
					if (card1 == card2) continue;
					if (card1.Value != card2.Value) continue;

					foreach (var card3 in available.Cards){
						if (card3 == card1 || card3 == card2) continue;

						if (card1.Value == card3.Value){
							return new CardCollection(card1, card2, card3);
						}
					}
				}
			}

			return null;
		}
	}
}