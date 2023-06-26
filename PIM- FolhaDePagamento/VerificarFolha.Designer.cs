namespace PIM__FolhaDePagamento
{
    partial class VerificarFolha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificarFolha));
            txtPesquisarCPF = new MaskedTextBox();
            btnPesquisarCPF__VerificarFolha = new Button();
            label14 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnVoltar__VerificarFolha = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPesquisarCPF
            // 
            txtPesquisarCPF.Location = new Point(414, 110);
            txtPesquisarCPF.Mask = "000,000,000\\-00";
            txtPesquisarCPF.Name = "txtPesquisarCPF";
            txtPesquisarCPF.Size = new Size(144, 23);
            txtPesquisarCPF.TabIndex = 98;
            // 
            // btnPesquisarCPF__VerificarFolha
            // 
            btnPesquisarCPF__VerificarFolha.FlatAppearance.BorderSize = 0;
            btnPesquisarCPF__VerificarFolha.FlatAppearance.MouseDownBackColor = Color.Yellow;
            btnPesquisarCPF__VerificarFolha.FlatStyle = FlatStyle.Flat;
            btnPesquisarCPF__VerificarFolha.Image = (Image)resources.GetObject("btnPesquisarCPF__VerificarFolha.Image");
            btnPesquisarCPF__VerificarFolha.Location = new Point(564, 105);
            btnPesquisarCPF__VerificarFolha.Name = "btnPesquisarCPF__VerificarFolha";
            btnPesquisarCPF__VerificarFolha.Size = new Size(63, 38);
            btnPesquisarCPF__VerificarFolha.TabIndex = 97;
            btnPesquisarCPF__VerificarFolha.UseVisualStyleBackColor = true;
            btnPesquisarCPF__VerificarFolha.Click += btnPesquisarCPF__VerificarFolha_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(212, 108);
            label14.Name = "label14";
            label14.Size = new Size(196, 29);
            label14.TabIndex = 96;
            label14.Text = "CPF do funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 40);
            label1.TabIndex = 99;
            label1.Text = "Verificar folha de pagamento";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(415, 222);
            dataGridView1.TabIndex = 100;
            // 
            // btnVoltar__VerificarFolha
            // 
            btnVoltar__VerificarFolha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar__VerificarFolha.Location = new Point(311, 424);
            btnVoltar__VerificarFolha.Name = "btnVoltar__VerificarFolha";
            btnVoltar__VerificarFolha.Size = new Size(229, 40);
            btnVoltar__VerificarFolha.TabIndex = 101;
            btnVoltar__VerificarFolha.Text = "Voltar";
            btnVoltar__VerificarFolha.UseVisualStyleBackColor = true;
            btnVoltar__VerificarFolha.Click += btnVoltar__VerificarFolha_Click;
            // 
            // VerificarFolha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 505);
            Controls.Add(btnVoltar__VerificarFolha);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txtPesquisarCPF);
            Controls.Add(btnPesquisarCPF__VerificarFolha);
            Controls.Add(label14);
            Name = "VerificarFolha";
            Text = "VerificarFolha";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtPesquisarCPF;
        private Button btnPesquisarCPF__VerificarFolha;
        private Label label14;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnVoltar__VerificarFolha;
    }
}