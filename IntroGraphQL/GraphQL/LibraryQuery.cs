using GraphQL;
using GraphQL.Types;
using IntroGraphQL.GraphQL.Types;
using IntroGraphQL.Repositories;

namespace IntroGraphQL.GraphQL
{
    public class LibraryQuery : ObjectGraphType
    {
        public LibraryQuery(BooksRepository booksRepository, AuthorsRepository authorsRepository)
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

            Field<ListGraphType<AuthorType>>(
                "authors",
                resolve: context => authorsRepository.GetAuthorsAsync());

            Field<AuthorType>(
                "author",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }),
                resolve: context =>
                {
                    var id = context.GetArgument<long>("id");
                    return authorsRepository.GetAuthorById(id);
                });
        }
    }
}
