using ViagensWebApi.Models;

namespace AgenciaWebApi.Services
{
    public interface IDestinoService
    {
        Task<IEnumerable<Destino>> GetDestinos();

        Task CreateDestino(Destino destino);
    }
}
