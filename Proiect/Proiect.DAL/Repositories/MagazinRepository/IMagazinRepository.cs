using Proiect.DAL.Entities;
using Proiect.DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.MagazinRepository
{
    public interface IMagazinRepository : IGenericRepository<Magazin>
    {
        public Task<Magazin> GetById(int id);
        Task<List<Magazin>> GetAllMagazine();
    }
}
