using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Entities
{
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        // Các trường khác trong bảng Blog
        public string Name { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public string Message { get; set; }
    }
}
