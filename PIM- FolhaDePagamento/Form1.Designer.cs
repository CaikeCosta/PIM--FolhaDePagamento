namespace PIM__FolhaDePagamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            txtLogin = new TextBox();
            txtSenha = new TextBox();
            botaoEntrar = new Button();
            pictureBox2 = new PictureBox();
            btnEsqueciSenha = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(355, 83);
            label2.Name = "label2";
            label2.Size = new Size(162, 33);
            label2.TabIndex = 1;
            label2.Text = "Área de login";
            label2.Click += label2_Click;
            // 
            // txtLogin
            // 
            txtLogin.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogin.Location = new Point(302, 137);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(268, 26);
            txtLogin.TabIndex = 2;
            txtLogin.TextChanged += textBox1_TextChanged;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Location = new Point(302, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(268, 26);
            txtSenha.TabIndex = 3;
            txtSenha.TextChanged += txtSenha_TextChanged;
            // 
            // botaoEntrar
            // 
            botaoEntrar.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            botaoEntrar.Location = new Point(366, 241);
            botaoEntrar.Name = "botaoEntrar";
            botaoEntrar.Size = new Size(117, 49);
            botaoEntrar.TabIndex = 4;
            botaoEntrar.Text = "Entrar";
            botaoEntrar.UseVisualStyleBackColor = true;
            botaoEntrar.Click += botaoEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(248, 238);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // btnEsqueciSenha
            // 
            btnEsqueciSenha.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEsqueciSenha.Location = new Point(366, 306);
            btnEsqueciSenha.Name = "btnEsqueciSenha";
            btnEsqueciSenha.Size = new Size(117, 49);
            btnEsqueciSenha.TabIndex = 6;
            btnEsqueciSenha.Text = "Esqueci a senha";
            btnEsqueciSenha.UseVisualStyleBackColor = true;
            btnEsqueciSenha.Click += btnEsqueciSenha_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 399);
            Controls.Add(btnEsqueciSenha);
            Controls.Add(pictureBox2);
            Controls.Add(botaoEntrar);
            Controls.Add(txtSenha);
            Controls.Add(txtLogin);
            Controls.Add(label2);
            KeyPreview = true;
            Name = "Form1";
            Text = "BOTRH - LOGIN";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtLogin;
        private TextBox txtSenha;
        private Button botaoEntrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnEsqueciSenha;
    }
}