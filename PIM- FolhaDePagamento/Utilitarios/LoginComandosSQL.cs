using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM__FolhaDePagamento.Utilitarios
{
    public class LoginComandosSQL
    {
        public bool cadastrado = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao conectar = new Conexao();
        SqlDataReader dataReader;
        public bool VerificarLogin(string login, string senha)
        {
            cmd.CommandText = "SELECT * FROM TBLoginRH WHERE email_op = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("senha", senha);

            try
            {
                cmd.Connection = conectar.Conectar();
                dataReader = cmd.ExecuteReader();
                if(dataReader.HasRows)
                {
                    cadastrado = true;
                }
                conectar.Desconectar();
                dataReader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }
            return cadastrado;
        }

        public string CadastrarFuncionario(string nome, string data_nasc, string cpf, string rg, string cep, string numero, string complemento, string logadouro, string celular, string telefone,
            string cargo, string estado_civil, string deficiencia, string genero, string email_operacional, string senha)
        {
            cadastrado = false;
            cmd.CommandText = "insert into TBRegistroFuncionarios values (@NOME, @DATA_DE_NASC, @CPF, @RG, @CEP, @NUMERO, @COMPLEMENTO, @LOGADOURO, @CELULAR, @TELEFONE, @CARGO, @ESTADO_CIVIL, @DEFICIENTE, @GENERO, @EMAIL_OP, @SENHA);";
            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@DATA_DE_NASC", data_nasc);
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@RG", rg);
            cmd.Parameters.AddWithValue("@CEP", cep);
            cmd.Parameters.AddWithValue("@NUMERO", numero);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", complemento);
            cmd.Parameters.AddWithValue("@LOGADOURO", logadouro);
            cmd.Parameters.AddWithValue("@CELULAR", celular);
            cmd.Parameters.AddWithValue("@TELEFONE", telefone);
            cmd.Parameters.AddWithValue("@CARGO", cargo);
            cmd.Parameters.AddWithValue("@ESTADO_CIVIL", estado_civil);
            cmd.Parameters.AddWithValue("@DEFICIENTE", deficiencia);
            cmd.Parameters.AddWithValue("@GENERO", genero);
            cmd.Parameters.AddWithValue("@EMAIL_OP", email_operacional);
            cmd.Parameters.AddWithValue("@SENHA", senha);

            try
            {
                cmd.Connection = conectar.Conectar();
                cmd.ExecuteNonQuery();
                conectar.Desconectar();
                this.mensagem = "Funcionário cadastrado com sucesso!";
                cadastrado = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Funcionário já cadastrado ou CPF não preenchido!";
            }
            return mensagem;
        }

        public string CadastrarRH(string nome, string email_operacional, string senha)
        {
            cadastrado = false;
            cmd.CommandText = "insert into TBLoginRH values (@NOME, @EMAIL_OP, @SENHA);";
            cmd.Parameters.AddWithValue("@NOME", nome);
            cmd.Parameters.AddWithValue("@EMAIL_OP", email_operacional);
            cmd.Parameters.AddWithValue("@SENHA", senha);

            try
            {
                cmd.Connection = conectar.Conectar();
                cmd.ExecuteNonQuery();
                conectar.Desconectar();
                this.mensagem = "RH cadastrado com sucesso!";
                cadastrado = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o Banco de Dados!";
            }
            return mensagem;
        }

        public bool PesquisarCPF(string cpf)
        {
            cmd.CommandText = "SELECT * FROM TBRegistroFuncionarios WHERE CPF = @cpf";
            cmd.Parameters.AddWithValue("@CPF", cpf);

            try
            {
                cmd.Connection = conectar.Conectar();
                dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cadastrado = true;
                }
                conectar.Desconectar();
                dataReader.Close();
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }
            return cadastrado;
        }

        public string EmitirFolhaDePagamento(string cpf, string total_venc, string base_fgts, string descontos, string base_inss, string liquido_receber, string fgts_mes, string salario)
        {
            cadastrado = false;
            cmd.CommandText = "insert into TBFolhasDePagamento values (@CPF, @TOTAL_VENC, @BASE_FGTS, @DESCONTOS, @BASE_INSS, @LIQUIDO_RECEBER, @FGTS_MES, @SALARIO);";
            cmd.Parameters.AddWithValue("@CPF", cpf);
            cmd.Parameters.AddWithValue("@TOTAL_VENC", total_venc);
            cmd.Parameters.AddWithValue("@BASE_FGTS", base_fgts);
            cmd.Parameters.AddWithValue("@DESCONTOS", descontos);
            cmd.Parameters.AddWithValue("@BASE_INSS", base_inss);
            cmd.Parameters.AddWithValue("@LIQUIDO_RECEBER", liquido_receber);
            cmd.Parameters.AddWithValue("@FGTS_MES", fgts_mes);
            cmd.Parameters.AddWithValue("@SALARIO", salario);

            try
            {
                cmd.Connection = conectar.Conectar();
                cmd.ExecuteNonQuery();
                conectar.Desconectar();
                this.mensagem = "Folha emitida com sucesso!";
                cadastrado = true;
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados!";
            }
            return mensagem;
        }
    }
}
