using AutoMapper;
using DatingApp.DbObjects;
using DatingApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                });
            //.ForMember(dest => dest.Age, opt =>
            //{
            //    opt.ResolveUsing(d => d.DateOfBirth.calculateAge());
            //});

            CreateMap<User, UserForDetailedDto>()
                .ForMember(dest => dest.PhotoUrl, opt =>
            {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
            });
            //    .ForMember(dest => dest.Age, opt =>
            //{
            //    opt.ResolveUsing(d => d.DateOfBirth.calculateAge());
            //});
            CreateMap<Photo, PhotosForDetailedDto>();
        }
    }
}
