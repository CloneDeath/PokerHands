using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands{
	public class CardCollection{
		private List<Card> _cards = new List<Card>();

		public CardCollection(){}

		internal void AddCard(Card card){
			_cards.Add(card);
		}

		public Card HighCard{
			get{
				Card bestCard = null;
				foreach (var card in _cards){
					if (bestCard == null || card.Value > bestCard.Value){
						bestCard = card;
					}
				}

				return bestCard;
			}
		}

		public CardCollection BestTwoPair{
			get{
				List<Card> available = new List<Card>(_cards);
				CardCollection pair1 = GetBestPair(available);
				if (pair1 == null) return null;

				foreach (Card card in pair1._cards){
					available.Remove(card);
				}
				CardCollection pair2 = GetBestPair(available);
				if (pair2 == null) return null;

				foreach (Card card in pair2._cards){
					pair1.AddCard(card);
				}
				return pair1;
			}
		}

		public CardCollection BestPair{
			get { return GetBestPair(_cards); }
		}

		private static CardCollection GetBestPair(List<Card> choices)
		{
			CardCollection collection = null;
			CardValue _bestPairValue = null;
			foreach (var card in choices){
				foreach (var pair in choices){
					if (card == pair) continue;

					if (card.Value == pair.Value){
						if (collection == null){
							collection = new CardCollection();
							collection.AddCard(card);
							collection.AddCard(pair);
							_bestPairValue = card.Value;
						}
						else{
							if (card.Value > _bestPairValue){
								_bestPairValue = card.Value;
								collection = new CardCollection();
								collection.AddCard(card);
								collection.AddCard(pair);
							}
						}
					}
				}
			}
			return collection;
		}

		public override string ToString(){
			string ret = "";
			foreach (Card card in _cards){
				ret += card.ToString() + " ";
			}
			return ret;
		}
	}
}