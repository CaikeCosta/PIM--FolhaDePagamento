using System.Threading;
using PIM__FolhaDePagamento.Utilitarios;

namespace PIM__FolhaDePagamento
{
    public partial class Form1 : Form
    {
        Thread ntTelaLogada;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txtLogin.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.cadastrado)
                {
                    this.Close();
                    ntTelaLogada = new Thread(TelaLogadaForm);
                    ntTelaLogada.SetApartmentState(ApartmentState.STA);
                    ntTelaLogada.Start();
                }
                else
                {
                    MessageBox.Show("Login ou senha incorretos", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void TelaLogadaForm()
        {
            Application.Run(new TelaLogada());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botaoEntrar_Click(null, null);
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! Não lembra sua senha? Não se preocupe, entre em contato com o seu setor de RH para a recuperação e alteração.", "Esqueceu senha", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}