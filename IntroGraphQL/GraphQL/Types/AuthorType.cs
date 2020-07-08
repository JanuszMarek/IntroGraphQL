using GraphQL.DataLoader;
using GraphQL.Types;
using IntroGraphQL.Entities;
using IntroGraphQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType(BooksRepository booksRepository, IDataLoaderContextAccessor dataLoader)
        {
            Field(t => t.Id);
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.FullName);
            Field<ListGraphType<BookType>>(
                "books",
                resolve: context => {
                    var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<long, Book>("GetBooksByAuthorAsync", booksRepository.GetBooksByAuthorAsync);
                    return loader.LoadAsync(context.Source.Id);
                    });
        }
    }
}
