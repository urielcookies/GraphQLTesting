using System;
using GraphQLTesting.Query;

namespace GraphQLTesting.Schema
{
    public class UserAccountsSchema : GraphQL.Types.Schema
    {
        public UserAccountsSchema(UserAccountsQuery userAccountsQuery)
        {
            Query = userAccountsQuery;
        }
    }
}
