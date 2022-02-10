using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Editura
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Cod_postal { get; set; }
        public int CarteId { get; set; }
        public virtual ICollection<Carte> Carti { get; set; }
    }
}
