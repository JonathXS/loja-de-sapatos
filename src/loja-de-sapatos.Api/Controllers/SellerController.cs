using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using loja_de_sapatos.Api.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using loja_de_sapatos.Api.Domain.Entities;
using System.Reflection.Metadata;
using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using loja_de_sapatos.Api.Domain.DTO.Response;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        private readonly ISellerService _service;

        public SellerController(ISellerService service)
        {
            _service = service;
        }

        [HttpPut("id")]
        public async Task<ActionResult> UpdateSeller(int id, [FromBody] UpdateSellerDTO updateSeller, CancellationToken cancellationToken)
        {
            updateSeller.Id = id;
            await _service.UpdateSeller(updateSeller, cancellationToken);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteSeller(int id, CancellationToken cancellationToken)
        {
            await _service.DeleteSeller(id, cancellationToken);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<SellerResponse>>> GetSellers(CancellationToken cancellationToken)
        {
            var sellers = await _service.GetSellers(cancellationToken);
            return Ok(sellers);
        }


        [HttpGet("id")]
        //[HttpGet("id:int")]
        //[HttpGet(), Route("id")]
        public async Task<ActionResult<SellerResponse>> GetSeller(int id, CancellationToken cancellationToken)
        {
            var response = await _service.GetSeller(id, cancellationToken);
            return Ok(response);
        }

        [HttpPost] 
        public async Task<ActionResult> InsertSeller(CreateSellerDTO request, CancellationToken cancellationToken)
        {
            await _service.InsertSeller(request, cancellationToken);
            return Created(string.Empty, null);
        }

    }
}
