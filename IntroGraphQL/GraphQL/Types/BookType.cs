using GraphQL.Types;
using IntroGraphQL.Database;
using IntroGraphQL.Entities;
using IntroGraphQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType(Func<ApplicationDbContext> dbContext)
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Description);
            Field(t => t.ReleaseDate);
            FieldAsync<AuthorType>(
                "author",
                resolve: async context => {
                    using var db = dbContext();
                    var authorsRepository = new AuthorsRepository(db);
                    return await authorsRepository.GetAuthorByIdAsync(context.Source.AuthorId);
                }
                );
        }
    }
}
