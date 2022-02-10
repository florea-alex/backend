using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.CarteRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarteController : ControllerBase
    {
        private readonly ICarteRepository _repository;
        public CarteController(ICarteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getCarti")]
        public async Task<IActionResult> GetAll()
        {
            var carti = await _repository.GetAllCarti();

            var cartiToReturn = new List<CarteDTO>();

            foreach (var carte in carti)
            {
                cartiToReturn.Add(new CarteDTO(carte));
            }

            return Ok(cartiToReturn);
        }

        [HttpGet("join-Carti-Edituri")]
       
        public async Task<IActionResult> JoinCartiEdituri()
        {
            var detalii = await _repository.GetCartiSiDetaliiEdituri();

            return Ok(detalii);
        }

        [HttpGet("getCarteById{id}")]
        public async Task<IActionResult> GetCarteById(int id)
        {
            var carte = await _repository.GetById(id);

            return Ok(new CarteDTO(carte));
        }

        [HttpDelete("deleteCarte{id}")]
        public async Task<IActionResult> DeleteCarte(int id)
        {
            var carte = await _repository.GetByIdAsync(id);

            if (carte == null)
            {
                return NotFound("Cartea nu exista!");
            }

            _repository.Delete(carte);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createCarte")]
        public async Task<IActionResult> CreateCarte(CreateCarteDTO dto)
        {
            Carte newCarte = new Carte();

            newCarte.Id = dto.Id;
            newCarte.ISBN = dto.ISBN;
            newCarte.Nume = dto.Nume;
            newCarte.DescriereId = dto.DescriereId;
            newCarte.Descriere = dto.Descriere;
            newCarte.Editura = dto.Editura;
            newCarte.CarteAutori = dto.CarteAutori;
            newCarte.CarteMagazine = dto.CarteMagazine;

            _repository.Create(newCarte);

            await _repository.SaveAsync();

            return Ok(new CarteDTO(newCarte));
        }
    }
}
