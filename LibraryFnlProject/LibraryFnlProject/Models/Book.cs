using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryFnlProject.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        [Required]
        public string Price { get; set; }

        [Required]
        [StringLength(12)]
        public string Article { get; set; }
      
        public BookCathegory Cathegory { get; set; }

        public int BookCathegoryId { get; set; }

        [Required]
        public string BookShelf { get; set; }

        public int? ReportId { get; set; }
         
        public Report Report { get; set; }

    }
}
