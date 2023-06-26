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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogada));
            btnCadastrarFuncionario = new Button();
            btnInserirCPF_Funcionario = new Button();
            buttonLGPD = new Button();
            buttonSair = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarFuncionario
            // 
            btnCadastrarFuncionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrarFuncionario.Location = new Point(171, 210);
            btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            btnCadastrarFuncionario.Size = new Size(288, 36);
            btnCadastrarFuncionario.TabIndex = 3;
            btnCadastrarFuncionario.Text = "Cadastrar funcionário";
            btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            btnCadastrarFuncionario.Click += btnCadastrarFuncionario_Click;
            // 
            // btnInserirCPF_Funcionario
            // 
            btnInserirCPF_Funcionario.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInserirCPF_Funcionario.Location = new Point(171, 261);
            btnInserirCPF_Funcionario.Name = "btnInserirCPF_Funcionario";
            btnInserirCPF_Funcionario.Size = new Size(288, 36);
            btnInserirCPF_Funcionario.TabIndex = 4;
            btnInserirCPF_Funcionario.Text = "Verificar funcionário";
            btnInserirCPF_Funcionario.UseVisualStyleBackColor = true;
            btnInserirCPF_Funcionario.Click += buttonVerificarFuncionario_Click;
            // 
            // buttonLGPD
            // 
            buttonLGPD.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLGPD.Location = new Point(171, 312);
            buttonLGPD.Name = "buttonLGPD";
            buttonLGPD.Size = new Size(288, 36);
            buttonLGPD.TabIndex = 5;
            buttonLGPD.Text = "LGPD";
            buttonLGPD.UseVisualStyleBackColor = true;
            buttonLGPD.Click += buttonLGPD_Click;
            // 
            // buttonSair
            // 
            buttonSair.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSair.Location = new Point(171, 450);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(288, 36);
            buttonSair.TabIndex = 6;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 202);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(171, 363);
            button1.Name = "button1";
            button1.Size = new Size(288, 36);
            button1.TabIndex = 9;
            button1.Text = "Empresa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEmpresa_Click;
            // 
            // TelaLogada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 546);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSair);
            Controls.Add(buttonLGPD);
            Controls.Add(btnInserirCPF_Funcionario);
            Controls.Add(btnCadastrarFuncionario);
            Name = "TelaLogada";
            Text = "TelaLogada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCadastrarFuncionario;
        private Button btnInserirCPF_Funcionario;
        private Button buttonLGPD;
        private Button buttonSair;
        private PictureBox pictureBox1;
        private Button button1;
    }
}