
using GraphQLApi.Models;
using GraphQLApi.Data;


namespace GraphQLApi.GraphQL
{
  public class Query
{
    private readonly ProdutoService _produtoService;

    public Query(ProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Produto> GetProdutos()
    {
        return _produtoService.GetProdutos();
    }
}


}
