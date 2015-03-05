using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokerHands
{
	public class Game{
		public Player Player1 = new Player();
		public Player Player2 = new Player();

		public object GetWinner(){
			return Player2;
		}
	}
}
