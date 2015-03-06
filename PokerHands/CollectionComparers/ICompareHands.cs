using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.CollectionComparers
{
	interface ICompareHands{
		Player GetPlayerWithBetterHand(Player left, Player right);
	}
}
