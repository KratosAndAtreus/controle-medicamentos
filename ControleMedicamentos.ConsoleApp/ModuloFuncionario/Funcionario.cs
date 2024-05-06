using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
namespace ControleMedicamentos.ConsoleApp.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }


        public Funcionario(string nome, string telefone, string cpf)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
        }


        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (Nome.Length < 2)
            {
                erros[contadorErros++] = "O nome do FUNCIONARIO deve conter pelo menos 2 letras";
            }

            if (string.IsNullOrEmpty(Telefone))
            {
                erros[contadorErros++] = "Por favor, informe um TELEFONE";
            }

            if (string.IsNullOrEmpty(CPF))
            {
                erros[contadorErros++] = "Por favor, informe um CPF";
            }

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Funcionario novasInformações = (Funcionario)novoRegistro;
            this.Nome = novasInformações.Nome;
            this.Telefone = novasInformações.Telefone;
            this.CPF = novasInformações.CPF;
        }
    }
}