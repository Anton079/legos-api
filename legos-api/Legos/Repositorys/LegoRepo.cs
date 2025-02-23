using AutoMapper;
using legos_api.Data.Migrations;
using legos_api.Legos.Dtos;
using legos_api.Legos.Model1;
using Microsoft.EntityFrameworkCore;

namespace legos_api.Legos.Repositorys
{
    public class LegoRepo : ILegoRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public LegoRepo(AppDbContext appDbContext, IMapper mapper)
        {
            this._appDbContext = appDbContext;
            this._mapper = mapper;
        }

        public async Task<LegoResponse> CreateLegoAsync(LegoRequest legoReq)
        {
            Lego lego = _mapper.Map<Lego>(legoReq);

            _appDbContext.Legos.Add(lego);

            await _appDbContext.SaveChangesAsync();

            LegoResponse response = _mapper.Map<LegoResponse>(lego);

            return response;
        }

        public async Task<List<Lego>> GetLegosAsync()
        {
            return await _appDbContext.Legos.ToListAsync();
        }
    }
}
