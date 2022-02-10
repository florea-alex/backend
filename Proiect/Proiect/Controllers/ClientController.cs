using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.CreateDTO;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.ClientRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _repository;
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("getClienti")]
        public async Task<IActionResult> GetAll()
        {
            var clienti = await _repository.GetAllClienti();

            var clientiToReturn = new List<ClientDTO>();

            foreach (var client in clienti)
            {
                clientiToReturn.Add(new ClientDTO(client));
            }

            return Ok(clientiToReturn);
        }

        [HttpGet("getClientById{id}")]
        public async Task<IActionResult> GetClientById(int id)
        {
            var client = await _repository.GetById(id);

            return Ok(new ClientDTO(client));
        }

        [HttpGet("getFemei")]
        public async Task<IActionResult> GetFemei()
        {
            var femei = await _repository.GetFemeiClienti();

            var femeiToReturn = new List<ClientDTO>();

            foreach (var femeie in femei)
            {
                femeiToReturn.Add(new ClientDTO(femeie));
            }

            return Ok(femeiToReturn);
        }

        [HttpGet("getBarbati")]
        public async Task<IActionResult> GetBarbati()
        {
            var barbati = await _repository.GetBarbatiClienti();

            var barbatiToReturn = new List<ClientDTO>();

            foreach (var barbat in barbati)
            {
                barbatiToReturn.Add(new ClientDTO(barbat));
            }

            return Ok(barbatiToReturn);
        }

        [HttpDelete("deleteClient{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _repository.GetByIdAsync(id);

            if (client == null)
            {
                return NotFound("Clientul nu exista!");
            }

            _repository.Delete(client);

            await _repository.SaveAsync();

            return NoContent();
        }

        [HttpPost("createClient")]
        public async Task<IActionResult> CreateClient(CreateClientDTO dto)
        {
            Client newClient = new Client();

            newClient.Id = dto.Id;
            newClient.Nume = dto.Nume;
            newClient.Prenume = dto.Prenume;
            newClient.CNP = dto.CNP;
            newClient.FacturaId = dto.FacturaId;
            newClient.Facturi = dto.Facturi;

            _repository.Create(newClient);

            await _repository.SaveAsync();

            return Ok(new ClientDTO(newClient));
        }

        [HttpPut("UpdateForForm")]
        public async Task<IActionResult> UpdateAsync([FromBody] Client client)
        {
            var array_angajati = await _repository.GetClient();

            var angajatIndex = array_angajati.FindIndex((Client _angajat) => _angajat.Id.Equals(client.Id));

            array_angajati[angajatIndex] = client;

            return Ok(array_angajati);
        }

    }
}
