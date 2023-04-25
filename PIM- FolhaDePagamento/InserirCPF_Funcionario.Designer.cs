namespace PIM__FolhaDePagamento
{
    partial class InserirCPF_Funcionario
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
            this.btnVerificarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltar__InserirCPF_Funcionario = new System.Windows.Forms.Button();
            this.txtCPF_Funcionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOT - Best Of Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(353, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Verificar funcionário";
            // 
            // btnVerificarFuncionario
            // 
            this.btnVerificarFuncionario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerificarFuncionario.Location = new System.Drawing.Point(369, 229);
            this.btnVerificarFuncionario.Name = "btnVerificarFuncionario";
            this.btnVerificarFuncionario.Size = new System.Drawing.Size(103, 33);
            this.btnVerificarFuncionario.TabIndex = 4;
            this.btnVerificarFuncionario.Text = "Continuar";
            this.btnVerificarFuncionario.UseVisualStyleBackColor = true;
            this.btnVerificarFuncionario.Click += new System.EventHandler(this.btnVerificarFuncionario_Click);
            // 
            // btnVoltar__InserirCPF_Funcionario
            // 
            this.btnVoltar__InserirCPF_Funcionario.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar__InserirCPF_Funcionario.Location = new System.Drawing.Point(369, 282);
            this.btnVoltar__InserirCPF_Funcionario.Name = "btnVoltar__InserirCPF_Funcionario";
            this.btnVoltar__InserirCPF_Funcionario.Size = new System.Drawing.Size(103, 33);
            this.btnVoltar__InserirCPF_Funcionario.TabIndex = 5;
            this.btnVoltar__InserirCPF_Funcionario.Text = "Voltar";
            this.btnVoltar__InserirCPF_Funcionario.UseVisualStyleBackColor = true;
            this.btnVoltar__InserirCPF_Funcionario.Click += new System.EventHandler(this.btnVoltar__InserirCPF_Funcionario_Click);
            // 
            // txtCPF_Funcionario
            // 
            this.txtCPF_Funcionario.Location = new System.Drawing.Point(341, 161);
            this.txtCPF_Funcionario.Name = "txtCPF_Funcionario";
            this.txtCPF_Funcionario.PlaceholderText = "Insira o CPF";
            this.txtCPF_Funcionario.Size = new System.Drawing.Size(168, 23);
            this.txtCPF_Funcionario.TabIndex = 6;
            this.txtCPF_Funcionario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCPF_Funcionario_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(242, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Insira o CPF";
            // 
            // InserirCPF_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCPF_Funcionario);
            this.Controls.Add(this.btnVoltar__InserirCPF_Funcionario);
            this.Controls.Add(this.btnVerificarFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InserirCPF_Funcionario";
            this.Text = "Inserir CPF do Funcionário";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InserirCPF_Funcionario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVerificarFuncionario;
        private Button btnVoltar__InserirCPF_Funcionario;
        private TextBox txtCPF_Funcionario;
        private Label label3;
    }
}