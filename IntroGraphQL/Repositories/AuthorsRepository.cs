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
        public Author GetAuthorAsync(long id)
        {
            return dbContext.Authors.FirstOrDefault(x => x.Id == id);
        }
    }
}
