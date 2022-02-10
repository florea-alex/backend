using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class CarteAutor
    {
        public int Id { get; set; }
        public int CarteID { get; set; }
        public int AutorId { get; set; }
        public virtual Carte Carte { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
