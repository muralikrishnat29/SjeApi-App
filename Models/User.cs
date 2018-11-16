using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace SjeApi.Models
{
    public class User{
        public ObjectId Id { get; set; }
        [BsonElement("UserID")]
        public int UserID { get; set; }
        [BsonElement("UserName")]
        public string UserName { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("FirstName")]
        public string FirstName { get; set; }
        [BsonElement("LastName")]
        public string LastName { get; set; }
        [BsonElement("Password")]
        public string Password { get; set; }
        [BsonElement("Roles")]
        public List<Role> Roles { get; set; }
    }

    public class Role{
        [BsonElement("RoleID")]
        public int RoleID { get; set; }
        [BsonElement("RoleName")]
        public string RoleName { get; set; }
    }
}