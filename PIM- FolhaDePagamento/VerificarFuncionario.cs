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
        Thread ntVoltarVerificarFuncionario;
        public VerificarFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltarVerificarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVoltarVerificarFuncionario = new Thread(VoltarVerificarFuncionario);
            ntVoltarVerificarFuncionario.SetApartmentState(ApartmentState.STA);
            ntVoltarVerificarFuncionario.Start();
        }
        private void VoltarVerificarFuncionario()
        {
            Application.Run(new InserirCPF_Funcionario());
        }
    }
}
