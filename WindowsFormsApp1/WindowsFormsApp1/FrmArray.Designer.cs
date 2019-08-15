namespace WindowsFormsApp1
{
    partial class FrmArray
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblTamanhoArray = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblPrimeiroItem = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblNomeLetraR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(194, 96);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblTamanhoArray
            // 
            this.lblTamanhoArray.AutoSize = true;
            this.lblTamanhoArray.Location = new System.Drawing.Point(160, 119);
            this.lblTamanhoArray.Name = "lblTamanhoArray";
            this.lblTamanhoArray.Size = new System.Drawing.Size(0, 13);
            this.lblTamanhoArray.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(194, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblPrimeiroItem
            // 
            this.lblPrimeiroItem.AutoSize = true;
            this.lblPrimeiroItem.Location = new System.Drawing.Point(194, 157);
            this.lblPrimeiroItem.Name = "lblPrimeiroItem";
            this.lblPrimeiroItem.Size = new System.Drawing.Size(74, 13);
            this.lblPrimeiroItem.TabIndex = 4;
            this.lblPrimeiroItem.Text = "lblPrimeiroItem";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(197, 198);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // lblNomeLetraR
            // 
            this.lblNomeLetraR.AutoSize = true;
            this.lblNomeLetraR.Location = new System.Drawing.Point(194, 248);
            this.lblNomeLetraR.Name = "lblNomeLetraR";
            this.lblNomeLetraR.Size = new System.Drawing.Size(77, 13);
            this.lblNomeLetraR.TabIndex = 6;
            this.lblNomeLetraR.Text = "lblNomeLetraR";
            // 
            // FrmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeLetraR);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblPrimeiroItem);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTamanhoArray);
            this.Controls.Add(this.btnOK);
            this.Name = "FrmArray";
            this.Text = "FrmArray";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblTamanhoArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblPrimeiroItem;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblNomeLetraR;
    }
}