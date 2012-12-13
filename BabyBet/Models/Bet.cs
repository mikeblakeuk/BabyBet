using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabyBet.Models
{
    public class Bet
    {
        public DateTimeOffset BirthDate {get ; set;}
        public float Weight { get; set; }
        public bool isMale { get; set; }
        public string Name { get; set; }
    }
}