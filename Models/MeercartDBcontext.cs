using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Meercart.Models
{
    public class MeercartDBcontext : DbContext
    {
        public DbSet<Member> Member { get; set; }
        public DbSet<Product> Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }
    }

    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }

        public List<Member> Posts { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public List<Product> Posts { get; set; }
    }


}