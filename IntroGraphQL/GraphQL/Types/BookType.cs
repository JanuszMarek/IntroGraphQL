using GraphQL.Types;
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
        public BookType(AuthorsRepository authorsRepository)
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Description);
            Field(t => t.ReleaseDate);
            Field<AuthorType>(
                "author",
                resolve: context => authorsRepository.GetAuthorAsync(context.Source.AuthorId)
                );
        }
    }
}
