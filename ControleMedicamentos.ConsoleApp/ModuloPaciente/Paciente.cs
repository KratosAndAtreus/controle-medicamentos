

using System.Collections;
using ControleMedicamentos.ConsoleApp.Compartilhado;

namespace ControleMedicamentos.ConsoleApp.ModuloPaciente
{
    internal class Paciente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string CartaoSus { get; set; }

        public Paciente(string nome, string telefone, string cartaoSus)
        {
            Nome = nome;
            Telefone = telefone;
            CartaoSus = cartaoSus;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (Nome.Length < 3)
                erros.Add("O nome precisa ter pelo menos 3 letras");

            if (string.IsNullOrEmpty(Telefone))
                erros.Add("O Telefone precisa ser preenchido");

            if (string.IsNullOrEmpty(CartaoSus))
                erros.Add("O Telefone precisa ser preenchido");

            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Paciente novasInformações = (Paciente)novoRegistro;
            this.Nome = novasInformações.Nome;
            this.Telefone = novasInformações.Telefone;
            this.CartaoSus = novasInformações.CartaoSus;
        }
    }
}
