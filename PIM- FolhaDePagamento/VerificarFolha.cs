using PIM__FolhaDePagamento.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM__FolhaDePagamento
{
    public partial class VerificarFolha : Form
    {
        Thread ntVoltar_VerificarFolha;
        public VerificarFolha()
        {
            InitializeComponent();
        }

        private void btnVoltar__VerificarFolha_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tem certeza que deseja voltar?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltar_VerificarFolha = new Thread(Voltar_VerificarFolha);
                ntVoltar_VerificarFolha.SetApartmentState(ApartmentState.STA);
                ntVoltar_VerificarFolha.Start();
            }
        }
        private void Voltar_VerificarFolha()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void btnPesquisarCPF__VerificarFolha_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT * FROM TBFolhasDePagamento WHERE CPF = '" + txtPesquisarCPF.Text + "'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
