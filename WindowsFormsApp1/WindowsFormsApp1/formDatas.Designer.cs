namespace WindowsFormsApp1
{
    partial class formDatas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInformData = new System.Windows.Forms.TextBox();
            this.txtQdteDias = new System.Windows.Forms.TextBox();
            this.txtQdteMeses = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblQdteDias = new System.Windows.Forms.Label();
            this.lblQdteMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe uma data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de dias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de meses";
            // 
            // txtInformData
            // 
            this.txtInformData.Location = new System.Drawing.Point(156, 35);
            this.txtInformData.Name = "txtInformData";
            this.txtInformData.Size = new System.Drawing.Size(100, 20);
            this.txtInformData.TabIndex = 3;
            // 
            // txtQdteDias
            // 
            this.txtQdteDias.Location = new System.Drawing.Point(156, 71);
            this.txtQdteDias.Name = "txtQdteDias";
            this.txtQdteDias.Size = new System.Drawing.Size(100, 20);
            this.txtQdteDias.TabIndex = 4;
            // 
            // txtQdteMeses
            // 
            this.txtQdteMeses.Location = new System.Drawing.Point(156, 106);
            this.txtQdteMeses.Name = "txtQdteMeses";
            this.txtQdteMeses.Size = new System.Drawing.Size(100, 20);
            this.txtQdteMeses.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(51, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 173);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblQdteDias
            // 
            this.lblQdteDias.AutoSize = true;
            this.lblQdteDias.ForeColor = System.Drawing.Color.Blue;
            this.lblQdteDias.Location = new System.Drawing.Point(291, 77);
            this.lblQdteDias.Name = "lblQdteDias";
            this.lblQdteDias.Size = new System.Drawing.Size(0, 13);
            this.lblQdteDias.TabIndex = 8;
            // 
            // lblQdteMeses
            // 
            this.lblQdteMeses.AutoSize = true;
            this.lblQdteMeses.ForeColor = System.Drawing.Color.Blue;
            this.lblQdteMeses.Location = new System.Drawing.Point(291, 113);
            this.lblQdteMeses.Name = "lblQdteMeses";
            this.lblQdteMeses.Size = new System.Drawing.Size(0, 13);
            this.lblQdteMeses.TabIndex = 9;
            // 
            // formDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 216);
            this.Controls.Add(this.lblQdteMeses);
            this.Controls.Add(this.lblQdteDias);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtQdteMeses);
            this.Controls.Add(this.txtQdteDias);
            this.Controls.Add(this.txtInformData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formDatas";
            this.Text = "formDatas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInformData;
        private System.Windows.Forms.TextBox txtQdteDias;
        private System.Windows.Forms.TextBox txtQdteMeses;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblQdteDias;
        private System.Windows.Forms.Label lblQdteMeses;
    }
}