using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.FacturaRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaRepository _repository;
        public FacturaController(IFacturaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getFacturi")]
        public async Task<IActionResult> GetAll()
        {
            var facturi = await _repository.GetAllFacturi();

            var facturiToReturn = new List<FacturaDTO>();

            foreach (var factura in facturi)
            {
                facturiToReturn.Add(new FacturaDTO(factura));
            }

            return Ok(facturiToReturn);
        }

        [HttpGet("getFacturaById{id}")]
        public async Task<IActionResult> GetFacturaById(int id)
        {
            var factura = await _repository.GetById(id);

            return Ok(new FacturaDTO(factura));
        }

        [HttpDelete("deleteFactura{id}")]
        public async Task<IActionResult> DeleteFactura(int id)
        {
            var factura = await _repository.GetByIdAsync(id);

            if (factura == null)
            {
                return NotFound("Factura nu exista!");
            }

            _repository.Delete(factura);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createFactura")]
        public async Task<IActionResult> CreateFactura(CreateFacturaDTO dto)
        {
            Factura newFactura = new Factura();

            newFactura.Id = dto.Id;
            newFactura.Data_factura = dto.Data_factura;
            newFactura.Angajat = dto.Angajat;
            newFactura.Client = dto.Client;

            _repository.Create(newFactura);

            await _repository.SaveAsync();

            return Ok(new FacturaDTO(newFactura));
        }
    }
}
