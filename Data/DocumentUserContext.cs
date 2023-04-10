using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DocumentUser.Models;

namespace DocumentUser.Data
{
    public class DocumentUserContext : DbContext
    {
        public DocumentUserContext (DbContextOptions<DocumentUserContext> options)
            : base(options)
        {
        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserDocument> UserDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Document>().ToTable("Document");
            modelBuilder.Entity<UserDocument>().ToTable("UserDocument");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
