using System;
using System.Collections.Generic;

namespace Shop.Model.Entities
{
    public partial class VisitorStaticti
    {
        public int Id { get; set; }
        public DateTime VisitedDate { get; set; }
        public string Ipaddress { get; set; } = null!;
    }
}
