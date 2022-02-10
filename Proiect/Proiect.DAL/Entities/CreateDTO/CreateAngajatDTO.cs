using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.CreateDTO
{
    public class CreateAngajatDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Job { get; set; }
        public int FacturaId { get; set; }
        public virtual Magazin Magazin { get; set; }
        public virtual ICollection<Factura> Facturi { get; set; }
    }
}
