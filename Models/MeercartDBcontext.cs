using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Meercart.Models
{
    public class MeercartDBcontext : DbContext
    {
        public DbSet<Member> MemberList { get; set; }
        public DbSet<Product> ProductList { get; set; }
        public DbSet<Cart> CartList { get; set; }
        public DbSet<Store> StoreList { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Meercart.db");
        }
    }

    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Cart
    {
        public int CartId { get; set; }
        public string MasterMember { get; set; }
        public int ShoppingList { get; set; }
        public List<ShoppingItem> ShoppingItem { get; set; } 
    }
    public class ShoppingItem
    {
        public string NameProduct { get; set; }
        public int NumberProduct { get; set; }
        public int PriceProduct { get; set; }
        public string OwnerProduct { get; set; }
        public DateTime ShoppingDate { get; set; }
    }
    public class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StorePhone { get; set; }
        public string StoreMemo { get; set; }
        public string StoreLocation { get; set; }
        public int StoreMiniCharge { get; set; }
    }
}