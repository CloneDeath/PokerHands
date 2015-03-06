using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
	public class CardValue : IComparable{
		public string Value { get; set; }
		private const string CardValuesAscending = "23456789TJQKA";

		public CardValue(string value){
			Value = value;
		}

		public static bool operator>(CardValue left, CardValue right){
			return CardValuesAscending.IndexOf(left.Value) > CardValuesAscending.IndexOf(right.Value);
		}

		public static bool operator<(CardValue left, CardValue right){
			return CardValuesAscending.IndexOf(left.Value) < CardValuesAscending.IndexOf(right.Value);
		}

		public static bool operator ==(CardValue left, CardValue right){
			return left.Equals(right);
		}

		public static bool operator !=(CardValue left, CardValue right){
			return !left.Equals(right);
		}

		public override bool Equals(object obj){
			if (obj == null || !(obj is CardValue)) return false;

			CardValue other = obj as CardValue;
			return other.Value == this.Value;
		}

		public override string ToString(){
			return Value;
		}

		public int CompareTo(object obj){
			CardValue other = obj as CardValue;
			if (this < other) return -1;
			if (this > other) return 1;
			return 0;
		}
	}
}
