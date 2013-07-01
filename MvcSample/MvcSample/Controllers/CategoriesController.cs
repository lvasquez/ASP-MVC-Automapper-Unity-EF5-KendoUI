using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryServices.IServices;
using DataModel;
using AutoMapper;
using MvcSample.Models;


namespace MvcSample.Controllers
{
    public class CategoriesController : Controller
    {
        readonly ICategoriesServices _categoriesServices;

        public CategoriesController(ICategoriesServices categoriesServices) {
        
            _categoriesServices = categoriesServices;
        }
        //
        // GET: /Categories/
        
        public ActionResult Index()
        {
            var dm = this._categoriesServices.GetAll();
            IList<CategoriesViewModel> vm = Mapper.Map<IList<Categories>, IList<CategoriesViewModel>>(dm);
            return View(vm);
        }

        public ActionResult Create()
        {

            return View(new CategoriesViewModel());
        }

        [HttpPost]
        public ActionResult Create(CategoriesViewModel vm)
        {
            if (ModelState.IsValid)
            {
            var dm = Mapper.Map<CategoriesViewModel, Categories>(vm);
            this._categoriesServices.Add(dm);
            return RedirectToAction("Index");
            }

            return View(vm);
        }

        public ActionResult Edit(int id)
        {
            var dm = this._categoriesServices.Get(id);

            if (dm == null)
                return HttpNotFound();
            var vm = Mapper.Map<Categories, CategoriesViewModel>(dm);
            return View(vm);
        }

        [HttpPost]
        public ActionResult Edit(CategoriesViewModel vm)
        {

            if (ModelState.IsValid)
            {
                var dm = Mapper.Map<CategoriesViewModel, Categories>(vm);
                this._categoriesServices.Update(dm);
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        public ActionResult Details(int id)
        {

            var dm = this._categoriesServices.Get(id);

            if (dm == null)
                return HttpNotFound();
            var vm = Mapper.Map<Categories, CategoriesViewModel>(dm);
            return View(vm);
        }


        public ActionResult Delete(int id = 0)
        {
            var dm = this._categoriesServices.Get(id);

            if (dm == null)
                return HttpNotFound();
            var vm = Mapper.Map<Categories, CategoriesViewModel>(dm);
            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            this._categoriesServices.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
