using PokerHands.CollectionComparers;
using System.Collections.Generic;
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
			List<ICompareHands> CardComparersInMostImportantFirst = new List<ICompareHands>(){
				new StraightComparer(),
				new ThreeOfAKindComparer(),
				new TwoPairComparer(),
				new OnePairComparer(),
				new HighCardComparer(),
			};

			foreach (var comparer in CardComparersInMostImportantFirst){
				Player playerWithBetterHand = comparer.GetPlayerWithBetterHand(this, other);
				if (playerWithBetterHand != null)
				{
					return playerWithBetterHand == this;
				}	
			}

			return false;
		}
	}
}