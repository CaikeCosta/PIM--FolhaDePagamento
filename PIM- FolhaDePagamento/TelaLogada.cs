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
    public partial class TelaLogada : Form
    {
        Thread ntInserirCPF_Funcionario;
        public TelaLogada()
        {
            InitializeComponent();
        }
        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            Application.Exit();
        }

        private void buttonVerificarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntInserirCPF_Funcionario = new Thread(InserirCPF_Funcionario);
            ntInserirCPF_Funcionario.SetApartmentState(ApartmentState.STA);
            ntInserirCPF_Funcionario.Start();
        }

        private void InserirCPF_Funcionario()
        {
            Application.Run(new InserirCPF_Funcionario());
        }
    }
}
