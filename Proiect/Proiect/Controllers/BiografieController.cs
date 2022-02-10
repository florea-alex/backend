using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.BiografieRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BiografieController : ControllerBase
    {
        private readonly IBiografieRepository _repository;
        public BiografieController(IBiografieRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getBiografii")]
        public async Task<IActionResult> GetAll()
        {
            var bios = await _repository.GetAllBiografii();

            var bioToReturn = new List<BiografieDTO>();

            foreach (var bio in bios)
            {
                bioToReturn.Add(new BiografieDTO(bio));
            }

            return Ok(bioToReturn);
        }

        [HttpGet("getAnNastere{an_nastere}")]
        public async Task<IActionResult> GetAnNastere(int an_nastere)
        {
            var biografie = await _repository.GetByAnNastere(an_nastere);

            return Ok(biografie);
        }

        [HttpGet("getBiografieById{id}")]
        public async Task<IActionResult> GetBiografieById(int id)
        {
            var bio = await _repository.GetById(id);

            return Ok(new BiografieDTO(bio));
        }

        [HttpDelete("deleteBiografie{id}")]
        public async Task<IActionResult> DeleteBiografie(int id)
        {
            var biografie = await _repository.GetByIdAsync(id);

            if (biografie == null)
            {
                return NotFound("Biografia nu exista!");
            }

            _repository.Delete(biografie);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createBiografie")]
        public async Task<IActionResult> CreateAutor(CreateBiografieDTO dto)
        {
            Biografie newBio = new Biografie();

            newBio.Id = dto.Id;
            newBio.An_nastere = dto.An_nastere;
            newBio.Loc_nastere = dto.Loc_nastere;
            newBio.Nume_real = dto.Nume_real;
            newBio.Nationalitate = dto.Nationalitate;
            newBio.AutorId = dto.AutorId;
            newBio.Autor = dto.Autor;

            _repository.Create(newBio);

            await _repository.SaveAsync();

            return Ok(new BiografieDTO(newBio));
        }
    }
}
