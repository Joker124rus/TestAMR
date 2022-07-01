using Domain.Models;
using MediatR;

namespace UseCases.Products;

/// <summary>
/// Get products query with specified type.
/// </summary>
public record GetProductsQuery(ProductType ProductType) : IRequest<IEnumerable<Product>>;
