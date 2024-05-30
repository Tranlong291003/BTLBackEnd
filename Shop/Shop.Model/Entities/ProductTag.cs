using System;
using System.Collections.Generic;

namespace Shop.Model.Entities
{
    public partial class ProductTag
    {
        public int? ProductId { get; set; }
        public string? TagId { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Tag? Tag { get; set; }
    }
}
