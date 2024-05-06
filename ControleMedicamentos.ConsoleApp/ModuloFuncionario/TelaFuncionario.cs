using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using System.Collections;
namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public override void VisualizarRegistros(bool exibirTitulo)
        {

            if (exibirTitulo)
            {
                ApresentarCabecalho();

                Console.WriteLine("Visualizando Funcionarios...");
            }

            Console.WriteLine(
                "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                "Id", "Nome", "Telefone", "CPF"
            );

            ArrayList funcionariosCadastrados = repositorio.SelecionarTodos();

            foreach (Funcionario funcionario in funcionariosCadastrados)
            {
                if (funcionario == null)
                    continue;

                Console.WriteLine(
                    "{0, -10} | {1, -15} | {2, -15} | {3, -15}",
                    funcionario.Id, funcionario.Nome, funcionario.Telefone, funcionario.CPF
                );

                Console.ReadLine();
                Console.WriteLine();
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome do funcionario: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o telefone do funcionario: ");
            string telefone = Console.ReadLine();

            Console.Write("Digite o CPF do funcionario: ");
            string cartaoSus = Console.ReadLine();

            Funcionario novoFuncionario = new Funcionario(nome, telefone, cartaoSus);

            return novoFuncionario;
        }

        public void CadastrarEntidadeTeste()
        {
            Funcionario funcionario = new Funcionario("Bobby Tables", "49 9999-9521", "123213@13122");

            repositorio.Cadastrar(funcionario);
        }
    }
}