using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.MagazinRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagazinController : ControllerBase
    {
        private readonly IMagazinRepository _repository;
        public MagazinController(IMagazinRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getMagazine")]
        public async Task<IActionResult> GetAll()
        {
            var magazine = await _repository.GetAllMagazine();

            var magazineToReturn = new List<MagazinDTO>();

            foreach (var magazin in magazine)
            {
                magazineToReturn.Add(new MagazinDTO(magazin));
            }

            return Ok(magazineToReturn);
        }

        [HttpGet("getMagazinById{id}")]
        public async Task<IActionResult> GetMagazinById(int id)
        {
            var magazin = await _repository.GetById(id);

            return Ok(new MagazinDTO(magazin));
        }


        [HttpDelete("deleteMagazin{id}")]
        public async Task<IActionResult> DeleteMagazin(int id)
        {
            var magazin = await _repository.GetByIdAsync(id);

            if (magazin == null)
            {
                return NotFound("Magazinul nu exista!");
            }

            _repository.Delete(magazin);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createMagazin")]
        public async Task<IActionResult> CreateMagazin(CreateMagazinDTO dto)
        {
            Magazin newMagazin = new Magazin();

            newMagazin.Id = dto.Id;
            newMagazin.Adresa = dto.Adresa;
            newMagazin.Cod_postal = dto.Cod_postal;
            newMagazin.AngajatId = dto.AngajatId;
            newMagazin.CarteMagazine =dto.CarteMagazine;
            newMagazin.Angajati = dto.Angajati;

            _repository.Create(newMagazin);

            await _repository.SaveAsync();

            return Ok(new MagazinDTO(newMagazin));
        }
    }
}
