using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
	public class Card
	{
		public CardValue Value { get; set; }

		public string Suit { get; set; }

		public Card(string card){
			Value = new CardValue(card[0].ToString());
			Suit = card[1].ToString();
		}

		public override string ToString(){
			return Value.ToString() + Suit;
		}
	}
}
