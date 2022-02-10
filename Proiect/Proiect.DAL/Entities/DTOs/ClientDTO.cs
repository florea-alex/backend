using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class ClientDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public int FacturaId { get; set; }
        public List<Factura> Facturi { get; set; }
        public ClientDTO(Client client)
        {
            this.Id = client.Id;
            this.Nume = client.Nume;
            this.Prenume = client.Prenume;
            this.CNP = client.CNP;
            this.FacturaId = client.FacturaId;
            this.Facturi = new List<Factura>();
        }
    }
}
