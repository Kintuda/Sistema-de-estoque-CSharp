namespace enzo_estoque.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<enzo_estoque.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(enzo_estoque.Models.ApplicationDbContext context)
        {
            context.Fornecedors.AddOrUpdate(x => x.ID,
            new Models.Fornecedor() {
                ID = 1,
                RazaoSocial = "Foobar LTC" ,
                NomeFantasia = "Foobar",
                Telefone = "44987231",
                Endereco = "Rua de testes",
                Cidade = "Maringa PR",
                Email = "teste@gmail.com",
                Cnpj = "897456"
                }
            );
        }
    }
}
