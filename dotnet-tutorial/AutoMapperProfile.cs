using System;
using AutoMapper;
using dotnet_tutorial.Dtos.Character;
using dotnet_tutorial.Models;

namespace dotnet_tutorial
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
