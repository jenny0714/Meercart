﻿// <auto-generated />
using System;
using Meercart.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Meercart.Migrations
{
    [DbContext(typeof(MeercartDBcontext))]
    [Migration("20180805155019_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("Meercart.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MasterMember");

                    b.Property<int>("ShoppingList");

                    b.HasKey("CartId");

                    b.ToTable("CartList");
                });

            modelBuilder.Entity("Meercart.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("MemberId");

                    b.ToTable("MemberList");
                });

            modelBuilder.Entity("Meercart.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("ProductId");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("Meercart.Models.ShoppingItem", b =>
                {
                    b.Property<int>("ShoppingItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CartId");

                    b.Property<DateTime>("ShoppingDate");

                    b.Property<string>("ShoppingName");

                    b.Property<int>("ShoppingNumber");

                    b.Property<string>("ShoppingOwner");

                    b.Property<int>("ShoppingPrice");

                    b.HasKey("ShoppingItemId");

                    b.HasIndex("CartId");

                    b.ToTable("ShoppingItem");
                });

            modelBuilder.Entity("Meercart.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StoreLocation");

                    b.Property<string>("StoreMemo");

                    b.Property<int>("StoreMiniCharge");

                    b.Property<string>("StoreName");

                    b.Property<string>("StorePhone");

                    b.HasKey("StoreId");

                    b.ToTable("StoreList");
                });

            modelBuilder.Entity("Meercart.Models.ShoppingItem", b =>
                {
                    b.HasOne("Meercart.Models.Cart")
                        .WithMany("ShoppingItem")
                        .HasForeignKey("CartId");
                });
#pragma warning restore 612, 618
        }
    }
}
