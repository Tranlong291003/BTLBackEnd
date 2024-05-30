using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Entities
{
    public class About
    {
        public int? Id { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyImage { get; set; }
        public string? introduce { get; set; }
        public bool? Status { get; set; }
    }
}
