using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQLTesting.Models
{
    public partial class CarStatus
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int CarInformationId { get; set; }
        public bool Sold { get; set; }
        public decimal? PriceSold { get; set; }
        public short? YearSold { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
