namespace WindowsFormsApp1
{
    partial class Form3
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
            this.txtValorInteiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorDecimal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSomar1 = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnFormula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Testando valores inteiro";
            // 
            // txtValorInteiro
            // 
            this.txtValorInteiro.Location = new System.Drawing.Point(171, 28);
            this.txtValorInteiro.Name = "txtValorInteiro";
            this.txtValorInteiro.Size = new System.Drawing.Size(100, 20);
            this.txtValorInteiro.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Testando Valores Decimais";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // txtValorDecimal
            // 
            this.txtValorDecimal.Location = new System.Drawing.Point(171, 64);
            this.txtValorDecimal.Name = "txtValorDecimal";
            this.txtValorDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtValorDecimal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Testando Datas";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(171, 105);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(171, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnSomar1
            // 
            this.btnSomar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar1.Location = new System.Drawing.Point(171, 207);
            this.btnSomar1.Name = "btnSomar1";
            this.btnSomar1.Size = new System.Drawing.Size(75, 23);
            this.btnSomar1.TabIndex = 7;
            this.btnSomar1.Text = "Somar +";
            this.btnSomar1.UseVisualStyleBackColor = true;
            this.btnSomar1.Click += new System.EventHandler(this.BtnSomar1_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(171, 248);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 8;
            this.btnSubtrair.Text = "Subtrair -";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.BtnSubtrair_Click);
            // 
            // btnFormula
            // 
            this.btnFormula.Location = new System.Drawing.Point(171, 297);
            this.btnFormula.Name = "btnFormula";
            this.btnFormula.Size = new System.Drawing.Size(75, 23);
            this.btnFormula.TabIndex = 9;
            this.btnFormula.Text = "Fórmula";
            this.btnFormula.UseVisualStyleBackColor = true;
            this.btnFormula.Click += new System.EventHandler(this.BtnFormula_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 378);
            this.Controls.Add(this.btnFormula);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnSomar1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorInteiro);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorInteiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorDecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSomar1;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnFormula;
    }
}