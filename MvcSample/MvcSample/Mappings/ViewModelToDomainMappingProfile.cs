using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using DataModel;
using MvcSample.Models;


namespace MvcSample.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoriesViewModel, Categories>();
        }
    }
}