using System.Configuration;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SjeApi.Models;

namespace SjeApi.Interfaces.DataAccess{

    public interface IProductsDbContext
    {
       IEnumerable<Product> GetProducts();
       Product GetProduct(int productID,string name="");
       Product Create(Product p);
       void Update(int productID,Product p);
       void Remove(int productID);
    }
}