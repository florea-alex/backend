using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.CarteRepositories
{
    public class CarteRepository : GenericRepository<Carte>, ICarteRepository
    {
        public CarteRepository(AppDbContext context) : base(context) { }

        public async Task<List<Carte>> GetCartiSiDetaliiEdituri()
        {
            return await _context.Carti.Include(x => x.Editura).ToListAsync();
        }

        public async Task<Carte> GetById(int id)
        {
            return await _context.Carti.Where(a => a.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<Carte>> GetAllCarti()
        {
            return await _context.Carti.ToListAsync();
        }
    }
}
