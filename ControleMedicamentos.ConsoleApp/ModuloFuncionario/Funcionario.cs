using System.Collections;
using ControleMedicamentos.ConsoleApp.Compartilhado;
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


        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (Nome.Length < 2)
            {
                erros.Add("O nome do FUNCIONARIO deve conter pelo menos 2 letras");
            }

            if (string.IsNullOrEmpty(Telefone))
            {
                erros.Add("Por favor, informe um TELEFONE");
            }

            if (string.IsNullOrEmpty(CPF))
            {
                erros.Add("Por favor, informe um CPF");
            }

            return erros;
        }
    }
}