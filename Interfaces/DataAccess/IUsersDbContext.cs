using System.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SjeApi.Models;

namespace SjeApi.Interfaces.DataAccess{

    public interface IUsersDbContext
    {
       IEnumerable<User> GetUsers();
       User GetUser(string userName,string password="");
       User Create(User p);
       void Update(int userId,User p);
       void Remove(int userId);
    }
}