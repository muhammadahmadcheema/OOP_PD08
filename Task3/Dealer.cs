using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Dealer: Player
    {
        public override void AddCard(Card card)
        {
            base.AddCard(card);
        }

        public bool ShouldDraw()
        {
            return CalculateScore() < 17;
        }
    }
}
