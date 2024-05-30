﻿using System;
using System.Collections.Generic;

namespace Shop.Model.Entities
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }
        public string? Image { get; set; }
        public string? MoreImage { get; set; }
        public decimal? Price { get; set; }
        public decimal? Promotion { get; set; }
        public DateTime? DaySubmit { get; set; }
        public int? Evaluate { get; set; }
        public int? Amountofpeople { get; set; }
        public int? Warranty { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public int? ViewCount { get; set; }
        public int? Day { get ; set; }

        public virtual ProductCategory? Category { get; set; }
    }
}
