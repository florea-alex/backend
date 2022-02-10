using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.AngajatRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AngajatController : ControllerBase
    {
        private readonly IAngajatRepository _repository;
        public AngajatController(IAngajatRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getAngajatById{id}")]
        public async Task<IActionResult> GetAngajatById(int id)
        {
            var angajat = await _repository.GetById(id);

            return Ok(new AngajatDTO(angajat));
        }

        [HttpGet("getAngajati{job}")]
        public async Task<IActionResult> GetAllAngajati(string job)
        {
            var angajati = await _repository.GetAllAngajatiDupaJob(job);

            var angajatiToReturn = new List<AngajatDTO>();

            foreach (var angajat in angajati)
            {
                angajatiToReturn.Add(new AngajatDTO(angajat));
            }

            return Ok(angajatiToReturn);
        }

        [HttpGet("getJob{id}")]
        public async Task<IActionResult> GetJobBy(int id)
        {
            var angajat = await _repository.GetJobById(id);

            return Ok(new AngajatDTO(angajat));
        }

        [HttpGet("getByPrenume{prenume}")]
        public async Task<IActionResult> GetAngajatCuPrenumeDat(string prenume)
        {
            var angajat = await _repository.GetByPrenume(prenume);

            return Ok(new AngajatDTO(angajat));
        }

        [HttpDelete("deleteAngajati{id}")]
        public async Task<IActionResult> DeleteAngajat(int id)
        {
            var angajat = await _repository.GetByIdAsync(id);

            if (angajat == null)
            {
                return NotFound("Angajatul nu exista!");
            }

            _repository.Delete(angajat);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createAngajat")]
        public async Task<IActionResult> CreateAngajat(CreateAngajatDTO dto)
        {
            Angajat newAngajat = new Angajat();

            newAngajat.Id = dto.Id;
            newAngajat.Nume = dto.Nume;
            newAngajat.Prenume = dto.Prenume;
            newAngajat.Job = dto.Job;
            newAngajat.FacturaId = dto.FacturaId;
            newAngajat.Magazin = dto.Magazin;
            newAngajat.Facturi = dto.Facturi;

            _repository.Create(newAngajat);

            await _repository.SaveAsync();

            return Ok(new AngajatDTO(newAngajat));
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var angajati = await _repository.GetAng();

            var angajatiToReturn = new List<AngajatDTO>();

            foreach (var angajat in angajati)
            {
                angajatiToReturn.Add(new AngajatDTO(angajat));
            }

            return Ok(angajatiToReturn);
        }


        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] Angajat angajat)
        {
            var array_angajati = await _repository.GetAng();

            var angajatIndex = array_angajati.FindIndex((Angajat _angajat) => _angajat.Id.Equals(angajat.Id));
            
            array_angajati[angajatIndex] = angajat;

            return Ok(array_angajati);
        }

        //[HttpPost("AddAngajat")]
        //public async Task<IActionResult> AddAngajat([FromBody] Angajat angajat)
        //{
        //    await _repository.Create(angajat);
        //    return Ok();
        //}



        //[HttpPut("UpdateAngajat")]
        //public bool UpdateAngajat(Angajat angajat)
        //{
        //    try
        //    {
        //        var DataList = angajat.GetAll().Where(x => x.IsDeleted != true).ToListAsync();
        //        foreach (var item in DataList)
        //        {
        //            angajat.Update(item);
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return true;
        //    }
        //}
    }
}
