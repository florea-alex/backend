using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Entities.DTOs
{
    public class FacturaDTO
    {
        public int Id { get; set; }
        public string Data_factura { get; set; }
        public Angajat Angajat { get; set; }
        public Client Client { get; set; }
        public FacturaDTO(Factura factura)
        {
            this.Id = factura.Id;
            this.Data_factura = factura.Data_factura;
            this.Angajat = factura.Angajat;
            this.Client = factura.Client;
        }
    }
}
