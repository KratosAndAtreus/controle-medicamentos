using System.Collections;
using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : EntidadeBase
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Fornecedor(string nome, string cnpj, string telefone, string email)
        {
            Nome = nome;
            CNPJ = cnpj;
            Telefone = telefone;
            Email = email;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();


            if (Nome.Length < 3)
                erros.Add("O Nome do Paciente precisa conter ao menos 3 caracteres");

            if (CNPJ.Length < 14)
                erros.Add("O CNPJ está incompleto");

            if (string.IsNullOrEmpty(Telefone))
                erros.Add("O Telefone precisa ser preenchido");

            if (!Email.Contains("@"))
                erros.Add("O e-mail precisa conter \"@\" para reconhecer o endereço");

            return erros;
        }

    }
}
