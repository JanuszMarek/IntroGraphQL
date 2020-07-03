using IntroGraphQL.Database;
using IntroGraphQL.Entities;
using System.Collections.Generic;

namespace IntroGraphQL.Repositories
{
    public class BooksRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BooksRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Book> GetAll()
        {
            return dbContext.Books;
        }
    }
}
