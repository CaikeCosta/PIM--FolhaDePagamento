namespace PIM__FolhaDePagamento
{
    partial class Empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVoltarEmpresa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(767, 78);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(297, 9);
            label2.Name = "label2";
            label2.Size = new Size(229, 38);
            label2.TabIndex = 1;
            label2.Text = "Sobre a empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(743, 78);
            label3.TabIndex = 2;
            label3.Text = "Para que você consiga exercer o seu trabalho com excelência nós disponibilizamos o \r\nRH!SAFE, um software no qual você tem toda a facilidade para acompanhar \r\ninformações de nossos funcionários.";
            // 
            // btnVoltarEmpresa
            // 
            btnVoltarEmpresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltarEmpresa.Location = new Point(297, 350);
            btnVoltarEmpresa.Name = "btnVoltarEmpresa";
            btnVoltarEmpresa.Size = new Size(229, 40);
            btnVoltarEmpresa.TabIndex = 3;
            btnVoltarEmpresa.Text = "Voltar";
            btnVoltarEmpresa.UseVisualStyleBackColor = true;
            btnVoltarEmpresa.Click += btnVoltarEmpresa_Click;
            // 
            // Empresa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 474);
            Controls.Add(btnVoltarEmpresa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Empresa";
            Text = "Empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVoltarEmpresa;
    }
}