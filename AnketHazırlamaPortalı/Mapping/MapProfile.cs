using AnketHazırlamaPortalı.API.Dtos;
using AnketHazırlamaPortalı.API.Models;
using AnketHazırlamaPortalı.Dtos;
using AnketHazırlamaPortalı.Models;
using AutoMapper;

namespace AnketHazırlamaPortalı.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Survey, SurveyDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Question, QuestionDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<AppUser, UserDto>().ReverseMap();

        }
    }
}
