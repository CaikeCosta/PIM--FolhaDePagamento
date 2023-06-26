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
    public partial class LGPD : Form
    {
        Thread ntVoltar_LGPD;
        public LGPD()
        {
            InitializeComponent();
        }
        private void btnVoltar__LGPD_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVoltar_LGPD = new Thread(Voltar_LGPD);
            ntVoltar_LGPD.SetApartmentState(ApartmentState.STA);
            ntVoltar_LGPD.Start();
        }
        private void Voltar_LGPD()
        {
            Application.Run(new TelaLogada());
        }
    }
}
