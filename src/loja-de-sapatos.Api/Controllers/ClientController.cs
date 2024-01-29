using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _service;

        public ClientController(IClientService service)
        {
            _service = service;
        }

        [HttpPut("id")]
        public async Task<ActionResult> UpdateClient(int id, [FromBody] UpdateClientDTO updateClient, CancellationToken cancellationToken)
        {
            updateClient.Id = id;
            await _service.UpdateClient(updateClient, cancellationToken);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteClient(int id, CancellationToken cancellationToken)
        {
            await _service.DeleteClient(id, cancellationToken);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<ClientResponse?>>> GetClients(CancellationToken cancellationToken)
        {
             var clients = await _service.GetClients(cancellationToken);
            return Ok(clients);
        }

        [HttpGet("id")]
        public async Task<ActionResult<ClientResponse>> GetClient(int id, CancellationToken cancellationToken)
        {
            var client = await _service.GetClient(id, cancellationToken);
            return Ok(client);
        }

        [HttpPost]
        public async Task<ActionResult> InsertClient(CreateClientDTO request, CancellationToken cancellationToken)
        {
            await _service.InsertClient(request, cancellationToken);
            return Created(string.Empty, null);
        }
    }
}
