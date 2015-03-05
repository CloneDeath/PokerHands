using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerHands
{
	public class Player
	{
		private string cards;

		public void GiveCards(string cards)
		{
			this.cards = cards;
		}

		private static readonly char[] CardValuesDescending = "AKQJT98765432".ToArray();

		public string HighCard
		{
			get
			{
				foreach (char cardValue in CardValuesDescending){
					int index = cards.IndexOf(cardValue);
					if (index != -1)
					{
						return cards.Substring(index, 2);
					}	
				}

				return "";
			}
		}
	}
}
