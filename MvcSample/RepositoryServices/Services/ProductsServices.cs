using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using RepositoryServices.IServices;
using System.Data;
using System.Data.Entity;
using System.Data.Linq;



namespace RepositoryServices.Services
{
    public class ProductsServices : IProductsServices
    {
      
        public IList<Products> GetAll() {

            using (var context = new NorthwindEntities())
            {
                context.Configuration.ProxyCreationEnabled = false;
                var products = context.Products;
                return products.ToList();
            }
        }
    }
}
