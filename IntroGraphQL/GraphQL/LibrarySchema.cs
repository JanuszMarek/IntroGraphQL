using GraphQL;
using GraphQL.Types;

namespace IntroGraphQL.GraphQL
{
    public class LibrarySchema : Schema
    {
        public LibrarySchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<LibraryQuery>();
        }
    }
}
