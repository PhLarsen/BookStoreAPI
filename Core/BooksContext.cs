namespace BooksAPI.Core
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class BooksContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}