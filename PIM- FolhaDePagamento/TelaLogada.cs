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
        Thread ntCadastrarFuncionario;
        Thread ntVerificarFuncionario;
        Thread ntEmpresa;
        Thread ntLGPD;
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
            ntVerificarFuncionario = new Thread(VerificarFuncionario);
            ntVerificarFuncionario.SetApartmentState(ApartmentState.STA);
            ntVerificarFuncionario.Start();
        }

        private void VerificarFuncionario()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntCadastrarFuncionario = new Thread(CadastrarFuncionario);
            ntCadastrarFuncionario.SetApartmentState(ApartmentState.STA);
            ntCadastrarFuncionario.Start();
        }
        private void CadastrarFuncionario()
        {
            Application.Run(new CadastrarFuncionario());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
            ntEmpresa = new Thread(Empresa);
            ntEmpresa.SetApartmentState(ApartmentState.STA);
            ntEmpresa.Start();
        }
        private void Empresa()
        {
            Application.Run(new Empresa());
        }

        private void buttonLGPD_Click(object sender, EventArgs e)
        {
            this.Close();
            ntLGPD = new Thread(LGPD);
            ntLGPD.SetApartmentState(ApartmentState.STA);
            ntLGPD.Start();
        }
        private void LGPD()
        {
            Application.Run(new LGPD());
        }
    }
}
