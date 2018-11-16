using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Collections.Generic;
using SjeApi.Models;
using SjeApi.Interfaces.DataAccess;

namespace SjeApi.DataAccess
{
    public class ProductsDbContext:IProductsDbContext {
        public DataAccessSettings ProductsRepository { get; set; }
        
        public ProductsDbContext(){
            ProductsRepository=new DataAccessSettings("productsdb");
        }

        public IEnumerable<Product> GetProducts()
        {
            return ProductsRepository._db.GetCollection<Product>("Products").FindAll();
        }
 
 
        public Product GetProduct(int productID,string name="")
        {
            var res = Query.And(
                        Query<Product>.EQ(p=>p.ProductID,productID),
                        Query<Product>.EQ(e =>e.ProductName,name.ToLower())
                    );
            return ProductsRepository._db.GetCollection<Product>("Products").FindOne(res);
        }
 
        public Product Create(Product p)
        {
            ProductsRepository._db.GetCollection<User>("Products").Save(p);
            return p;
        }
 
        public void Update(int productID,Product p)
        {
            p.ProductID = productID;
            var res = Query<Product>.EQ(pd => pd.ProductID,productID);
            var operation = Update<Product>.Replace(p);
            ProductsRepository._db.GetCollection<User>("Products").Update(res,operation);
        }
        public void Remove(int productID)
        {
            var res = Query<Product>.EQ(e => e.ProductID, productID);
            var operation = ProductsRepository._db.GetCollection<User>("Products").Remove(res);
        }
    }
}


