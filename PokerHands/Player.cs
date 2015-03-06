using System.Runtime.Remoting.Messaging;

namespace PokerHands{
	public class Player{
		public CardCollection Hand;

		public Player(){
			Hand = new CardCollection();
		}

		public void GiveCards(string cards){
			var cardNames = cards.Split(' ');
			foreach (var name in cardNames){
				Hand.AddCard(new Card(name));
			}
		}

		internal bool HasABetterHandThan(Player other){
			if (EitherPlayerHasTwoPairs(this, other)){
				return PlayerWithBetterTwoPairs(this, other) == this;
			}
			if (EitherPlayerHasPair(this, other)){
				return GetPlayerWithBestPair(this, other) == this;
			}
			return GetPlayerWithLargestSingleCard(this, other) == this;
		}

		private static Player PlayerWithBetterTwoPairs(Player one, Player two){
			if (two.Hand.BestTwoPair == null) return one;
			if (one.Hand.BestTwoPair == null) return two;
			return (one.Hand.BestTwoPair.HighCard.Value > two.Hand.BestTwoPair.HighCard.Value) ? one : two;
		}

		private static bool EitherPlayerHasTwoPairs(Player one, Player two){
			return (one.Hand.BestTwoPair != null || two.Hand.BestTwoPair != null);
		}

		private static Player GetPlayerWithLargestSingleCard(Player one, Player two){
			return (one.Hand.HighCard.Value > two.Hand.HighCard.Value) ? one : two;
		}

		private static Player GetPlayerWithBestPair(Player one, Player two){
			if (one.Hand.BestPair == null && two.Hand.BestPair != null) return two;
			if (one.Hand.BestPair != null && two.Hand.BestPair == null) return one;
			return (one.Hand.BestPair.HighCard.Value > two.Hand.BestPair.HighCard.Value) ? one : two;
		}

		private static bool EitherPlayerHasPair(Player one, Player two){
			return one.Hand.BestPair != null || two.Hand.BestPair != null;
		}
	}
}