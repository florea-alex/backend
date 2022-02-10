using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Descriere
    {
        public int Id { get; set; }
        public decimal Pret { get; set; }
        public decimal? Nota { get; set; }
        public int? Recomandare { get; set; }
        public int An_aparitie { get; set; }
        public int Volum { get; set; }
        public string Gen_principal { get; set; }
        public virtual Carte Carte { get; set; }
    }
}
