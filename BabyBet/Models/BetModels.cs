using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabyBet.Models
{
    public class BetModels
    {
        public IEnumerable<BabyBet.Models.Bet> Bets;
        public DateTimeOffset LastBet;
    }
}