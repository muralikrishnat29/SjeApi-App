using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using SjeApi.Models;
using SjeApi.Interfaces.DataAccess;

namespace SjeApi.DataAccess
{
    public class UsersDbContext:IUsersDbContext {
        public DataAccessSettings UsersRepository { get; set; }
        
        public UsersDbContext(){
            UsersRepository=new DataAccessSettings("usersdb");
        }

        public IEnumerable<User> GetUsers()
        {
            return UsersRepository._db.GetCollection<User>("Users").FindAll();
        }
 
 
        public User GetUser(string userName,string password)
        {
            var res = Query.And(
                        Query<User>.EQ(p=>p.UserName,userName.ToLower()),
                        Query<User>.EQ(e => e.Password, password)
                    );
            return UsersRepository._db.GetCollection<User>("Users").FindOne(res);
        }
 
        public User Create(User p)
        {
            UsersRepository._db.GetCollection<User>("Users").Save(p);
            return p;
        }
 
        public void Update(int userId,User p)
        {
            p.UserID = userId;
            var res = Query<User>.EQ(pd => pd.UserID,userId);
            var operation = Update<User>.Replace(p);
            UsersRepository._db.GetCollection<User>("Users").Update(res,operation);
        }
        public void Remove(int userId)
        {
            var res = Query<User>.EQ(e => e.UserID, userId);
            var operation = UsersRepository._db.GetCollection<User>("Users").Remove(res);
        }
    }
}


