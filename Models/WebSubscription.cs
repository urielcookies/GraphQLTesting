using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQLTesting.Models
{
    public partial class WebSubscription
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public string Endpoint { get; set; }
        public string P256dh { get; set; }
        public string Auth { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
