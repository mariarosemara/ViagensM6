using ViagensWebApi.Models;

namespace ViagensWebApi.Services
{
    public interface IDestinoService
    {
        Task<IEnumerable<Destino>> GetDestinos();

        Task CreateDestino(Destino destino);
    }
}
