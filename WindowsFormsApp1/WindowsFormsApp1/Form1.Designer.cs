namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.btnCalcPoupanca = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblFormData = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnFrmArray = new System.Windows.Forms.Button();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(22, 74);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(202, 23);
            this.btnForm2.TabIndex = 2;
            this.btnForm2.Text = "Chamar Form2 30/07/2019";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.Location = new System.Drawing.Point(22, 103);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(202, 23);
            this.btnForm3.TabIndex = 4;
            this.btnForm3.Text = "Chamar Form3 30/07/2019";
            this.btnForm3.UseVisualStyleBackColor = true;
            this.btnForm3.Click += new System.EventHandler(this.BtnForm3_Click);
            // 
            // btnCalcPoupanca
            // 
            this.btnCalcPoupanca.Location = new System.Drawing.Point(22, 132);
            this.btnCalcPoupanca.Name = "btnCalcPoupanca";
            this.btnCalcPoupanca.Size = new System.Drawing.Size(202, 23);
            this.btnCalcPoupanca.TabIndex = 5;
            this.btnCalcPoupanca.Text = "Calculo Poupança 01/08/2019";
            this.btnCalcPoupanca.UseVisualStyleBackColor = true;
            this.btnCalcPoupanca.Click += new System.EventHandler(this.BtnCalcPoupanca_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Calculo de Idade - 01/08/2019";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_2);
            // 
            // lblFormData
            // 
            this.lblFormData.Location = new System.Drawing.Point(22, 190);
            this.lblFormData.Name = "lblFormData";
            this.lblFormData.Size = new System.Drawing.Size(202, 23);
            this.lblFormData.TabIndex = 7;
            this.lblFormData.Text = "Calculo de Data";
            this.lblFormData.UseVisualStyleBackColor = true;
            this.lblFormData.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(22, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Lição do Enum";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click_1);
            // 
            // btnFrmArray
            // 
            this.btnFrmArray.Location = new System.Drawing.Point(22, 248);
            this.btnFrmArray.Name = "btnFrmArray";
            this.btnFrmArray.Size = new System.Drawing.Size(202, 23);
            this.btnFrmArray.TabIndex = 9;
            this.btnFrmArray.Text = "Formulario Array 06/08/2019";
            this.btnFrmArray.UseVisualStyleBackColor = true;
            this.btnFrmArray.Click += new System.EventHandler(this.BtnFrmArray_Click);
            // 
            // btnArray2
            // 
            this.btnArray2.Location = new System.Drawing.Point(22, 278);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(202, 23);
            this.btnArray2.TabIndex = 10;
            this.btnArray2.Text = "Formulario Array 08/08/2019";
            this.btnArray2.UseVisualStyleBackColor = true;
            this.btnArray2.Click += new System.EventHandler(this.BtnArray2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.btnFrmArray);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lblFormData);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalcPoupanca);
            this.Controls.Add(this.btnForm3);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.Button btnCalcPoupanca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button lblFormData;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnFrmArray;
        private System.Windows.Forms.Button btnArray2;
    }
}

