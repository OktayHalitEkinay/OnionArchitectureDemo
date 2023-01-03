using Shared.Results;
using MediatR;
using Application.Interfaces.Repositories;
using Application.Constants;
using Domain.Entities;
using Application.Dtos;
using AutoMapper;
using System.Collections.Generic;

namespace Application.Features.Queries.GetAllProducts
{
    public class GetAllProductsQuery : IRequest<IDataResult<List<ProductViewDto>>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IDataResult<List<ProductViewDto>>>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetAllProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }
            public async Task<IDataResult<List<ProductViewDto>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
            {
                List<Product> products= await _productRepository.GetAllAsync();
                var result = _mapper.Map<List<ProductViewDto>>(products);
                return new SuccessDataResult<List<ProductViewDto>>(result);
            }
        }
    }
}
