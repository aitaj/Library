using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryFnlProject.Models
{
   public  class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string Fin{ get; set; }
        [Required]
        [StringLength(15)]
        public string Phone { get; set; }
        public int ReportId { get; set; }
        public ICollection<Report> Report { get; set; }


    }
}
