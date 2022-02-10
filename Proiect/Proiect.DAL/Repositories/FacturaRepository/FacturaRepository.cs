using Microsoft.EntityFrameworkCore;
using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.FacturaRepository
{
    public class FacturaRepository : GenericRepository<Factura>, IFacturaRepository
    {
        public FacturaRepository(AppDbContext context) : base(context) { }
    public async Task<Factura> GetById(int id)
    {
        return await _context.Facturi.Where(a => a.Id == id).FirstOrDefaultAsync();
    }
        public async Task<List<Factura>> GetAllFacturi()
        {
            return await _context.Facturi.ToListAsync();
        }

    }
}
