using GraphQLApi.Data;
using GraphQLApi.Models;
using Microsoft.EntityFrameworkCore;

public class ProdutoService
{
    private readonly AppDbContext _context;

    public ProdutoService(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<Produto> GetProdutos()
    {
        return _context.Produtos.AsNoTracking();
    }
}
