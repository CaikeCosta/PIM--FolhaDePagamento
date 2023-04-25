namespace PIM__FolhaDePagamento
{
    partial class TelaLogada
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnInserirCPF_Funcionario = new System.Windows.Forms.Button();
            this.buttonLGPD = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOT - Best Of Tickets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(409, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recursos Humanos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(394, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = " Bem-vindo (Nome RH)";
            // 
            // buttonCadastrarFuncionario
            // 
            this.buttonCadastrarFuncionario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCadastrarFuncionario.Location = new System.Drawing.Point(333, 202);
            this.buttonCadastrarFuncionario.Name = "buttonCadastrarFuncionario";
            this.buttonCadastrarFuncionario.Size = new System.Drawing.Size(288, 36);
            this.buttonCadastrarFuncionario.TabIndex = 3;
            this.buttonCadastrarFuncionario.Text = "Cadastrar funcionário";
            this.buttonCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.buttonCadastrarFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserirCPF_Funcionario
            // 
            this.btnInserirCPF_Funcionario.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirCPF_Funcionario.Location = new System.Drawing.Point(333, 261);
            this.btnInserirCPF_Funcionario.Name = "btnInserirCPF_Funcionario";
            this.btnInserirCPF_Funcionario.Size = new System.Drawing.Size(288, 36);
            this.btnInserirCPF_Funcionario.TabIndex = 4;
            this.btnInserirCPF_Funcionario.Text = "Verificar funcionário";
            this.btnInserirCPF_Funcionario.UseVisualStyleBackColor = true;
            this.btnInserirCPF_Funcionario.Click += new System.EventHandler(this.buttonVerificarFuncionario_Click);
            // 
            // buttonLGPD
            // 
            this.buttonLGPD.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLGPD.Location = new System.Drawing.Point(333, 321);
            this.buttonLGPD.Name = "buttonLGPD";
            this.buttonLGPD.Size = new System.Drawing.Size(288, 36);
            this.buttonLGPD.TabIndex = 5;
            this.buttonLGPD.Text = "LGPD";
            this.buttonLGPD.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.Location = new System.Drawing.Point(333, 382);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(288, 36);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // TelaLogada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 559);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonLGPD);
            this.Controls.Add(this.btnInserirCPF_Funcionario);
            this.Controls.Add(this.buttonCadastrarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaLogada";
            this.Text = "TelaLogada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaLogada_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCadastrarFuncionario;
        private Button btnInserirCPF_Funcionario;
        private Button buttonLGPD;
        private Button buttonSair;
    }
}