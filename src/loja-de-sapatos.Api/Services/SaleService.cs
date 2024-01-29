using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using System.Diagnostics.CodeAnalysis;

namespace loja_de_sapatos.Api.Services
{
    public class SaleService : ISaleService
    {
        private readonly ISaleRepository _salerepository;
        private readonly ISellerRepository _sellerrepository;
        private readonly IProductRepository _productrepository;
        private readonly IClientRepository _clientrepository;

        public SaleService(ISaleRepository salerepository, ISellerRepository sellerrepository, IProductRepository productrepository, IClientRepository clientrepository)
        {
            _salerepository = salerepository;
            _sellerrepository = sellerrepository;
            _productrepository = productrepository;
            _clientrepository = clientrepository;
        }

        public async Task DeleteSale (int id, CancellationToken cancellationToken)
        {
            await _salerepository.DeleteSale(id, cancellationToken);
        }

        public async Task<List<SaleResponse>> GetSales(CancellationToken cancellationToken)
        {
            var sales = await _salerepository.GetSales(cancellationToken);
            if (sales == null)
            {
                return new List<SaleResponse>();
            }

            var response = new List<SaleResponse>();

            foreach (var sale in sales)
            {
                var saleResponse = new SaleResponse
                {
                    ClientId = sale.Client!.Id,
                    SellerId = sale.Seller!.Id,
                    ProdId = sale.Product!.Id,
                    Id = sale.Id
                };
                response.Add(saleResponse);
            }
            return response;
        }

        public async Task<SaleResponse?> GetSale(int id, CancellationToken cancellationToken)
        {
            var sale = await _salerepository.GetSale(id, cancellationToken);
            if (sale == null)
            {
                return null;
            }

            var response = new SaleResponse
            {
                ClientId = sale.Client.Id,
                SellerId = sale.Seller.Id,
                ProdId = sale.Product.Id,
                Id = sale.Id
            };
            return response;
        }

        public async Task<bool> InsetSale(CreateSaleDTO request, CancellationToken cancellationToken)
        {
            var product = await _productrepository.GetProduct(request.ProdID, cancellationToken);
            var seller = await _sellerrepository.GetSeller(request.SellerId, cancellationToken);
            var client = await _clientrepository.GetClient(request.ClientId, cancellationToken);

            if (product == null || seller == null || client == null)
            {
                return false;
            }

            var sale = new Sale
            {
                Product = product,
                Seller = seller,
                Client = client
            };
            await _salerepository.InsertSale(sale, cancellationToken);
            return true;
        }
    }
}
