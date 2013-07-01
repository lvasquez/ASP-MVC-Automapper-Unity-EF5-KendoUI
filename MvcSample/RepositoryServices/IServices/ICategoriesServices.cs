using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataModel;

namespace RepositoryServices.IServices
{
    public interface ICategoriesServices
    {
        IList<Categories> GetAll();

        Categories Add(Categories categories);

        Categories Get(int id);

        Categories Update(Categories categories);

        Categories Delete(int id);
    }
}
