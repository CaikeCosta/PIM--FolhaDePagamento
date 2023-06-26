using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIM__FolhaDePagamento.Utilitarios;

namespace PIM__FolhaDePagamento
{
    public partial class CadastrarFuncionario : Form
    {
        Thread ntVoltar_CadastroFuncionario;
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que as informações foram inseridas corretamente?", "Cadastrar funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                Controle controle = new Controle();
                string mensagem = controle.CadastrarFuncionario(txtNome.Text, txtData_nasc.Text, txtCPF.Text, txtRG.Text, txtCEP.Text, txtNumero.Text, txtComplemento.Text, txtLogadouro.Text, txtCelular.Text,
                    txtTelefone.Text, cbCargo.Text, cbEstado_civil.Text, cbDeficiencia.Text, cbGenero.Text, txtEmailOperacional.Text, txtSenhaOperacional.Text);
                if (cbCargo.Text == "RH")
                {
                    string mensagem1 = controle.CadastrarRH(txtNome.Text, txtEmailOperacional.Text, txtSenhaOperacional.Text);
                }
                if (controle.cadastrado)
                {
                    MessageBox.Show(mensagem, "Cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(controle.mensagem, "Preencha todos os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Close();
                ntVoltar_CadastroFuncionario = new Thread(Voltar_CadastroFuncionario);
                ntVoltar_CadastroFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltar_CadastroFuncionario.Start();
            }
        }

        private void btnVoltar_CadastroFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja voltar para a tela inicial?", "Voltar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
                ntVoltar_CadastroFuncionario = new Thread(Voltar_CadastroFuncionario);
                ntVoltar_CadastroFuncionario.SetApartmentState(ApartmentState.STA);
                ntVoltar_CadastroFuncionario.Start();
            }
        }
        private void Voltar_CadastroFuncionario()
        {
            Application.Run(new TelaLogada());
        }
    }
}
