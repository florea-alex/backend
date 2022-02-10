using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.CarteRepositories
{
    public interface ICarteRepository : IGenericRepository<Carte>
    {
        Task<List<Carte>> GetCartiSiDetaliiEdituri();
        public Task<Carte> GetById(int id);
        Task<List<Carte>> GetAllCarti();
    }
}
