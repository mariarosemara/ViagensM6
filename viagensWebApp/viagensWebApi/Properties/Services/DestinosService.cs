using ViagensWebApi.Context;
using ViagensWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ViagensWebApi.Services
{
    public class DestinosServiceBase : IDestinoService
    {
        private readonly AppDbContext _context;

        public DestinosServiceBase(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateDestino(Destino destino)
        {
            _context.Destinos.Add(destino);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Destino>> GetDestinos()
        {
            try
            {
                return await _context.Destinos.ToListAsync();
            }
            catch
            {

                throw;
            }
            
        }
    }
}
