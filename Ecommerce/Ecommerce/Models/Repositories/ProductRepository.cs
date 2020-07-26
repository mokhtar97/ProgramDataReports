using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models.Repositories
{
    public class ProductRepository : BaseRepository,IStore<Product>
    {
        
        public void ADD(Product Model)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                con.Open();
                con.Execute("insert into Products values (@Name,@Price)", new { Model.Name , Model.Price });

            }
            catch (Exception ex)
            {

                throw ex;
            }
       
        }

        public void Delete(int id)
        {
            con.Execute("delete from Products where id=@ID", new { id });
        }
       
        

        public Product Find(int? id)
        {
            var query = @"
                   SELECT 
                       id
                      ,Name
                      ,Price
                  FROM Products where id=@ID ";

            var product = con.Query<Product>(query,new { Id=id}).FirstOrDefault();
            return product;
        }

        public List<Product> List()
        {
                var query = @"
                   SELECT 
                       id
                      ,Name
                      ,Price
                  FROM Products";

            var products = con.Query<Product>(query).ToList();
            return products;
        }

        public void Update(int id, Product Model)
        {
            con.Execute("update Products set Name = @Name,Price=@Price where Id = @id", new { Model.Name, Model.Price, id = 1 });
        }
    }
}
