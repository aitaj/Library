using System;
using System.Collections.Generic;
using System.Text;
using LibraryFnlProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryFnlProject.Data
{
   public  class LibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<BookCathegory> BookCathegories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-85LIJUV;Database=LibraryProject;Integrated Security=True");
        }
    }
}
