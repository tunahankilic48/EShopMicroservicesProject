﻿namespace Catalog.API.Products.GetProductsByCategory
{
    public record GetProductsByCategoryQuery(string Categoory) : IQuery<GetProductsByCategoryResult>;
    public record GetProductsByCategoryResult(IEnumerable<Product> Products);
    internal class GetProductsByCategoryQueryHandler(IDocumentSession session) : IQueryHandler<GetProductsByCategoryQuery, GetProductsByCategoryResult>
    {
        public async Task<GetProductsByCategoryResult> Handle(GetProductsByCategoryQuery query, CancellationToken cancellationToken)
        {
            IEnumerable<Product> products = await session.Query<Product>()
                .Where(p => p.Category.Contains(query.Categoory))
                .ToListAsync();

            return new GetProductsByCategoryResult(products);
        }
    }
}
