using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleService _service;

        public SaleController(ISaleService service)
        {
            _service = service;
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteSale (int id, CancellationToken cancellationToken)
        {
            await _service.DeleteSale(id, cancellationToken);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetSales (CancellationToken cancellationToken)
        {
            var sales = await _service.GetSales(cancellationToken);
            return Ok(sales);
        }

        [HttpGet("id")]
        public async Task<ActionResult> GetSale (int id, CancellationToken cancellationToken)
        {
            var sale = await _service.GetSale(id, cancellationToken);
            return Ok(sale);
        }

        [HttpPost]
        public async Task<ActionResult> InsertSale (CreateSaleDTO sale, CancellationToken cancellationToken)
        {
            var response = await _service.InsetSale(sale, cancellationToken);
            if(!response) return BadRequest();
            return Ok();
        }
    }
}
