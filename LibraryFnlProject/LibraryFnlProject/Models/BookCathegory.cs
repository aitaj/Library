using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryFnlProject.Models
{
    public class BookCathegory
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
