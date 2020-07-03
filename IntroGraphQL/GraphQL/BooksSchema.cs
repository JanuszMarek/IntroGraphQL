using GraphQL;
using GraphQL.Types;
using IntroGraphQL.GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL
{
    public class BooksSchema : Schema
    {
        public BooksSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<BooksQuery>();
        }
    }
}
