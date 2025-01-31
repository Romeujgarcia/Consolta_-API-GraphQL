API GraphQL com .NET e SQL Server
Descrição
Este projeto é uma API GraphQL desenvolvida utilizando .NET 6/7/8 (especificar a versão) com conexão a um banco de dados SQL Server. A API permite realizar consultas (queries) e mutações (mutations) de dados de forma eficiente, utilizando as vantagens do GraphQL para otimizar a interação com o banco de dados.

A aplicação foi construída para oferecer uma interface flexível, escalável e de alto desempenho para manipulação de dados.

Tecnologias Utilizadas
Backend: .NET 8 (especificar versão)
API GraphQL: HotChocolate
Banco de Dados: SQL Server
ORM: Entity Framework Core
Autenticação e Autorização: JWT com ASP.NET Core Identity
Testes Automatizados: xUnit (se aplicável)
Docker (opcional): Para facilitar o desenvolvimento e implantação
Funcionalidades
Consultas GraphQL: Realização de consultas flexíveis aos dados, com suporte a filtros, ordenação e projeções.
Mutação de Dados: Criação, atualização e exclusão de dados utilizando mutações GraphQL.
Autenticação com JWT: Proteção dos endpoints da API com autenticação via JWT, garantindo a segurança dos dados.
Integração com SQL Server: Persistência de dados em SQL Server utilizando o Entity Framework Core.
Como Rodar o Projeto Localmente
Pré-requisitos
Antes de rodar o projeto, verifique se você tem os seguintes itens instalados:

.NET 6/7/8 (especificar versão)
SQL Server (ou uma instância local do SQL Server, ou conexão com um banco na nuvem)
Ferramentas de CLI do .NET (opcional, se você for rodar via terminal)
Visual Studio Code ou Visual Studio (com suporte para .NET e C#)
Configuração
Clone o repositório

Clone este repositório para sua máquina local:

bash
Copiar
Editar
git clone https://github.com/usuario/nome-do-repositorio.git
cd nome-do-repositorio
Configuração do Banco de Dados

O projeto utiliza SQL Server para persistir dados. Certifique-se de que você tem uma instância do SQL Server rodando. Se estiver utilizando o SQL Server localmente, altere a string de conexão no arquivo appsettings.json:

json
Copiar
Editar
"ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=GraphQLDb;Trusted_Connection=True;"
}
Caso esteja usando uma instância na nuvem ou em outro servidor, altere a string de conexão para refletir o seu ambiente.

Executar as Migrações do Banco de Dados

Execute as migrações para criar o banco de dados e suas tabelas:

bash
Copiar
Editar
dotnet ef database update
Executar o Projeto

Você pode rodar o projeto utilizando o comando abaixo:

bash
Copiar
Editar
dotnet run
O projeto estará disponível em http://localhost:5003 ou https://localhost:5003, conforme configurado. Você pode acessar a documentação da API via Swagger ou fazer chamadas diretamente usando GraphQL.

Acessando o GraphQL
Após rodar a aplicação, você pode acessar o GraphQL Playground no seguinte endereço:
http://localhost:5003/graphql

Aqui, você poderá testar consultas e mutações diretamente.

Testes
Para rodar os testes automatizados (se aplicável), execute:

bash
Copiar
Editar
dotnet test
Estrutura de Diretórios
/Controllers: Contém os controladores da API (se houver).
/GraphQL: Contém as definições do GraphQL, como Queries e Mutations.
/Models: Contém os modelos de dados que representam os objetos manipulados.
/Services: Contém os serviços responsáveis pela lógica de negócio.
/Migrations: Contém as migrações do Entity Framework Core.
/appsettings.json: Arquivo de configuração, incluindo string de conexão com o banco de dados.
Contribuindo
Se você deseja contribuir com este projeto, por favor, faça o fork do repositório e crie um pull request com suas alterações.

Passos para contribuir:
Faça o fork do repositório.
Crie uma branch para sua feature (git checkout -b minha-feature).
Realize as modificações necessárias e faça commit (git commit -am 'Adiciona nova feature').
Faça o push para a branch (git push origin minha-feature).
Abra um pull request.
Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo LICENSE.md para mais detalhes.
