namespace WinCalculator
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnQuotient = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(224, 28);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(35, 13);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Num1";
            this.lblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(429, 28);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(35, 13);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Num2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(311, 28);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(472, 28);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(153, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(432, 127);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 23);
            this.btnMul.TabIndex = 6;
            this.btnMul.Text = "Multiply";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnQuotient
            // 
            this.btnQuotient.Location = new System.Drawing.Point(556, 127);
            this.btnQuotient.Name = "btnQuotient";
            this.btnQuotient.Size = new System.Drawing.Size(75, 23);
            this.btnQuotient.TabIndex = 7;
            this.btnQuotient.Text = "quotient";
            this.btnQuotient.UseVisualStyleBackColor = true;
            this.btnQuotient.Click += new System.EventHandler(this.btnQuotient_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Location = new System.Drawing.Point(680, 127);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(75, 23);
            this.btnModulus.TabIndex = 8;
            this.btnModulus.Text = "modulus";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btnModulus_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(297, 127);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(75, 23);
            this.btnSubtract.TabIndex = 9;
            this.btnSubtract.Text = "Subtract";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(344, 198);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 13);
            this.lblres.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnQuotient);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnQuotient;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label lblres;
    }
}

