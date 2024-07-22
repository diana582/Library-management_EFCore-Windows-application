using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryDemo
{

    public class SchoolContext : DbContext
    {
        //entities
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<login> Logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FGS-DSK-292\\MSSQLSERVER2019;Database=Library;User ID=sa;Password=tb2024@fts1234;TrustServerCertificate=True");

        }
    }


}
