using GraphQL.Types;
using IntroGraphQL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroGraphQL.GraphQL.Types
{
    public class AuthorType : ObjectGraphType<Author>
    {
        public AuthorType()
        {
            Field(t => t.Id);
            Field(t => t.FirstName);
            Field(t => t.LastName);
            Field(t => t.FullName);
        }
    }
}
