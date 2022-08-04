using Authentication.API.Models.ModelsDto;
using Authentication.API.Repository.Entity;
using AutoMapper;

namespace Authentication.API.Helpers
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration()
        {
            CreateMap<Account, AccountDto>();
        }
    }
}
