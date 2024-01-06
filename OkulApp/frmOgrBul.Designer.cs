namespace OkulApp
{
    partial class frmOgrBul
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
            this.grpBul = new System.Windows.Forms.GroupBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBul
            // 
            this.grpBul.Controls.Add(this.btnBul);
            this.grpBul.Controls.Add(this.txtOgrNo);
            this.grpBul.Controls.Add(this.label1);
            this.grpBul.Location = new System.Drawing.Point(44, 53);
            this.grpBul.Name = "grpBul";
            this.grpBul.Size = new System.Drawing.Size(365, 218);
            this.grpBul.TabIndex = 0;
            this.grpBul.TabStop = false;
            this.grpBul.Text = "Öğrenci Bul";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(105, 142);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(131, 33);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(105, 98);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(131, 26);
            this.txtOgrNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Numarası";
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 366);
            this.Controls.Add(this.grpBul);
            this.Name = "frmOgrBul";
            this.Text = "frmOgrBulcs";
            this.grpBul.ResumeLayout(false);
            this.grpBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.Label label1;
    }
}