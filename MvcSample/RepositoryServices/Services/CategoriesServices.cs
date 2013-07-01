using DataModel;
using RepositoryServices.IServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryServices.Services
{
    public class CategoriesServices : ICategoriesServices
    {

        public IList<Categories> GetAll() {

            using (var context = new NorthwindEntities())
            {
                return context.Categories.ToList();
            }
        }

        public Categories Add(Categories categories) {

            if (categories == null)
            {
                throw new ArgumentNullException("categories");
            }
            using (var context = new NorthwindEntities())
            {
                context.Categories.Add(categories);
                context.SaveChanges();
                return categories;
            }
        }

        public Categories Get(int id) {

            using (var context = new NorthwindEntities())
            {
                Categories categories = context.Categories.Find(id);
                return categories;
            }
        
        }

        public Categories Update(Categories categories) {

            if (categories == null)
            {
                throw new ArgumentNullException("categories");
            }
            using (var context = new NorthwindEntities())
            {
                context.Entry(categories).State = EntityState.Modified;
                context.SaveChanges();
                return categories;
            }
        
        }

        public Categories Delete(int id) {

            using (var context = new NorthwindEntities())
            {
                Categories categories = context.Categories.Find(id);
                context.Categories.Remove(categories);
                context.SaveChanges();
                return categories;
            }
        }


    }
}
