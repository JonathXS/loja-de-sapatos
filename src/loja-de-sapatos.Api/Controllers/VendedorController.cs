using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using loja_de_sapatos.Api.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using loja_de_sapatos.Api.Domain.Entities;
using System.Reflection.Metadata;
using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Interfaces.Services;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _service;

        public VendedorController(IVendedorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Vendedor>>> BuscarVendedores()
        {
            return Ok();
        }


        [HttpGet("id")]
        //[HttpGet("id:int")]
        //[HttpGet(), Route("id")]
        public async Task<ActionResult<Vendedor>> BuscarVendedor(int id)
        {
            var response = await _service.GetVendedor(id);
            return Ok(response);
        }
        [HttpPost]
        public async Task<ActionResult> CriarVendedor(CreateVendedorDTO request)
        {
            await _service.InsertVendedor(request);
            return Created(string.Empty, null);
        }



        
            
        
        
    }
}
