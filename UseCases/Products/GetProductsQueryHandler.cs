using Abstractions.DataAccess;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace UseCases.Products;

/// <summary>
/// Get products query handler.
/// </summary>
internal class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
{
    private readonly IApplicationContext db;

    /// <summary>
    /// Constructor.
    /// </summary>
    public GetProductsQueryHandler(IApplicationContext db)
    {
        this.db = db;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        return db.Products
            .Include(product => product.Type)
            .Where(product => (ProductType)product.Type!.Id == request.Type);
    }
}
