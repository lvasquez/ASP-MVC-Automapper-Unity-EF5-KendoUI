using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace RepositoryServices.IServices
{
    public interface IProductsServices
    {
        IList<Products> GetAll();
    }
}
