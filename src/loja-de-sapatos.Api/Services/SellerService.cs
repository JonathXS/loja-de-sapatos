using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using Mapster;

namespace loja_de_sapatos.Api.Services
{
    public class SellerService : ISellerService
    {
        private readonly ISellerRepository _sellerRepository;

        public SellerService(ISellerRepository sellerRepository)
        {
            _sellerRepository = sellerRepository;
        }

        public async Task UpdateSeller(UpdateSellerDTO updateSeller, CancellationToken cancellationToken)
        {
            await _sellerRepository.UpdateSeller(updateSeller, cancellationToken);
        }

        public async Task DeleteSeller(int id, CancellationToken cancellationToken)
        {
            await _sellerRepository.DeleteSeller(id, cancellationToken);
        }

        public async Task<List<SellerResponse?>> GetSellers(CancellationToken cancellationToken)
        {
            var sellers = await _sellerRepository.GetSellers(cancellationToken);
            
            return sellers.Adapt<List<SellerResponse?>>();
        }

        public async Task<SellerResponse?> GetSeller(int id, CancellationToken cancellationToken)
        {
            var seller = await _sellerRepository.GetSeller(id, cancellationToken);
            
            return seller.Adapt<SellerResponse>();
        }

        public async Task InsertSeller(CreateSellerDTO request, CancellationToken cancellationToken)
        {
            var seller = new Seller
            {
                Name = request.Name,
                Address = new Address(request.Address.Street, request.Address.Number, request.Address.District, request.Address.City, request.Address.State),
                DateCreate = DateTime.UtcNow
            };
            await _sellerRepository.InsertSeller(seller, cancellationToken);
        }

    }
}
