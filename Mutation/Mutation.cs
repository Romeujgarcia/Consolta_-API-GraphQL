using GraphQLApi.Data;
using GraphQLApi.Models;
using HotChocolate;

namespace GraphQLApi.GraphQL
{
    public class Mutation
    {
        public async Task<Produto> AddProduto([Service] AppDbContext context, string nome, decimal preco)
        {
            var produto = new Produto { Nome = nome, Preco = preco };
            context.Produtos.Add(produto);
            await context.SaveChangesAsync();
            return produto;
        }
    }
}
