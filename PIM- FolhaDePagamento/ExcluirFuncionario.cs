using PIM__FolhaDePagamento.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM__FolhaDePagamento
{
    public partial class ExcluirFuncionario : Form
    {
        Thread ntVoltar_ExcluirFuncionario;
        public ExcluirFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar__ExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja voltar?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltar_ExcluirFuncionario = new Thread(Voltar_ExcluirFuncionario);
                ntVoltar_ExcluirFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltar_ExcluirFuncionario.Start();
            }
        }
        private void Voltar_ExcluirFuncionario()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void btnPesquisarCPF__ExcluirFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexao.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT * FROM TBRegistroFuncionarios WHERE CPF = '" + txtPesquisarCPF.Text + "'";
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

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir este funcionário?", "Excluir funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conexao.StrCon))
                    {
                        cn.Open();

                        var sqlQuery = "DELETE FROM TBRegistroFuncionarios WHERE CPF = '" + txtPesquisarCPF.Text + "'";
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
                MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ntVoltar_ExcluirFuncionario = new Thread(Voltar_ExcluirFuncionario);
                ntVoltar_ExcluirFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltar_ExcluirFuncionario.Start();
            }
        }
    }
}
