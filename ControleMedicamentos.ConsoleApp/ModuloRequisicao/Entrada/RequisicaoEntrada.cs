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

        public override string[] Validar()
        {
            string[] erros = new string[3];
            int contadorErros = 0;

            if (Medicamento == null)
                erros[contadorErros++] = "O medicamento precisa ser preenchido";

            if (Fornecedor == null)
                erros[contadorErros++] = "O fornecedor precisa ser informado";

            if (Funcionario == null)
                erros[contadorErros++] = "O funcionário precisa ser informado";
            
            if (QuantidadeSolicitada < 1)
                erros[contadorErros++] = "Por favor informe uma quantidade";

            string[] errosFiltrados = new string[contadorErros];

            Array.Copy(erros, errosFiltrados, contadorErros);

            return errosFiltrados;
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
