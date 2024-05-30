using System;
using System.Collections.Generic;

namespace Shop.Model.Entities
{
    public partial class Tag
    {
        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
