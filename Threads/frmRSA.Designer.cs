namespace Threads
{
    partial class frmRSA
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
            this.btnGenerateRSAKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateRSAKey
            // 
            this.btnGenerateRSAKey.Location = new System.Drawing.Point(12, 31);
            this.btnGenerateRSAKey.Name = "btnGenerateRSAKey";
            this.btnGenerateRSAKey.Size = new System.Drawing.Size(175, 37);
            this.btnGenerateRSAKey.TabIndex = 0;
            this.btnGenerateRSAKey.Text = "Generate RSA Key";
            this.btnGenerateRSAKey.UseVisualStyleBackColor = true;
            this.btnGenerateRSAKey.Click += new System.EventHandler(this.btnGenerateRSAKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Public Key :";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(16, 113);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(402, 102);
            this.txtPublicKey.TabIndex = 2;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(16, 267);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(402, 102);
            this.txtPrivateKey.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private Key :";
            // 
            // frmRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateRSAKey);
            this.Name = "frmRSA";
            this.Text = "frmRSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRSAKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label2;
    }
}