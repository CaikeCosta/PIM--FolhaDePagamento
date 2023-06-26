using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using PIM__FolhaDePagamento.Utilitarios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PIM__FolhaDePagamento
{
    public partial class EditarFuncionario : Form
    {
        Thread ntVoltarEditarFuncionario;
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        private void btnVoltar__EditarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar para a tela anterior?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltarEditarFuncionario = new Thread(Voltar__EditarFuncionario);
                ntVoltarEditarFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltarEditarFuncionario.Start();
            }
        }
        private void Voltar__EditarFuncionario()
        {
            Application.Run(new VerificarFuncionario());
        }

        private void btnAtualizar__EditarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que as informações foram inseridas corretamente?", "Editar funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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

                        var sqlQuery = "UPDATE TBRegistroFuncionarios SET NOME=@NOME, DATA_DE_NASC=@DATA_DE_NASC, RG=@RG, CEP=@CEP, NUMERO=@NUMERO, COMPLEMENTO=@COMPLEMENTO, LOGADOURO=@LOGADOURO, CELULAR=@CELULAR, TELEFONE=@TELEFONE, CARGO=@CARGO, ESTADO_CIVIL=@ESTADO_CIVIL, DEFICIENTE=@DEFICIENTE, GENERO=@GENERO, EMAIL_OP=@EMAIL_OP, SENHA=@SENHA WHERE CPF = '" + txtPesquisarCPF.Text + "'";
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                        {
                            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                            cmd.Parameters.AddWithValue("@DATA_DE_NASC", txtData_nasc.Text);
                            cmd.Parameters.AddWithValue("@RG", txtRG.Text);
                            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text);
                            cmd.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
                            cmd.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
                            cmd.Parameters.AddWithValue("@LOGADOURO", txtLogadouro.Text);
                            cmd.Parameters.AddWithValue("@CELULAR", txtCelular.Text);
                            cmd.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                            cmd.Parameters.AddWithValue("@CARGO", cbCargo.Text);
                            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", cbEstado_civil.Text);
                            cmd.Parameters.AddWithValue("@DEFICIENTE", cbDeficiencia.Text);
                            cmd.Parameters.AddWithValue("@GENERO", cbGenero.Text);
                            cmd.Parameters.AddWithValue("@EMAIL_OP", txtEmailOperacional.Text);
                            cmd.Parameters.AddWithValue("@SENHA", txtSenhaOperacional.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                MessageBox.Show("Funcionário editado com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditarFuncionario_Load(object sender, EventArgs e)
        {

        }



        private void btnPesquisarCPF__EditarFuncionario(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.PesquisarCPF(txtPesquisarCPF.Text);
            if (controle.cadastrado)
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conexao.StrCon))
                    {
                        cn.Open();
                        var sqlQuery = "SELECT * FROM TBRegistroFuncionarios WHERE CPF = '" + txtPesquisarCPF.Text + "';";
                        using (SqlCommand cmd = new SqlCommand(sqlQuery, cn))
                        {
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.HasRows)
                                {
                                    if (dr.Read())
                                    {
                                        txtNome.Text = dr["NOME"].ToString();
                                        txtData_nasc.Text = dr["DATA_DE_NASC"].ToString();
                                        txtCPF.Text = dr["CPF"].ToString();
                                        txtRG.Text = dr["RG"].ToString();
                                        txtCEP.Text = dr["CEP"].ToString();
                                        txtNumero.Text = dr["NUMERO"].ToString();
                                        txtComplemento.Text = dr["COMPLEMENTO"].ToString();
                                        txtLogadouro.Text = dr["LOGADOURO"].ToString();
                                        txtCelular.Text = dr["CELULAR"].ToString();
                                        txtTelefone.Text = dr["TELEFONE"].ToString();
                                        switch (dr["CARGO"])
                                        {
                                            case "Analista de dados":
                                                cbCargo.Text = "Analista de dados";
                                                break;
                                            case "Analista de redes":
                                                cbCargo.Text = "Analista de redes";
                                                break;
                                            case "Analista de suporte":
                                                cbCargo.Text = "Analista de suporte";
                                                break;
                                            case "Financeiro":
                                                cbCargo.Text = "Financeiro";
                                                break;
                                            case "Lider de operações":
                                                cbCargo.Text = "Lider de operações";
                                                break;
                                            case "RH":
                                                cbCargo.Text = "RH";
                                                break;
                                            case "Programador Júnior":
                                                cbCargo.Text = "Programador Júnior";
                                                break;
                                            case "Programador Pleno":
                                                cbCargo.Text = "Programador Pleno";
                                                break;
                                            case "Programador Sênior":
                                                cbCargo.Text = "Programador Sênior";
                                                break;
                                            case "Programador Mobile":
                                                cbCargo.Text = "Programador Mobile";
                                                break;
                                        }

                                        switch (dr["ESTADO_CIVIL"])
                                        {
                                            case "Solteiro(a)":
                                                cbEstado_civil.Text = "Solteiro(a)";
                                                break;
                                            case "Casado(a)":
                                                cbEstado_civil.Text = "Casado(a)";
                                                break;
                                            case "Divorciado(a)":
                                                cbEstado_civil.Text = "Divorciado(a)";
                                                break;
                                            case "Viúvo(a)":
                                                cbEstado_civil.Text = "Viúvo(a)";
                                                break;
                                            case "Separado(a)":
                                                cbEstado_civil.Text = "Separado(a)";
                                                break;
                                        }

                                        switch (dr["DEFICIENTE"])
                                        {
                                            case "Possui":
                                                cbDeficiencia.Text = "Possui";
                                                break;
                                            case "Não possui":
                                                cbDeficiencia.Text = "Não possui";
                                                break;
                                        }

                                        switch (dr["GENERO"])
                                        {
                                            case "Feminino":
                                                cbGenero.Text = "Feminino";
                                                break;
                                            case "Masculino":
                                                cbGenero.Text = "Masculino";
                                                break;
                                            case "Outros":
                                                cbDeficiencia.Text = "Outros";
                                                break;
                                        }

                                        txtEmailOperacional.Text = dr["EMAIL_OP"].ToString();
                                        txtSenhaOperacional.Text = dr["SENHA"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
            }
            else
            {

            }
        }
    }
}
