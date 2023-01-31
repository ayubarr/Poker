using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Interfaces
{
    public interface ICheck
    {
        public void ViewCard(Card card);

        public string RankCheck(Card card);
        public string SuitCheck(Card card);
    }
}
