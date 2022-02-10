using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public virtual ICollection<CarteAutor> CarteAutori { get; set; }
        public virtual Biografie Biografie { get; set; }

    }
}
