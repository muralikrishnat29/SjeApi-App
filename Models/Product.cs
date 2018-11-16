using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace SjeApi.Models
{
    public class Product{
        public ObjectId Id { get; set; }
        [BsonElement("ProductID")]
        public int ProductID { get; set; }
        [BsonElement("ProductName")]
        public string ProductName { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("PricePerPiece")]
        public int Price { get; set; }
        [BsonElement("QuantityAvailable")]
        public int QuantityAvailable { get; set; }
        [BsonElement("MinQuantity")]
        public int MinQuantity { get; set; }
        [BsonElement("Categories")]
        public List<Category> Categories { get; set; }
    }

    public class Category{
        [BsonElement("CategoryID")]
        public int CategoryID { get; set; }
        [BsonElement("CategoryName")]
        public string CategoryName { get; set; }
    }
}