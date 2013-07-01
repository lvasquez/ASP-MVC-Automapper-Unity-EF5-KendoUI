using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataModel;
using AutoMapper;
using MvcSample.Models;


namespace MvcSample.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Categories, CategoriesViewModel>();
        }
    }
}