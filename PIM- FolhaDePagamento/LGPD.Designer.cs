namespace PIM__FolhaDePagamento
{
    partial class LGPD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LGPD));
            label1 = new Label();
            label2 = new Label();
            btnVoltar__LGPD = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(272, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 38);
            label1.TabIndex = 0;
            label1.Text = "Lei LGPD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(641, 182);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnVoltar__LGPD
            // 
            btnVoltar__LGPD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar__LGPD.Location = new Point(217, 331);
            btnVoltar__LGPD.Name = "btnVoltar__LGPD";
            btnVoltar__LGPD.Size = new Size(229, 40);
            btnVoltar__LGPD.TabIndex = 2;
            btnVoltar__LGPD.Text = "Voltar";
            btnVoltar__LGPD.UseVisualStyleBackColor = true;
            btnVoltar__LGPD.Click += btnVoltar__LGPD_Click;
            // 
            // LGPD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 424);
            Controls.Add(btnVoltar__LGPD);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LGPD";
            Text = "LGPD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnVoltar__LGPD;
    }
}