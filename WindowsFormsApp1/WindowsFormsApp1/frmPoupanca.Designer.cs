namespace WindowsFormsApp1
{
    partial class frmPoupanca
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblPrevSaque = new System.Windows.Forms.Label();
            this.txtPrevSaque = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(39, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(39, 59);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(257, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(117, 59);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(257, 20);
            this.txtSaldo.TabIndex = 3;
            // 
            // lblPrevSaque
            // 
            this.lblPrevSaque.AutoSize = true;
            this.lblPrevSaque.Location = new System.Drawing.Point(42, 124);
            this.lblPrevSaque.Name = "lblPrevSaque";
            this.lblPrevSaque.Size = new System.Drawing.Size(100, 13);
            this.lblPrevSaque.TabIndex = 4;
            this.lblPrevSaque.Text = "Precisão de Saque:";
            // 
            // txtPrevSaque
            // 
            this.txtPrevSaque.Location = new System.Drawing.Point(149, 124);
            this.txtPrevSaque.Name = "txtPrevSaque";
            this.txtPrevSaque.Size = new System.Drawing.Size(225, 20);
            this.txtPrevSaque.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(42, 198);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // frmPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrevSaque);
            this.Controls.Add(this.lblPrevSaque);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblName);
            this.Name = "frmPoupanca";
            this.Text = "frmPoupanca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblPrevSaque;
        private System.Windows.Forms.TextBox txtPrevSaque;
        private System.Windows.Forms.Button btnCalcular;
    }
}