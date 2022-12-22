using Shared.Results;
using MediatR;
using Application.Interfaces.Repositories;

namespace Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery:IRequest<IResult>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IResult>
        {
            private readonly IProductRepository _productRepository;

            public GetAllProductsQueryHandler(IProductRepository productRepository)
            {
                _productRepository = productRepository;
            }
            public async Task<IResult> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                var result = await _productRepository.GetAllAsync();
            }
        }
    }
}
