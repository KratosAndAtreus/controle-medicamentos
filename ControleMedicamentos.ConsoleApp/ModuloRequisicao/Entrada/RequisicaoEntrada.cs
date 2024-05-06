using System.Collections;
using ControleMedicamentos.ConsoleApp.Compartilhado;
using ControleMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleMedicamentos.ConsoleApp.ModuloMedicamento;
using ControleMedicamentos.ConsoleApp.ModuloPaciente;

namespace ControleMedicamentos.ConsoleApp.ModuloRequisicao.Entrada
{
    internal class RequisicaoEntrada : EntidadeBase
    {
        public Medicamento Medicamento { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public Funcionario Funcionario { get; set; }
        public DateTime DataRequisicao { get; set; }
        public int QuantidadeSolicitada { get; set; }

        public RequisicaoEntrada(Medicamento medicamento, Fornecedor fornecedor, Funcionario funcionario, int quantidadeSolicitada)
        {
            Medicamento = medicamento;
            Fornecedor = fornecedor;
            Funcionario = funcionario;

            DataRequisicao = DateTime.Now;
            QuantidadeSolicitada = quantidadeSolicitada;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (Medicamento == null)
                erros.Add("O medicamento precisa ser preenchido");

            if (Fornecedor == null)
                erros.Add("O fornecedor precisa ser informado");

            if (Funcionario == null)
                erros.Add("O funcionário precisa ser informado");

            if (QuantidadeSolicitada == null)
                erros.Add("Por favor informe uma quantidade");

            return erros;
        }

        public bool SolicitarMedicamento()
        {
            Medicamento.Quantidade += QuantidadeSolicitada;
            return true;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            RequisicaoEntrada novasInformações = (RequisicaoEntrada)novoRegistro;
            this.Medicamento = novasInformações.Medicamento;
            this.Fornecedor = novasInformações.Fornecedor;
            this.Funcionario = novasInformações.Funcionario;

            this.QuantidadeSolicitada = novasInformações.QuantidadeSolicitada;
        }
    }
}
