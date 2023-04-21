using System.Threading;

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
            if(txtLogin.Text == "LoginADM" && txtSenha.Text == "SenhaADM")
            {
                this.Close();
                ntTelaLogada = new Thread(TelaLogadaForm);
                ntTelaLogada.SetApartmentState(ApartmentState.STA);
                ntTelaLogada.Start();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos");
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
    }
}