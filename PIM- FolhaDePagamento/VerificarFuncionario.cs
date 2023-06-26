using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PIM__FolhaDePagamento
{
    public partial class VerificarFuncionario : Form
    {
        Thread ntEditarFuncionario;
        Thread ntVoltarVerificarFuncionario;
        Thread ntEmitirFolhaDePagamento;
        Thread ntVerificarFolhaDePagamento;
        Thread ntExcluirFuncionario;
        public VerificarFuncionario()
        {
            InitializeComponent();
        }
        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntEditarFuncionario = new Thread(EditarFuncionario);
            ntEditarFuncionario.SetApartmentState(ApartmentState.STA);
            ntEditarFuncionario.Start();
        }
        private void EditarFuncionario()
        {
            Application.Run(new EditarFuncionario());
        }
        private void btnVoltarVerificarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar para a tela anterior?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltarVerificarFuncionario = new Thread(VoltarVerificarFuncionario);
                ntVoltarVerificarFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltarVerificarFuncionario.Start();
            }
        }
        private void VoltarVerificarFuncionario()
        {
            Application.Run(new TelaLogada());
        }

        private void btnEmitirFolhaPagamento_Click(object sender, EventArgs e)
        {
            this.Close();
            ntEmitirFolhaDePagamento = new Thread(EmitirFolhaDePagamento);
            ntEmitirFolhaDePagamento.SetApartmentState(ApartmentState.STA);
            ntEmitirFolhaDePagamento.Start();
        }
        private void EmitirFolhaDePagamento()
        {
            Application.Run(new EmitirFolha());
        }

        private void btnVerificarFolhaPagamento_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVerificarFolhaDePagamento = new Thread(VerificarFolha);
            ntVerificarFolhaDePagamento.SetApartmentState(ApartmentState.STA);
            ntVerificarFolhaDePagamento.Start();
        }
        private void VerificarFolha()
        {
            Application.Run(new VerificarFolha());
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntExcluirFuncionario = new Thread(ExcluirFuncionario);
            ntExcluirFuncionario.SetApartmentState(ApartmentState.STA);
            ntExcluirFuncionario.Start();
        }
        private void ExcluirFuncionario()
        {
            Application.Run(new ExcluirFuncionario());
        }
    }
}
