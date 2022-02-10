using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.CreateDTO
{
    public class CreateCarteDTO
    {
        public int Id { get; set; }
        public int ISBN { get; set; }
        public string Nume { get; set; }

        public int DescriereId { get; set; }
        public virtual Descriere Descriere { get; set; }
        public virtual Editura Editura { get; set; }
        public virtual ICollection<CarteAutor> CarteAutori { get; set; }
        public virtual ICollection<CarteMagazin> CarteMagazine { get; set; }
    }
}
