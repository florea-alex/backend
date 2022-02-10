using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;
        public AutorController(IAutorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getAutori")]
        public async Task<IActionResult> GetAll()
        {
            var autori = await _repository.GetAllAutori();

            var autoriToReturn = new List<AutorDTO>();

            foreach (var autor in autori)
            {
                autoriToReturn.Add(new AutorDTO(autor));
            }

            return Ok(autoriToReturn);
        }

        [HttpGet("getAutorById{id}")]
        public async Task<IActionResult> GetAutorById(int id)
        {
            var autor = await _repository.GetByIdDupaNume(id);

            return Ok(new AutorDTO(autor));
        }

        [HttpGet("getByPrenume{prenume}")]

        public async Task<IActionResult> GetPrenume(string prenume)
        {
            var autor = await _repository.GetByPrenume(prenume);

            return Ok(autor);
        }

        [HttpDelete("deleteAutori{id}")]
        public async Task<IActionResult> DeleteAutor(int id)
        {
            var autor = await _repository.GetByIdAsync(id);

            if (autor == null)
            {
                return NotFound("Autorul nu exista!");
            }

            _repository.Delete(autor);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createAutor")]
        public async Task<IActionResult> CreateAutor(CreateAutorDTO dto)
        {
            Autor newAutor = new Autor();
            
            newAutor.Id = dto.Id;
            newAutor.Nume = dto.Nume;
            newAutor.Prenume = dto.Prenume;
            newAutor.CarteAutori = dto.CarteAutori;
            newAutor.Biografie = dto.Biografie;

            _repository.Create(newAutor);

            await _repository.SaveAsync();

            return Ok(new AutorDTO(newAutor));
        }
    }
}
