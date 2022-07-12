using AutoMapper;
using BlogProject_5175_06062022.Models.Concrete;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.DTOs;
using BlogProject_5175_06062022.WEB.Areas.Member.Models.VMs;
using BlogProject_5175_06062022.WEB.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject_5175_06062022.WEB.Models.Mappers
{
    public class Mapping : Profile
    {
        // MAPPER kütüphanesine yaptırmak istediğiniz mapleme işlemlerini burada tek tek  söylemeniz gerekiyor
        // StartUp'a gitmeden bu sınfı oluşturduk çünkü orada bize hangi sınıfta mapleme yapıyorsun diye sorucaktır.

        public Mapping()
        {
            // ReverseMap() iki yönlü çalışır. AppUser => CreateUserDTO
            //                                    CreateUserDTO => AppUser
            CreateMap<AppUser, CreateUserDTO>().ReverseMap();
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
            CreateMap<Category, UpdateCategoryDTO>().ReverseMap();
            CreateMap<Article, CreateArticleDTO>().ReverseMap();
            CreateMap<Article, UpdateArticleDTO>().ReverseMap();
            CreateMap<AppUser, GetAppUserVM>().ReverseMap();
        }
    }
}
