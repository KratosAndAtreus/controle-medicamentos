using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {
            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Fornecedores...");
            }

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                "Id", "Nome", "CNPJ", "Telefone", "E-mail"
            );

            EntidadeBase[] fornecedoresCadastrados = repositorio.SelecionarTodos();

            foreach (Fornecedor fornecedor in fornecedoresCadastrados)
            {
                if (fornecedor == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -20} | {3, -15} | {4, -20}",
                    fornecedor.Id, fornecedor.Nome, fornecedor.CNPJ, fornecedor.Telefone, fornecedor.Email
                );
            }

            Console.ReadLine();
            Console.WriteLine();
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do fornecedor: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o CNPJ do fornecedor: ");
            string cnpj = Console.ReadLine();

            Console.Write("Digite o telefone do fornecedor: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o E-mail do fornecedor: ");
            string email = Console.ReadLine();

            Fornecedor novoFornecedor= new Fornecedor(nome, cnpj, telefone, email);

            return novoFornecedor;
        }

        public void CadastrarEntidadeTeste()
        {
            Fornecedor fornecedor = new Fornecedor("Bobby Tables", "99.999.999/0001.00", "49 9999-9521", "123213@13122");

            repositorio.Cadastrar(fornecedor);
        }
    }
}
