using GraphQL.Types;
using IntroGraphQL.GraphQL.Types;
using IntroGraphQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL.Queries
{
    public class BooksQuery: ObjectGraphType
    {
        public BooksQuery(BooksRepository booksRepository)
        {
            Field<ListGraphType<BookType>>(
                "books",
                resolve: context => booksRepository.GetAllAsync());

            Field<BookType>(
                "book",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<long>("id");
                    return booksRepository.GetById(id);
                });
        }
    }
}
