namespace Threads
{
    partial class frmCuncurrency
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
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnThreadA = new System.Windows.Forms.Button();
            this.btnThreadB = new System.Windows.Forms.Button();
            this.btnThreadC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance :";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(81, 25);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(25, 13);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "500";
            // 
            // btnThreadA
            // 
            this.btnThreadA.Location = new System.Drawing.Point(26, 71);
            this.btnThreadA.Name = "btnThreadA";
            this.btnThreadA.Size = new System.Drawing.Size(120, 23);
            this.btnThreadA.TabIndex = 2;
            this.btnThreadA.Text = "Thread A + 100";
            this.btnThreadA.UseVisualStyleBackColor = true;
            this.btnThreadA.Click += new System.EventHandler(this.btnThreadA_Click);
            // 
            // btnThreadB
            // 
            this.btnThreadB.Location = new System.Drawing.Point(26, 123);
            this.btnThreadB.Name = "btnThreadB";
            this.btnThreadB.Size = new System.Drawing.Size(120, 23);
            this.btnThreadB.TabIndex = 3;
            this.btnThreadB.Text = "Thread B - 50";
            this.btnThreadB.UseVisualStyleBackColor = true;
            this.btnThreadB.Click += new System.EventHandler(this.btnThreadB_Click);
            // 
            // btnThreadC
            // 
            this.btnThreadC.Location = new System.Drawing.Point(26, 174);
            this.btnThreadC.Name = "btnThreadC";
            this.btnThreadC.Size = new System.Drawing.Size(120, 23);
            this.btnThreadC.TabIndex = 4;
            this.btnThreadC.Text = "Thread C - 200";
            this.btnThreadC.UseVisualStyleBackColor = true;
            this.btnThreadC.Click += new System.EventHandler(this.btnThreadC_Click);
            // 
            // frmCuncurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThreadC);
            this.Controls.Add(this.btnThreadB);
            this.Controls.Add(this.btnThreadA);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Name = "frmCuncurrency";
            this.Text = "frmCuncurrency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnThreadA;
        private System.Windows.Forms.Button btnThreadB;
        private System.Windows.Forms.Button btnThreadC;
    }
}