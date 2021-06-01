using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQLTesting.Models
{
    public partial class CarInformation
    {
        public int Id { get; set; }
        public short? Year { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal? Cost { get; set; }
        public bool? CleanTitle { get; set; }
        public string Notes { get; set; }
        public int UserAccountId { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
