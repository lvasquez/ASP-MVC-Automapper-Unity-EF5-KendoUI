using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepositoryServices.IServices;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using DataModel;

namespace MvcSample.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        readonly IProductsServices _productsServices;

        public ProductsController(IProductsServices productsServices) {

            _productsServices = productsServices;
        }

        public ActionResult Index()
        {
            //var products = this._productsServices.GetAll();
            return View();
        }

        public ActionResult GetAll([DataSourceRequest] DataSourceRequest request)
        {
            var products = this._productsServices.GetAll();
            return Json(products.ToList().ToDataSourceResult(request));
        }

    }
}
