using GraphQL;
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace IntroGraphQL.GraphQL
{
    public class LibrarySchema : Schema
    {
        public LibrarySchema(IServiceProvider service): base(service)
        {
            Query = service.GetRequiredService<LibraryQuery>();
        }
    }
}
