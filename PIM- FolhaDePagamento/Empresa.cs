using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM__FolhaDePagamento
{
    public partial class Empresa : Form
    {
        Thread ntVoltarEmpresa;
        public Empresa()
        {
            InitializeComponent();
        }

        private void btnVoltarEmpresa_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVoltarEmpresa = new Thread(VoltarEmpresa);
            ntVoltarEmpresa.SetApartmentState(ApartmentState.STA);
            ntVoltarEmpresa.Start();
        }
        private void VoltarEmpresa()
        {
            Application.Run(new TelaLogada());
        }
    }
}
