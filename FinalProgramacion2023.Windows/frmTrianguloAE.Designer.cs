namespace FinalProgramacion2023.Windows
{
    partial class frmTrianguloAE
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
            txtLadoA = new TextBox();
            label2 = new Label();
            txtLadoB = new TextBox();
            label3 = new Label();
            txtLadoC = new TextBox();
            btnOK = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            cboRelleno = new ComboBox();
            groupBox1 = new GroupBox();
            rbtPuntos = new RadioButton();
            rbtRayas = new RadioButton();
            rbtLineal = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Lado A:";
            // 
            // txtLadoA
            // 
            txtLadoA.Location = new Point(102, 16);
            txtLadoA.Margin = new Padding(3, 4, 3, 4);
            txtLadoA.Name = "txtLadoA";
            txtLadoA.Size = new Size(114, 27);
            txtLadoA.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Lado B;";
            // 
            // txtLadoB
            // 
            txtLadoB.Location = new Point(102, 55);
            txtLadoB.Margin = new Padding(3, 4, 3, 4);
            txtLadoB.Name = "txtLadoB";
            txtLadoB.Size = new Size(114, 27);
            txtLadoB.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 97);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Lado C:";
            // 
            // txtLadoC
            // 
            txtLadoC.Location = new Point(102, 93);
            txtLadoC.Margin = new Padding(3, 4, 3, 4);
            txtLadoC.Name = "txtLadoC";
            txtLadoC.Size = new Size(114, 27);
            txtLadoC.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(33, 292);
            btnOK.Margin = new Padding(3, 4, 3, 4);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(86, 81);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(272, 292);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 81);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 144);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Relleno:";
            // 
            // cboRelleno
            // 
            cboRelleno.FormattingEnabled = true;
            cboRelleno.Location = new Point(102, 140);
            cboRelleno.Margin = new Padding(3, 4, 3, 4);
            cboRelleno.Name = "cboRelleno";
            cboRelleno.Size = new Size(138, 28);
            cboRelleno.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtPuntos);
            groupBox1.Controls.Add(rbtRayas);
            groupBox1.Controls.Add(rbtLineal);
            groupBox1.Location = new Point(33, 179);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(325, 101);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = " Bordes ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbtPuntos
            // 
            rbtPuntos.AutoSize = true;
            rbtPuntos.Location = new Point(192, 39);
            rbtPuntos.Margin = new Padding(3, 4, 3, 4);
            rbtPuntos.Name = "rbtPuntos";
            rbtPuntos.Size = new Size(74, 24);
            rbtPuntos.TabIndex = 0;
            rbtPuntos.TabStop = true;
            rbtPuntos.Text = "Puntos";
            rbtPuntos.UseVisualStyleBackColor = true;
            // 
            // rbtRayas
            // 
            rbtRayas.AutoSize = true;
            rbtRayas.Location = new Point(102, 39);
            rbtRayas.Margin = new Padding(3, 4, 3, 4);
            rbtRayas.Name = "rbtRayas";
            rbtRayas.Size = new Size(68, 24);
            rbtRayas.TabIndex = 0;
            rbtRayas.TabStop = true;
            rbtRayas.Text = "Rayas";
            rbtRayas.UseVisualStyleBackColor = true;
            // 
            // rbtLineal
            // 
            rbtLineal.AutoSize = true;
            rbtLineal.Location = new Point(17, 39);
            rbtLineal.Margin = new Padding(3, 4, 3, 4);
            rbtLineal.Name = "rbtLineal";
            rbtLineal.Size = new Size(69, 24);
            rbtLineal.TabIndex = 0;
            rbtLineal.TabStop = true;
            rbtLineal.Text = "Lineal";
            rbtLineal.UseVisualStyleBackColor = true;
            // 
            // frmTrianguloAE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 389);
            Controls.Add(groupBox1);
            Controls.Add(cboRelleno);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(txtLadoC);
            Controls.Add(label3);
            Controls.Add(txtLadoB);
            Controls.Add(label2);
            Controls.Add(txtLadoA);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTrianguloAE";
            Text = "frmTrianguloAE";
            Load += frmTrianguloAE_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLadoA;
        private Label label2;
        private TextBox txtLadoB;
        private Label label3;
        private TextBox txtLadoC;
        private Button btnOK;
        private Button btnCancelar;
        private Label label4;
        private ComboBox cboRelleno;
        private GroupBox groupBox1;
        private RadioButton rbtPuntos;
        private RadioButton rbtRayas;
        private RadioButton rbtLineal;
    }
}