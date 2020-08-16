using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFnlProject.Models
{
    public class Report
    {
        public int Id { get; set; }

        public Customer Customer { get; set;}
        
        public int CustomerId { get; set;}
        
        public ICollection<Book> Books { get; set; }
    }
}
