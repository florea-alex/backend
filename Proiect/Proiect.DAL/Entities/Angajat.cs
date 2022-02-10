using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities
{
    public class Angajat
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Job { get; set; }
        public int FacturaId { get; set; }
        public virtual Magazin Magazin { get; set; }
        public virtual ICollection<Factura> Facturi { get; set; }

        public IEnumerable<object> GetAng()
        {
            throw new NotImplementedException();
        }
    }
}
