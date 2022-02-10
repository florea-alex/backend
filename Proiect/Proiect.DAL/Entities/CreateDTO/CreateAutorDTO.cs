using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.CreateDTO
{
    public class CreateAutorDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public virtual ICollection<CarteAutor> CarteAutori { get; set; }
        public virtual Biografie Biografie { get; set; }
    }
}
