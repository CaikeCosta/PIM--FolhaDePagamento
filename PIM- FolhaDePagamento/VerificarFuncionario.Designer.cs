namespace PIM__FolhaDePagamento
{
    partial class VerificarFuncionario
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
            btnEditarFuncionario = new Button();
            btnVerificarFolhaPagamento = new Button();
            btnEmitirFolhaPagamento = new Button();
            btnVoltarVerificarFuncionario = new Button();
            btnExcluirFuncionario = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEditarFuncionario
            // 
            btnEditarFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarFuncionario.Location = new Point(363, 170);
            btnEditarFuncionario.Name = "btnEditarFuncionario";
            btnEditarFuncionario.Size = new Size(311, 36);
            btnEditarFuncionario.TabIndex = 1;
            btnEditarFuncionario.Text = "Editar registro de funcionário";
            btnEditarFuncionario.UseVisualStyleBackColor = true;
            btnEditarFuncionario.Click += btnEditarFuncionario_Click;
            // 
            // btnVerificarFolhaPagamento
            // 
            btnVerificarFolhaPagamento.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerificarFolhaPagamento.Location = new Point(363, 272);
            btnVerificarFolhaPagamento.Name = "btnVerificarFolhaPagamento";
            btnVerificarFolhaPagamento.Size = new Size(311, 36);
            btnVerificarFolhaPagamento.TabIndex = 3;
            btnVerificarFolhaPagamento.Text = "Verificar folha de pagamento";
            btnVerificarFolhaPagamento.UseVisualStyleBackColor = true;
            btnVerificarFolhaPagamento.Click += btnVerificarFolhaPagamento_Click;
            // 
            // btnEmitirFolhaPagamento
            // 
            btnEmitirFolhaPagamento.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmitirFolhaPagamento.Location = new Point(363, 221);
            btnEmitirFolhaPagamento.Name = "btnEmitirFolhaPagamento";
            btnEmitirFolhaPagamento.Size = new Size(311, 36);
            btnEmitirFolhaPagamento.TabIndex = 4;
            btnEmitirFolhaPagamento.Text = "Emitir folha de pagamento";
            btnEmitirFolhaPagamento.UseVisualStyleBackColor = true;
            btnEmitirFolhaPagamento.Click += btnEmitirFolhaPagamento_Click;
            // 
            // btnVoltarVerificarFuncionario
            // 
            btnVoltarVerificarFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarVerificarFuncionario.Location = new Point(363, 427);
            btnVoltarVerificarFuncionario.Name = "btnVoltarVerificarFuncionario";
            btnVoltarVerificarFuncionario.Size = new Size(311, 36);
            btnVoltarVerificarFuncionario.TabIndex = 6;
            btnVoltarVerificarFuncionario.Text = "Voltar";
            btnVoltarVerificarFuncionario.UseVisualStyleBackColor = true;
            btnVoltarVerificarFuncionario.Click += btnVoltarVerificarFuncionario_Click;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirFuncionario.Location = new Point(363, 323);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(311, 36);
            btnExcluirFuncionario.TabIndex = 7;
            btnExcluirFuncionario.Text = "Excluir registro de funcionário";
            btnExcluirFuncionario.UseVisualStyleBackColor = true;
            btnExcluirFuncionario.Click += btnExcluirFuncionario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(337, 73);
            label1.Name = "label1";
            label1.Size = new Size(372, 49);
            label1.TabIndex = 8;
            label1.Text = "Verificar funcionário";
            // 
            // VerificarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 544);
            Controls.Add(label1);
            Controls.Add(btnExcluirFuncionario);
            Controls.Add(btnVoltarVerificarFuncionario);
            Controls.Add(btnEmitirFolhaPagamento);
            Controls.Add(btnVerificarFolhaPagamento);
            Controls.Add(btnEditarFuncionario);
            Name = "VerificarFuncionario";
            Text = "VerificarFuncionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEditarFuncionario;
        private Button btnVerificarFolhaPagamento;
        private Button btnEmitirFolhaPagamento;
        private Button btnVoltarVerificarFuncionario;
        private Button btnExcluirFuncionario;
        private Label label1;
    }
}