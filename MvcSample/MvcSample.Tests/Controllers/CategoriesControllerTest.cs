using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcSample.Controllers;
using DataModel;
using System.Web.Mvc;
using RepositoryServices.IServices;
using Rhino.Mocks;


namespace MvcSample.Tests.Controllers
{
    /// <summary>
    /// Summary description for CategoriesControllerTest
    /// </summary>
    [TestClass]
    public class CategoriesControllerTest
    {
        
        private ICategoriesServices _categoriesServices;
        private CategoriesController _controller;

        [TestInitialize]
        public void Setup()
        {
            _categoriesServices = MockRepository.GenerateMock<ICategoriesServices>();
            _controller = new CategoriesController(_categoriesServices);
        }

        [TestMethod]
        public void GetIndex()
        {

            _categoriesServices.Stub(x => x.GetAll()).Return(null);

            var result = _controller.Index();

            _categoriesServices.AssertWasCalled(x => x.GetAll());

            Assert.IsInstanceOfType(result, typeof(ViewResult));
            
        }

    }
}
