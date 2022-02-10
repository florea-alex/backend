using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class AngajatDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Job { get; set; }
        public int FacturaId { get; set; }
        public Magazin Magazin { get; set; }
        public List<Factura> Facturi { get; set; }
        public AngajatDTO(Angajat angajat)
        {
            this.Id = angajat.Id;
            this.Nume = angajat.Nume;
            this.Prenume = angajat.Prenume;
            this.Job = angajat.Job;
            this.FacturaId = angajat.FacturaId;
            this.Magazin = angajat.Magazin;
            this.Facturi = new List<Factura>();
        }
    }
}
