﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShelfOfShame.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfOfShame.Infrastructure
{
    public class Context : IdentityDbContext
    {
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }               
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<TvSerie> TvSeries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        
        public Context(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // UserGroup relation many-to-many
            builder.Entity<UserGroup>()
                .HasKey(ug => new { ug.UserId, ug.GroupId });
            builder.Entity<UserGroup>()
                .HasOne<User>(ug => ug.UserRef)
                .WithMany(u => u.UserGroups)
                .HasForeignKey(ug => ug.UserId);
            builder.Entity<UserGroup>()
                .HasOne<Group>(ug => ug.GroupRef)
                .WithMany(g => g.UserGroups)
                .HasForeignKey(ug => ug.GroupId);
            // ItemShelves relation many-to-many
            builder.Entity<ItemShelves>()
                .HasKey(its => new { its.ItemId, its.ShelfId });
            builder.Entity<ItemShelves>()
                .HasOne<Item>(its => its.Item)
                .WithMany(i => i.ItemShelves)
                .HasForeignKey(its => its.ItemId);
            builder.Entity<ItemShelves>()
                .HasOne<Shelf>(its => its.Shelf)
                .WithMany(s => s.ItemShelves)
                .HasForeignKey(its => its.ShelfId);
            // ContactInfo with User relation one to one
            builder.Entity<ContactInfo>()
                .HasOne(u => u.User)
                .WithOne(cu => cu.Contact)
                .HasForeignKey<ContactInfo>(e => e.UserId);         
        }
    }
}
