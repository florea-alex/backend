using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.FacturaRepository
{
    public interface IFacturaRepository : IGenericRepository<Factura>
    {
        public Task<Factura> GetById(int id);
        Task<List<Factura>> GetAllFacturi();
    }
}
