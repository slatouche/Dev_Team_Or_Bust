using AutoMapper;
using WebApi_EF_Test.DTOs;
using WebApi_EF_Test.Models;

namespace WebApi_EF_Test.Profiles
{
    public class TestModelsProfile : Profile
    {
        public TestModelsProfile()
        {
            // Source -> Target
            CreateMap<TestModel, TestModelReadDTO>();
            CreateMap<TestModelCreateDTO, TestModel>();
            CreateMap<TestModelUpdateDTO, TestModel>();
        }
    }
}