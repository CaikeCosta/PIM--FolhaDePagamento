namespace PIM__FolhaDePagamento
{
    partial class EditarFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionario));
            cbDeficiencia = new ComboBox();
            label13 = new Label();
            cbCargo = new ComboBox();
            cbGenero = new ComboBox();
            cbEstado_civil = new ComboBox();
            btnVoltar_CadastroFuncionario = new Button();
            btnCadastrarFuncionario = new Button();
            txtSenhaOperacional = new TextBox();
            txtEmailOperacional = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtTelefone = new TextBox();
            txtCelular = new TextBox();
            txtLogadouro = new TextBox();
            txtComplemento = new TextBox();
            txtNumero = new TextBox();
            txtCEP = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtData_nasc = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtCPF = new TextBox();
            label5 = new Label();
            txtRG = new TextBox();
            btnAtualizar__EditarFuncionario = new Button();
            button2 = new Button();
            conexaoBindingSource = new BindingSource(components);
            label14 = new Label();
            button3 = new Button();
            txtPesquisarCPF = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cbDeficiencia
            // 
            cbDeficiencia.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbDeficiencia.FormattingEnabled = true;
            cbDeficiencia.Items.AddRange(new object[] { "Não possui", "Possui" });
            cbDeficiencia.Location = new Point(554, 665);
            cbDeficiencia.Margin = new Padding(4, 5, 4, 5);
            cbDeficiencia.Name = "cbDeficiencia";
            cbDeficiencia.Size = new Size(156, 31);
            cbDeficiencia.TabIndex = 88;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(554, 633);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(123, 29);
            label13.TabIndex = 87;
            label13.Text = "Deficiência";
            // 
            // cbCargo
            // 
            cbCargo.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbCargo.FormattingEnabled = true;
            cbCargo.Items.AddRange(new object[] { "Analista de dados", "Analista de redes", "Analista de suporte", "Financeiro", "Líder de operações", "RH", "Programador Júnior", "Programador Pleno", "Programador Sênior", "Programador Mobile" });
            cbCargo.Location = new Point(127, 585);
            cbCargo.Margin = new Padding(4, 5, 4, 5);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(975, 31);
            cbCargo.TabIndex = 86;
            // 
            // cbGenero
            // 
            cbGenero.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbGenero.FormattingEnabled = true;
            cbGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cbGenero.Location = new Point(948, 665);
            cbGenero.Margin = new Padding(4, 5, 4, 5);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(155, 31);
            cbGenero.TabIndex = 85;
            // 
            // cbEstado_civil
            // 
            cbEstado_civil.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbEstado_civil.FormattingEnabled = true;
            cbEstado_civil.Items.AddRange(new object[] { "Solteiro(a)", "Casado(a)", "Divorciado(a)", "Viúvo(a)", "Separado(a)" });
            cbEstado_civil.Location = new Point(127, 665);
            cbEstado_civil.Margin = new Padding(4, 5, 4, 5);
            cbEstado_civil.Name = "cbEstado_civil";
            cbEstado_civil.Size = new Size(155, 31);
            cbEstado_civil.TabIndex = 84;
            // 
            // btnVoltar_CadastroFuncionario
            // 
            btnVoltar_CadastroFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar_CadastroFuncionario.Location = new Point(630, 1236);
            btnVoltar_CadastroFuncionario.Margin = new Padding(4, 5, 4, 5);
            btnVoltar_CadastroFuncionario.Name = "btnVoltar_CadastroFuncionario";
            btnVoltar_CadastroFuncionario.Size = new Size(411, 55);
            btnVoltar_CadastroFuncionario.TabIndex = 83;
            btnVoltar_CadastroFuncionario.Text = "Voltar";
            btnVoltar_CadastroFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarFuncionario.Location = new Point(630, 1147);
            btnCadastrarFuncionario.Margin = new Padding(4, 5, 4, 5);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(411, 55);
            btnCadastrarFuncionario.TabIndex = 82;
            btnCadastrarFuncionario.Text = "Cadastrar";
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // txtSenhaOperacional
            // 
            txtSenhaOperacional.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaOperacional.Location = new Point(125, 804);
            txtSenhaOperacional.Margin = new Padding(4, 5, 4, 5);
            txtSenhaOperacional.Name = "txtSenhaOperacional";
            txtSenhaOperacional.PlaceholderText = "Senha operacional do funcionário";
            txtSenhaOperacional.Size = new Size(976, 30);
            txtSenhaOperacional.TabIndex = 81;
            // 
            // txtEmailOperacional
            // 
            txtEmailOperacional.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailOperacional.Location = new Point(127, 755);
            txtEmailOperacional.Margin = new Padding(4, 5, 4, 5);
            txtEmailOperacional.Name = "txtEmailOperacional";
            txtEmailOperacional.PlaceholderText = "Email operacional do funcionário";
            txtEmailOperacional.Size = new Size(976, 30);
            txtEmailOperacional.TabIndex = 80;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(125, 721);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(210, 29);
            label12.TabIndex = 79;
            label12.Text = "Login do funcionário";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(948, 633);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(81, 29);
            label11.TabIndex = 78;
            label11.Text = "Gênero";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(125, 633);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 29);
            label10.TabIndex = 77;
            label10.Text = "Estado civil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(125, 553);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(69, 29);
            label9.TabIndex = 76;
            label9.Text = "Cargo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(727, 481);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 29);
            label8.TabIndex = 75;
            label8.Text = "Telefone ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(125, 481);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 29);
            label7.TabIndex = 74;
            label7.Text = "Celular";
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefone.Location = new Point(729, 514);
            txtTelefone.Margin = new Padding(6);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(375, 30);
            txtTelefone.TabIndex = 73;
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelular.Location = new Point(127, 514);
            txtCelular.Margin = new Padding(6);
            txtCelular.Name = "txtCelular";
            txtCelular.ShortcutsEnabled = false;
            txtCelular.Size = new Size(415, 30);
            txtCelular.TabIndex = 72;
            // 
            // txtLogadouro
            // 
            txtLogadouro.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogadouro.Location = new Point(127, 431);
            txtLogadouro.Margin = new Padding(6);
            txtLogadouro.Name = "txtLogadouro";
            txtLogadouro.PlaceholderText = "Logadouro";
            txtLogadouro.Size = new Size(977, 30);
            txtLogadouro.TabIndex = 71;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(447, 382);
            txtComplemento.Margin = new Padding(6);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(657, 30);
            txtComplemento.TabIndex = 70;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(288, 382);
            txtNumero.Margin = new Padding(6, 8, 6, 8);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(142, 30);
            txtNumero.TabIndex = 69;
            // 
            // txtCEP
            // 
            txtCEP.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCEP.Location = new Point(127, 382);
            txtCEP.Margin = new Padding(6, 8, 6, 8);
            txtCEP.Name = "txtCEP";
            txtCEP.PlaceholderText = "CEP";
            txtCEP.Size = new Size(142, 30);
            txtCEP.TabIndex = 68;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(125, 348);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(104, 29);
            label6.TabIndex = 67;
            label6.Text = "Endereço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(505, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 40);
            label1.TabIndex = 58;
            label1.Text = "Editar funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(125, 200);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 29);
            label2.TabIndex = 59;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(126, 231);
            txtNome.Margin = new Padding(6, 8, 6, 8);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(416, 30);
            txtNome.TabIndex = 60;
            // 
            // txtData_nasc
            // 
            txtData_nasc.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtData_nasc.Location = new Point(727, 231);
            txtData_nasc.Margin = new Padding(6, 8, 6, 8);
            txtData_nasc.Name = "txtData_nasc";
            txtData_nasc.Size = new Size(376, 30);
            txtData_nasc.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(727, 200);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 29);
            label3.TabIndex = 62;
            label3.Text = "Data de nascimento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(126, 272);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 29);
            label4.TabIndex = 63;
            label4.Text = "CPF";
            // 
            // txtCPF
            // 
            txtCPF.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCPF.Location = new Point(126, 303);
            txtCPF.Margin = new Padding(6, 8, 6, 8);
            txtCPF.Name = "txtCPF";
            txtCPF.ReadOnly = true;
            txtCPF.Size = new Size(416, 30);
            txtCPF.TabIndex = 64;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(727, 272);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(40, 29);
            label5.TabIndex = 65;
            label5.Text = "RG";
            // 
            // txtRG
            // 
            txtRG.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRG.Location = new Point(727, 303);
            txtRG.Margin = new Padding(6, 8, 6, 8);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(376, 30);
            txtRG.TabIndex = 66;
            // 
            // btnAtualizar__EditarFuncionario
            // 
            btnAtualizar__EditarFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtualizar__EditarFuncionario.Location = new Point(458, 868);
            btnAtualizar__EditarFuncionario.Name = "btnAtualizar__EditarFuncionario";
            btnAtualizar__EditarFuncionario.Size = new Size(288, 36);
            btnAtualizar__EditarFuncionario.TabIndex = 89;
            btnAtualizar__EditarFuncionario.Text = "Atualizar";
            btnAtualizar__EditarFuncionario.UseVisualStyleBackColor = true;
            btnAtualizar__EditarFuncionario.Click += btnAtualizar__EditarFuncionario_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(458, 923);
            button2.Name = "button2";
            button2.Size = new Size(288, 36);
            button2.TabIndex = 90;
            button2.Text = "Voltar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnVoltar__EditarFuncionario_Click;
            // 
            // conexaoBindingSource
            // 
            conexaoBindingSource.DataSource = typeof(Utilitarios.Conexao);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(442, 112);
            label14.Name = "label14";
            label14.Size = new Size(196, 29);
            label14.TabIndex = 92;
            label14.Text = "CPF do funcionário";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Yellow;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(794, 109);
            button3.Name = "button3";
            button3.Size = new Size(63, 38);
            button3.TabIndex = 94;
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnPesquisarCPF__EditarFuncionario;
            // 
            // txtPesquisarCPF
            // 
            txtPesquisarCPF.Location = new Point(644, 114);
            txtPesquisarCPF.Mask = "000,000,000\\-00";
            txtPesquisarCPF.Name = "txtPesquisarCPF";
            txtPesquisarCPF.Size = new Size(144, 30);
            txtPesquisarCPF.TabIndex = 95;
            // 
            // EditarFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 988);
            Controls.Add(txtPesquisarCPF);
            Controls.Add(button3);
            Controls.Add(label14);
            Controls.Add(button2);
            Controls.Add(btnAtualizar__EditarFuncionario);
            Controls.Add(cbDeficiencia);
            Controls.Add(label13);
            Controls.Add(cbCargo);
            Controls.Add(cbGenero);
            Controls.Add(cbEstado_civil);
            Controls.Add(btnVoltar_CadastroFuncionario);
            Controls.Add(btnCadastrarFuncionario);
            Controls.Add(txtSenhaOperacional);
            Controls.Add(txtEmailOperacional);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtTelefone);
            Controls.Add(txtCelular);
            Controls.Add(txtLogadouro);
            Controls.Add(txtComplemento);
            Controls.Add(txtNumero);
            Controls.Add(txtCEP);
            Controls.Add(label6);
            Controls.Add(txtRG);
            Controls.Add(label5);
            Controls.Add(txtCPF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtData_nasc);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EditarFuncionario";
            Text = "EditarFuncionario";
            Load += EditarFuncionario_Load;
            ((System.ComponentModel.ISupportInitialize)conexaoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbDeficiencia;
        private Label label13;
        private ComboBox cbCargo;
        private ComboBox cbGenero;
        private ComboBox cbEstado_civil;
        private Button btnVoltar_CadastroFuncionario;
        private Button btnCadastrarFuncionario;
        private TextBox txtSenhaOperacional;
        private TextBox txtEmailOperacional;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtTelefone;
        private TextBox txtCelular;
        private TextBox txtLogadouro;
        private TextBox txtComplemento;
        private TextBox txtNumero;
        private TextBox txtCEP;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtData_nasc;
        private Label label3;
        private Label label4;
        private TextBox txtCPF;
        private Label label5;
        private TextBox txtRG;
        private Button btnAtualizar__EditarFuncionario;
        private Button button2;
        private BindingSource conexaoBindingSource;
        private Label label14;
        private Button button3;
        private MaskedTextBox txtPesquisarCPF;
    }
}