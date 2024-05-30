using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Entities
{
	public class BookTour
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? Address { get; set; }
		public string? Email { get; set; }
		public string? Mobile { get; set; }
		public string? Message { get; set; }
		public DateTime? Date { get; set; }
		public bool? Status { get; set; }
	}
}
