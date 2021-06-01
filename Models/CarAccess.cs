using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQLTesting.Models
{
    public partial class CarAccess
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int CarInformationId { get; set; }
        public bool? Write { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
