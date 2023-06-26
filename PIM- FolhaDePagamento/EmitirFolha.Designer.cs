namespace PIM__FolhaDePagamento
{
    partial class EmitirFolha
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
            label1 = new Label();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            txtSalarioBase = new TextBox();
            txtPericulosidade = new TextBox();
            txtHorasExtrasNoturno = new TextBox();
            txtHorasExtrasCem = new TextBox();
            txtHorasExtrasCinquenta = new TextBox();
            txtDescontosFixos = new TextBox();
            txtDSR = new TextBox();
            txtJornadaTrabalhoMensal = new TextBox();
            txtHorasTrabalhadas = new TextBox();
            btnCalcular = new Button();
            txtPesquisarCPF = new MaskedTextBox();
            label3 = new Label();
            txtBaseCalculoINSS = new TextBox();
            label16 = new Label();
            txtBaseCalculoFGTS = new TextBox();
            label15 = new Label();
            txtFGTS_Mes = new TextBox();
            label4 = new Label();
            txtLiquidoReceber = new TextBox();
            label5 = new Label();
            txtTotalDescontos = new TextBox();
            label6 = new Label();
            txtTotalVencimentos = new TextBox();
            label17 = new Label();
            btnEmitirFolha = new Button();
            btnVoltar__EmitirFolha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(493, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 45);
            label1.TabIndex = 0;
            label1.Text = "Emitir folha de pagamento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(175, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 1;
            label2.Text = "Salário Base (R$):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(724, 254);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(236, 23);
            label7.TabIndex = 6;
            label7.Text = "Horas Extraordinárias (100%):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(716, 358);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 23);
            label8.TabIndex = 7;
            label8.Text = "Adicional de Periculosidade (%):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(704, 304);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(256, 23);
            label9.TabIndex = 8;
            label9.Text = "Horas Extraordinárias (Noturno):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(731, 196);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(229, 23);
            label10.TabIndex = 9;
            label10.Text = "Horas Extraordinárias (50%):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(153, 411);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(171, 23);
            label11.TabIndex = 10;
            label11.Text = "Descontos Fixos (R$):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(55, 358);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(269, 23);
            label12.TabIndex = 11;
            label12.Text = "Descanso semanal remunerado (R$):";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(100, 304);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(224, 23);
            label13.TabIndex = 12;
            label13.Text = "Jornada de Trabalho Mensal:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(171, 250);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(153, 23);
            label14.TabIndex = 13;
            label14.Text = "Horas Trabalhadas:";
            // 
            // txtSalarioBase
            // 
            txtSalarioBase.Location = new Point(328, 193);
            txtSalarioBase.Margin = new Padding(4, 5, 4, 5);
            txtSalarioBase.Name = "txtSalarioBase";
            txtSalarioBase.Size = new Size(287, 30);
            txtSalarioBase.TabIndex = 14;
            // 
            // txtPericulosidade
            // 
            txtPericulosidade.Location = new Point(968, 355);
            txtPericulosidade.Margin = new Padding(4, 5, 4, 5);
            txtPericulosidade.Name = "txtPericulosidade";
            txtPericulosidade.Size = new Size(287, 30);
            txtPericulosidade.TabIndex = 16;
            // 
            // txtHorasExtrasNoturno
            // 
            txtHorasExtrasNoturno.Location = new Point(968, 301);
            txtHorasExtrasNoturno.Margin = new Padding(4, 5, 4, 5);
            txtHorasExtrasNoturno.Name = "txtHorasExtrasNoturno";
            txtHorasExtrasNoturno.Size = new Size(287, 30);
            txtHorasExtrasNoturno.TabIndex = 17;
            // 
            // txtHorasExtrasCem
            // 
            txtHorasExtrasCem.Location = new Point(968, 247);
            txtHorasExtrasCem.Margin = new Padding(4, 5, 4, 5);
            txtHorasExtrasCem.Name = "txtHorasExtrasCem";
            txtHorasExtrasCem.Size = new Size(287, 30);
            txtHorasExtrasCem.TabIndex = 18;
            // 
            // txtHorasExtrasCinquenta
            // 
            txtHorasExtrasCinquenta.Location = new Point(968, 193);
            txtHorasExtrasCinquenta.Margin = new Padding(4, 5, 4, 5);
            txtHorasExtrasCinquenta.Name = "txtHorasExtrasCinquenta";
            txtHorasExtrasCinquenta.Size = new Size(287, 30);
            txtHorasExtrasCinquenta.TabIndex = 19;
            // 
            // txtDescontosFixos
            // 
            txtDescontosFixos.Location = new Point(328, 409);
            txtDescontosFixos.Margin = new Padding(4, 5, 4, 5);
            txtDescontosFixos.Name = "txtDescontosFixos";
            txtDescontosFixos.Size = new Size(287, 30);
            txtDescontosFixos.TabIndex = 20;
            // 
            // txtDSR
            // 
            txtDSR.Location = new Point(328, 355);
            txtDSR.Margin = new Padding(4, 5, 4, 5);
            txtDSR.Name = "txtDSR";
            txtDSR.Size = new Size(287, 30);
            txtDSR.TabIndex = 21;
            // 
            // txtJornadaTrabalhoMensal
            // 
            txtJornadaTrabalhoMensal.Location = new Point(328, 301);
            txtJornadaTrabalhoMensal.Margin = new Padding(4, 5, 4, 5);
            txtJornadaTrabalhoMensal.Name = "txtJornadaTrabalhoMensal";
            txtJornadaTrabalhoMensal.Size = new Size(287, 30);
            txtJornadaTrabalhoMensal.TabIndex = 22;
            // 
            // txtHorasTrabalhadas
            // 
            txtHorasTrabalhadas.Location = new Point(328, 247);
            txtHorasTrabalhadas.Margin = new Padding(4, 5, 4, 5);
            txtHorasTrabalhadas.Name = "txtHorasTrabalhadas";
            txtHorasTrabalhadas.Size = new Size(287, 30);
            txtHorasTrabalhadas.TabIndex = 23;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(629, 490);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 46);
            btnCalcular.TabIndex = 24;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPesquisarCPF
            // 
            txtPesquisarCPF.Location = new Point(328, 122);
            txtPesquisarCPF.Mask = "000,000,000\\-00";
            txtPesquisarCPF.Name = "txtPesquisarCPF";
            txtPesquisarCPF.Size = new Size(144, 30);
            txtPesquisarCPF.TabIndex = 97;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(175, 125);
            label3.Name = "label3";
            label3.Size = new Size(147, 23);
            label3.TabIndex = 96;
            label3.Text = "CPF do funcionário";
            // 
            // txtBaseCalculoINSS
            // 
            txtBaseCalculoINSS.Location = new Point(723, 632);
            txtBaseCalculoINSS.Name = "txtBaseCalculoINSS";
            txtBaseCalculoINSS.ReadOnly = true;
            txtBaseCalculoINSS.Size = new Size(138, 30);
            txtBaseCalculoINSS.TabIndex = 109;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(580, 639);
            label16.Name = "label16";
            label16.Size = new Size(137, 23);
            label16.TabIndex = 108;
            label16.Text = "Base Cálc. INSS:";
            // 
            // txtBaseCalculoFGTS
            // 
            txtBaseCalculoFGTS.Location = new Point(328, 636);
            txtBaseCalculoFGTS.Name = "txtBaseCalculoFGTS";
            txtBaseCalculoFGTS.ReadOnly = true;
            txtBaseCalculoFGTS.Size = new Size(138, 30);
            txtBaseCalculoFGTS.TabIndex = 107;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(186, 639);
            label15.Name = "label15";
            label15.Size = new Size(136, 23);
            label15.TabIndex = 106;
            label15.Text = "Base Cálc. FGTS:";
            // 
            // txtFGTS_Mes
            // 
            txtFGTS_Mes.Location = new Point(1118, 632);
            txtFGTS_Mes.Name = "txtFGTS_Mes";
            txtFGTS_Mes.ReadOnly = true;
            txtFGTS_Mes.Size = new Size(137, 30);
            txtFGTS_Mes.TabIndex = 105;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1001, 635);
            label4.Name = "label4";
            label4.Size = new Size(111, 23);
            label4.TabIndex = 104;
            label4.Text = "FGTS do mês:";
            // 
            // txtLiquidoReceber
            // 
            txtLiquidoReceber.Location = new Point(1118, 576);
            txtLiquidoReceber.Name = "txtLiquidoReceber";
            txtLiquidoReceber.ReadOnly = true;
            txtLiquidoReceber.Size = new Size(137, 30);
            txtLiquidoReceber.TabIndex = 103;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(974, 579);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 102;
            label5.Text = "Líquido a receber";
            // 
            // txtTotalDescontos
            // 
            txtTotalDescontos.Location = new Point(723, 578);
            txtTotalDescontos.Name = "txtTotalDescontos";
            txtTotalDescontos.ReadOnly = true;
            txtTotalDescontos.Size = new Size(138, 30);
            txtTotalDescontos.TabIndex = 101;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(629, 585);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 100;
            label6.Text = "Descontos:";
            // 
            // txtTotalVencimentos
            // 
            txtTotalVencimentos.Location = new Point(328, 582);
            txtTotalVencimentos.Name = "txtTotalVencimentos";
            txtTotalVencimentos.ReadOnly = true;
            txtTotalVencimentos.Size = new Size(138, 30);
            txtTotalVencimentos.TabIndex = 99;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(155, 585);
            label17.Name = "label17";
            label17.Size = new Size(167, 23);
            label17.TabIndex = 98;
            label17.Text = "Total de vencimentos:";
            // 
            // btnEmitirFolha
            // 
            btnEmitirFolha.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEmitirFolha.Location = new Point(629, 729);
            btnEmitirFolha.Name = "btnEmitirFolha";
            btnEmitirFolha.Size = new Size(169, 46);
            btnEmitirFolha.TabIndex = 110;
            btnEmitirFolha.Text = "Emitir Folha";
            btnEmitirFolha.UseVisualStyleBackColor = true;
            btnEmitirFolha.Click += btnEmitirFolha_Click;
            // 
            // btnVoltar__EmitirFolha
            // 
            btnVoltar__EmitirFolha.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoltar__EmitirFolha.Location = new Point(629, 799);
            btnVoltar__EmitirFolha.Name = "btnVoltar__EmitirFolha";
            btnVoltar__EmitirFolha.Size = new Size(169, 46);
            btnVoltar__EmitirFolha.TabIndex = 111;
            btnVoltar__EmitirFolha.Text = "Voltar";
            btnVoltar__EmitirFolha.UseVisualStyleBackColor = true;
            btnVoltar__EmitirFolha.Click += btnVoltar__EmitirFolha_Click;
            // 
            // EmitirFolha
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 908);
            Controls.Add(btnVoltar__EmitirFolha);
            Controls.Add(btnEmitirFolha);
            Controls.Add(txtBaseCalculoINSS);
            Controls.Add(label16);
            Controls.Add(txtBaseCalculoFGTS);
            Controls.Add(label15);
            Controls.Add(txtFGTS_Mes);
            Controls.Add(label4);
            Controls.Add(txtLiquidoReceber);
            Controls.Add(label5);
            Controls.Add(txtTotalDescontos);
            Controls.Add(label6);
            Controls.Add(txtTotalVencimentos);
            Controls.Add(label17);
            Controls.Add(txtPesquisarCPF);
            Controls.Add(label3);
            Controls.Add(btnCalcular);
            Controls.Add(txtHorasTrabalhadas);
            Controls.Add(txtJornadaTrabalhoMensal);
            Controls.Add(txtDSR);
            Controls.Add(txtDescontosFixos);
            Controls.Add(txtHorasExtrasCinquenta);
            Controls.Add(txtHorasExtrasCem);
            Controls.Add(txtHorasExtrasNoturno);
            Controls.Add(txtPericulosidade);
            Controls.Add(txtSalarioBase);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "EmitirFolha";
            Text = " EmitirFolha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtSalarioBase;
        private TextBox txtPericulosidade;
        private TextBox txtHorasExtrasNoturno;
        private TextBox txtHorasExtrasCem;
        private TextBox txtHorasExtrasCinquenta;
        private TextBox txtDescontosFixos;
        private TextBox txtDSR;
        private TextBox txtJornadaTrabalhoMensal;
        private TextBox txtHorasTrabalhadas;
        private Button btnCalcular;
        private MaskedTextBox txtPesquisarCPF;
        private Label label3;
        private TextBox txtBaseCalculoINSS;
        private Label label16;
        private TextBox txtBaseCalculoFGTS;
        private Label label15;
        private TextBox txtFGTS_Mes;
        private Label label4;
        private TextBox txtLiquidoReceber;
        private Label label5;
        private TextBox txtTotalDescontos;
        private Label label6;
        private TextBox txtTotalVencimentos;
        private Label label17;
        private Button btnEmitirFolha;
        private Button btnVoltar__EmitirFolha;
    }
}