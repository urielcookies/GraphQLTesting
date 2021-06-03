using System;
using GraphQL.Types;
using GraphQLTesting.Models;

namespace GraphQLTesting.Type
{
    public class UserAccountsType : ObjectGraphType<UserAccounts>
    {
        public UserAccountsType()
        {
            Field(p => p.Id);
            Field(p => p.Username);
            Field(p => p.Password);
            Field(p => p.Email);
            Field(p => p.CreatedTime);
        }
    }
}
