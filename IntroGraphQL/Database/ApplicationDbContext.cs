using IntroGraphQL.Entities;
using Microsoft.EntityFrameworkCore;

namespace IntroGraphQL.Database
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
