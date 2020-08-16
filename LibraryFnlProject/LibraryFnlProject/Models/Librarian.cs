using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryFnlProject.Models
{
   public class Librarian
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(50)]
        public string Password { get; set; }

    }
}
