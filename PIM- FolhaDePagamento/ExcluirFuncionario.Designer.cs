namespace PIM__FolhaDePagamento
{
    partial class ExcluirFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcluirFuncionario));
            dataGridView1 = new DataGridView();
            txtPesquisarCPF = new MaskedTextBox();
            btnPesquisarCPF__ExcluirFuncionario = new Button();
            label14 = new Label();
            label1 = new Label();
            btnVoltar__ExcluirFuncionario = new Button();
            btnExcluirFuncionario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(192, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(415, 222);
            dataGridView1.TabIndex = 104;
            // 
            // txtPesquisarCPF
            // 
            txtPesquisarCPF.Location = new Point(396, 87);
            txtPesquisarCPF.Mask = "000,000,000\\-00";
            txtPesquisarCPF.Name = "txtPesquisarCPF";
            txtPesquisarCPF.Size = new Size(144, 23);
            txtPesquisarCPF.TabIndex = 103;
            // 
            // btnPesquisarCPF__ExcluirFuncionario
            // 
            btnPesquisarCPF__ExcluirFuncionario.FlatAppearance.BorderSize = 0;
            btnPesquisarCPF__ExcluirFuncionario.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnPesquisarCPF__ExcluirFuncionario.FlatStyle = FlatStyle.Flat;
            btnPesquisarCPF__ExcluirFuncionario.Image = (Image)resources.GetObject("btnPesquisarCPF__ExcluirFuncionario.Image");
            btnPesquisarCPF__ExcluirFuncionario.Location = new Point(546, 82);
            btnPesquisarCPF__ExcluirFuncionario.Name = "btnPesquisarCPF__ExcluirFuncionario";
            btnPesquisarCPF__ExcluirFuncionario.Size = new Size(63, 38);
            btnPesquisarCPF__ExcluirFuncionario.TabIndex = 102;
            btnPesquisarCPF__ExcluirFuncionario.UseVisualStyleBackColor = true;
            btnPesquisarCPF__ExcluirFuncionario.Click += btnPesquisarCPF__ExcluirFuncionario_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(194, 85);
            label14.Name = "label14";
            label14.Size = new Size(196, 29);
            label14.TabIndex = 101;
            label14.Text = "CPF do funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(276, 40);
            label1.TabIndex = 105;
            label1.Text = "Excluir funcionário";
            // 
            // btnVoltar__ExcluirFuncionario
            // 
            btnVoltar__ExcluirFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar__ExcluirFuncionario.Location = new Point(288, 472);
            btnVoltar__ExcluirFuncionario.Name = "btnVoltar__ExcluirFuncionario";
            btnVoltar__ExcluirFuncionario.Size = new Size(229, 40);
            btnVoltar__ExcluirFuncionario.TabIndex = 106;
            btnVoltar__ExcluirFuncionario.Text = "Voltar";
            btnVoltar__ExcluirFuncionario.UseVisualStyleBackColor = true;
            btnVoltar__ExcluirFuncionario.Click += btnVoltar__ExcluirFuncionario_Click;
            // 
            // btnExcluirFuncionario
            // 
            btnExcluirFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExcluirFuncionario.Location = new Point(288, 408);
            btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            btnExcluirFuncionario.Size = new Size(229, 40);
            btnExcluirFuncionario.TabIndex = 107;
            btnExcluirFuncionario.Text = "Excluir funcionário";
            btnExcluirFuncionario.UseVisualStyleBackColor = true;
            btnExcluirFuncionario.Click += btnExcluirFuncionario_Click;
            // 
            // ExcluirFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(btnExcluirFuncionario);
            Controls.Add(btnVoltar__ExcluirFuncionario);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisarCPF);
            Controls.Add(btnPesquisarCPF__ExcluirFuncionario);
            Controls.Add(label14);
            Name = "ExcluirFuncionario";
            Text = "ExcluirFuncionario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MaskedTextBox txtPesquisarCPF;
        private Button btnPesquisarCPF__ExcluirFuncionario;
        private Label label14;
        private Label label1;
        private Button btnVoltar__ExcluirFuncionario;
        private Button btnExcluirFuncionario;
    }
}