using System;
using GraphQL;
using GraphQL.Types;
using GraphQLTesting.Interfaces;
using GraphQLTesting.Type;

namespace GraphQLTesting.Query
{
    public class UserAccountsQuery : ObjectGraphType
    {
        public UserAccountsQuery(IUserAccounts userAccounts)
        {
            Field<ListGraphType<UserAccountsType>>(
                "UserAcccounts",
                resolve: context => {
                    return userAccounts.GetAllUserAccounts();
                }
            );
            Field<UserAccountsType>(
                "UserAcccount",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
                resolve: context => {
                    return userAccounts.GetUserAccountById(context.GetArgument<int>("Id"));
                }
            );
        }
    }
}
