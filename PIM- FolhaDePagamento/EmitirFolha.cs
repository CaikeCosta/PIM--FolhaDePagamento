using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM__FolhaDePagamento.Utilitarios;
using System.Globalization;

namespace PIM__FolhaDePagamento
{
    public partial class EmitirFolha : Form
    {
        Thread ntVoltarEmitirFolha;
        public EmitirFolha()
        {
            InitializeComponent();
        }

        private void btnVoltar__EmitirFolha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja voltar?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltarEmitirFolha = new Thread(VoltarEmitirFolha);
                ntVoltarEmitirFolha.SetApartmentState(ApartmentState.STA);
                ntVoltarEmitirFolha.Start();
            }
        }

        private void VoltarEmitirFolha()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int QuantidadeHorasTrabalhadas, QuantidadeHorasNaoTrabalhadas, JornadaMensal, QuantidadeHorasExtrasCinquenta,
                QuantidadeHorasExtrasCem, QuantidadeHorasExtrasNoturno;
            double salarioBase, PercentualPericulosidade, HorasNaoTrabalhadas, TotalVencimentos, TotalDescontos, LiquidoReceber, ValorHoraComum, HorasExtrasCem,
                HorasExtasCinquenta, HorasExtrasNoturno, DescontoINSS, FGTS, Perciculosidade, DescontosFixos;

            salarioBase = double.Parse(txtSalarioBase.Text);
            JornadaMensal = int.Parse(txtJornadaTrabalhoMensal.Text);
            QuantidadeHorasTrabalhadas = int.Parse(txtHorasTrabalhadas.Text);
            PercentualPericulosidade = double.Parse(txtPericulosidade.Text);
            DescontosFixos = double.Parse(txtDescontosFixos.Text);

            ValorHoraComum = salarioBase / JornadaMensal;
            Perciculosidade = salarioBase * (PercentualPericulosidade / 100);

            QuantidadeHorasNaoTrabalhadas = QuantidadeHorasTrabalhadas - JornadaMensal;
            HorasNaoTrabalhadas = (ValorHoraComum * QuantidadeHorasNaoTrabalhadas) * -1;

            QuantidadeHorasExtrasCinquenta = int.Parse(txtHorasExtrasCinquenta.Text);
            QuantidadeHorasExtrasCem = int.Parse(txtHorasExtrasCem.Text);
            QuantidadeHorasExtrasNoturno = int.Parse(txtHorasExtrasNoturno.Text);
            HorasExtasCinquenta = (ValorHoraComum * 1.5) * QuantidadeHorasExtrasCinquenta;
            HorasExtrasCem = (ValorHoraComum * 2) * QuantidadeHorasExtrasCem;
            HorasExtrasNoturno = ((ValorHoraComum * 1.5) * 1.2) * QuantidadeHorasExtrasNoturno;
            TotalVencimentos = salarioBase + HorasExtasCinquenta + HorasExtrasCem + HorasExtrasNoturno + HorasNaoTrabalhadas + Perciculosidade;

            DescontoINSS = CalculaDescontoINSS.CalcularDescontoINSS(TotalVencimentos);
            TotalDescontos = DescontoINSS + DescontosFixos;

            LiquidoReceber = TotalVencimentos - TotalDescontos;

            FGTS = TotalVencimentos * 0.08;

            txtTotalVencimentos.Text = TotalVencimentos.ToString("C", CultureInfo.CurrentCulture);
            txtTotalDescontos.Text = TotalDescontos.ToString("C", CultureInfo.CurrentCulture);
            txtLiquidoReceber.Text = LiquidoReceber.ToString("C", CultureInfo.CurrentCulture);
            txtBaseCalculoFGTS.Text = TotalVencimentos.ToString("C", CultureInfo.CurrentCulture);
            txtBaseCalculoINSS.Text = TotalVencimentos.ToString("C", CultureInfo.CurrentCulture);
            txtFGTS_Mes.Text = FGTS.ToString("C", CultureInfo.CurrentCulture);
        }

        private void btnEmitirFolha_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que as informações foram inseridas corretamente?", "Emitir folha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                Controle controle = new Controle();
                string mensagem = controle.EmitirFolhaDePagamento(txtPesquisarCPF.Text, txtTotalVencimentos.Text, txtBaseCalculoFGTS.Text, txtTotalDescontos.Text, txtBaseCalculoINSS.Text, txtLiquidoReceber.Text, txtFGTS_Mes.Text, txtSalarioBase.Text);
                if (controle.cadastrado)
                {
                    MessageBox.Show(mensagem, "Folha emitida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(controle.mensagem, "Funcionário não cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
                ntVoltarEmitirFolha = new Thread(VoltarEmitirFolha);
                ntVoltarEmitirFolha.SetApartmentState(ApartmentState.STA);
                ntVoltarEmitirFolha.Start();
            }
        }
    }
}
