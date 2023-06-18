using AutoMapper;
using BAYA.Core.DTOs;
using BAYA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AidNotice, AidNoticeDto>().ReverseMap();
            CreateMap<County, CountyDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<District, DistrictDto>().ReverseMap();
            CreateMap<HelpCenter, HelpCenterDto>().ReverseMap();
            CreateMap<Street, StreetDto>().ReverseMap();
            //CreateMap<SubCategory, SubCategoryDto>().ReverseMap();
           
        }
    }
}
