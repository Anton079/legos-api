using AutoMapper;
using legos_api.Legos.Dtos;
using legos_api.Legos.Model1;

namespace legos_api.Legos.Mapers
{
    public class LegoMappingProfile:Profile
    {
        public LegoMappingProfile()
        {
            CreateMap<LegoRequest, Lego>();
            CreateMap<Lego, LegoResponse>();
        }
    }
}
