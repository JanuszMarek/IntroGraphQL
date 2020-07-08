using IntroGraphQL.Database;
using IntroGraphQL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IntroGraphQL.Repositories
{
    public class BooksRepository
    {
        private readonly ApplicationDbContext dbContext;

        public BooksRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await dbContext.Books.ToListAsync();
        }

        public async Task<Book> GetById(long id)
        {
            return await dbContext.Books.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
