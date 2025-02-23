using legos_api.Legos.Dtos;
using legos_api.Legos.Model1;

namespace legos_api.Legos.Repositorys
{
    public interface ILegoRepo
    {
        Task<LegoResponse> CreateLegoAsync(LegoRequest legoReq);

        Task<List<Lego>> GetLegosAsync();
    }
}
