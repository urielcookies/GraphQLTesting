using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQLTesting.Models
{
    public partial class CarExpense
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int CarInformationId { get; set; }
        public string Expense { get; set; }
        public decimal Cost { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
