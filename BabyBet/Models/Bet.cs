//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BabyBet.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bet
    {
        public int BetId { get; set; }
        public Nullable<System.DateTimeOffset> BirthDate { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<bool> IsMale { get; set; }
    }
}
