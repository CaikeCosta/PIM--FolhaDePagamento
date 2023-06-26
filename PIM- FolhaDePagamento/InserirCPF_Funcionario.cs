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
    public partial class InserirCPF_Funcionario : Form
    {
        Thread ntVerificarFuncionario;
        Thread ntVoltarInserirCPF;
        public InserirCPF_Funcionario()
        {
            InitializeComponent();
        }

        private void btnVerificarFuncionario_Click(object sender, EventArgs e)
        {
            if (txtCPF_Funcionario.Text == "123")
            {
                this.Close();
                ntVerificarFuncionario = new Thread(VerificarFuncionario);
                ntVerificarFuncionario.SetApartmentState(ApartmentState.STA);
                ntVerificarFuncionario.Start();
            }
            else
            {
                MessageBox.Show("Funcionário não registrado");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void VerificarFuncionario()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void InserirCPF_Funcionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVerificarFuncionario_Click(null, null);
            }
            if(e.KeyCode == Keys.Escape)
            {
                btnVoltar__InserirCPF_Funcionario_Click(null, null);
            }
        }

        private void txtCPF_Funcionario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVerificarFuncionario_Click(null, null);
            }
        }

        private void btnVoltar__InserirCPF_Funcionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVoltarInserirCPF = new Thread(VoltarInserirCPF);
            ntVoltarInserirCPF.SetApartmentState(ApartmentState.STA);
            ntVoltarInserirCPF.Start();
        }
        private void VoltarInserirCPF()
        {
            Application.Run(new TelaLogada());
        }
    }
}
