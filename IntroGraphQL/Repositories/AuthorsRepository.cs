using IntroGraphQL.Database;
using IntroGraphQL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.Repositories
{
    public class AuthorsRepository
    {
        private readonly ApplicationDbContext dbContext;
        public AuthorsRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<Author>> GetAuthorsAsync()
        {
            return await dbContext.Authors.ToListAsync();
        }

        public Author GetAuthorById(long id)
        {
            return dbContext.Authors.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Author> GetAuthorByIdAsync(long id)
        {
            return await dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
        }

    }
}
