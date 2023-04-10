using CRUD_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EF.Data
{
    public class DocumentUserContext : DbContext
    {
        public DocumentUserContext(DbContextOptions<DocumentUserContext> options) : base(options)
        {
        }

        public DbSet<TaiLieu> Documents { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DocumentUser> DocumentUsers { get; set; }
    }
}
