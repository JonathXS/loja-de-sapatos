using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using loja_de_sapatos.Api.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<Vendedor>> BuscarVendedor()
        {
            return Ok();
        }
        
            
        
        
    }
}
