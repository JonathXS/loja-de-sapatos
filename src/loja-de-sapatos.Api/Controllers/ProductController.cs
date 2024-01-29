using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace loja_de_sapatos.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpPut("id")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] UpdateProductDTO updateProduct, CancellationToken cancellationToken)
        {
            updateProduct.Id = id;
            await _service.UpdateProduct(updateProduct, cancellationToken);
            return Ok();
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteProduct(int id, CancellationToken cancellationToken)
        {
            await _service.DeleteProduct(id, cancellationToken);
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<ProductResponse>> GetProducts(CancellationToken cancellationToken)
        {
            var products = await _service.GetProducts(cancellationToken);
            return Ok(products);
        }

        [HttpGet("id")]
        public async Task<ActionResult<ProductResponse>> GetProduct (int id, CancellationToken cancellationToken)
        {
            var product = await _service.GetProduct(id, cancellationToken);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult>  InsertProduct (CreateProductDTO request, CancellationToken cancellationToken)
        {
            await _service.InsertProduct(request, cancellationToken);
            return Created(string.Empty, null);
        }
    }
}
