using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Entities
{
	public class User
	{
			public int Id { get; set; }
			public string Username { get; set; } = null!;
			public string Password { get; set; } = null!;
			public string? FullName { get; set; }
			public string? Email { get; set; }
			public string? Phone { get; set; }
			public string? Address { get; set; }
			public int Role { get; set; }
			public bool Status { get; set; }
	}
}
