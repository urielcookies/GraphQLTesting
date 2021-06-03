using System;
using System.Collections.Generic;
using GraphQLTesting.Models;

namespace GraphQLTesting.Interfaces
{
    public interface IUserAccounts
    {
        List<UserAccounts> GetAllUserAccounts();
        UserAccounts AddUserAccount(UserAccounts userAccounts);
        UserAccounts UpdateUserAccount(int id, UserAccounts userAccounts);
        void DeleteUserAccount(int id);
        UserAccounts GetUserAccountById(int id);
    }
}
