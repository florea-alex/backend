using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.EdituraRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EdituraController : ControllerBase
    {
        private readonly IEdituraRepository _repository;
        public EdituraController(IEdituraRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getEdituri")]
        public async Task<IActionResult> GetAll()
        {
            var edituri = await _repository.GetAllEdituri();

            var edituriToReturn = new List<EdituraDTO>();

            foreach (var editura in edituri)
            {
                edituriToReturn.Add(new AutorDTO(editura));
            }

            return Ok(edituriToReturn);
        }

        [HttpGet("getEdituraById{id}")]
        public async Task<IActionResult> GetEdituraById(int id)
        {
            var editura = await _repository.GetByIdSiDenumire(id);

            return Ok(new EdituraDTO(editura));
        }

        [HttpDelete("deleteEditura{id}")]
        public async Task<IActionResult> DeleteEditura(int id)
        {
            var editura = await _repository.GetByIdAsync(id);

            if (editura == null)
            {
                return NotFound("Editura nu exista!");
            }

            _repository.Delete(editura);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createEditura")]
        public async Task<IActionResult> CreateEditura(CreateEdituraDTO dto)
        {
            Editura newEditura = new Editura();

            newEditura.Id = dto.Id;
            newEditura.Denumire = dto.Denumire;
            newEditura.Adresa = dto.Adresa;
            newEditura.Telefon = dto.Telefon;
            newEditura.Cod_postal = dto.Cod_postal;
            newEditura.CarteId = dto.CarteId;
            newEditura.Carti = dto.Carti;

            _repository.Create(newEditura);

            await _repository.SaveAsync();

            return Ok(new EdituraDTO(newEditura));
        }
    }
}
