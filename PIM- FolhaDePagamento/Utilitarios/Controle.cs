using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PIM__FolhaDePagamento.Utilitarios
{
    public class Controle
    {
        public bool cadastrado;
        public bool emitido;
        public string mensagem = "";
        public bool Acessar(string email_operacional, string senha)
        {
            LoginComandosSQL loginSQL = new LoginComandosSQL();
            cadastrado = loginSQL.VerificarLogin(email_operacional, senha);
            if (!loginSQL.mensagem.Equals(""))
            {
                this.mensagem = loginSQL.mensagem;
            }
            return cadastrado;
        }

        public string CadastrarFuncionario(string nome, string data_nasc, string cpf, string rg, string cep, string numero, string complemento, string logadouro, string celular, string telefone,
            string cargo, string estado_civil, string deficiencia, string genero, string email_operacional, string senha)
        {
            LoginComandosSQL loginSQL = new LoginComandosSQL();
            this.mensagem = loginSQL.CadastrarFuncionario(nome, data_nasc, cpf, rg, cep, numero, complemento, logadouro, celular, telefone, cargo, estado_civil, deficiencia, genero, email_operacional, senha);
            if(loginSQL.cadastrado)
            {
                this.cadastrado = true;
            }
            return mensagem;
        }

        public string CadastrarRH(string nome, string email_operacional, string senha)
        {
            LoginComandosSQL loginSQL = new LoginComandosSQL();
            this.mensagem = loginSQL.CadastrarRH(nome, email_operacional, senha);
            if(loginSQL.cadastrado)
            {
                this.cadastrado = true;
            }
            return mensagem;
        }

        public bool PesquisarCPF(string cpf)
        {
            LoginComandosSQL LoginSQL = new LoginComandosSQL();
            cadastrado = LoginSQL.PesquisarCPF(cpf);
            if (!LoginSQL.mensagem.Equals(""))
            {
                this.mensagem = LoginSQL.mensagem;
            }
            return cadastrado;
        }

        public string EmitirFolhaDePagamento(string cpf, string total_venc, string base_fgts, string descontos, string base_inss, string liquido_receber, string fgts_mes, string salario)
        {
            LoginComandosSQL loginSQL = new LoginComandosSQL();
            this.mensagem = loginSQL.EmitirFolhaDePagamento(cpf, total_venc, base_fgts, descontos, base_inss, liquido_receber, fgts_mes, salario);

            if (loginSQL.cadastrado)
            {
                this.cadastrado = true;
            }
            return mensagem;
        }
    }
}
