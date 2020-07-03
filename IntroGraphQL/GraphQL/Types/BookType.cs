using GraphQL.Types;
using IntroGraphQL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL.Types
{
    public class BookType : ObjectGraphType<Book>
    {
        public BookType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Description);
            Field(t => t.ReleaseDate);
        }
    }
}
