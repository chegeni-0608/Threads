namespace Threads
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
            this.btnStartCounterA = new System.Windows.Forms.Button();
            this.btnStartCounterB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCounterA = new System.Windows.Forms.Label();
            this.lblCounterB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangeBGColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textColorName = new System.Windows.Forms.TextBox();
            this.btnSampleCuncurrencyBottleneck = new System.Windows.Forms.Button();
            this.btnAsyncAwait = new System.Windows.Forms.Button();
            this.btnWithTransaction = new System.Windows.Forms.Button();
            this.btnWithoutTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartCounterA
            // 
            this.btnStartCounterA.Location = new System.Drawing.Point(12, 26);
            this.btnStartCounterA.Name = "btnStartCounterA";
            this.btnStartCounterA.Size = new System.Drawing.Size(102, 23);
            this.btnStartCounterA.TabIndex = 0;
            this.btnStartCounterA.Text = "Start Counter A";
            this.btnStartCounterA.UseVisualStyleBackColor = true;
            this.btnStartCounterA.Click += new System.EventHandler(this.btnStartCounterA_Click);
            // 
            // btnStartCounterB
            // 
            this.btnStartCounterB.Location = new System.Drawing.Point(173, 26);
            this.btnStartCounterB.Name = "btnStartCounterB";
            this.btnStartCounterB.Size = new System.Drawing.Size(102, 23);
            this.btnStartCounterB.TabIndex = 1;
            this.btnStartCounterB.Text = "Start Counter B";
            this.btnStartCounterB.UseVisualStyleBackColor = true;
            this.btnStartCounterB.Click += new System.EventHandler(this.btnStartCounterB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Counter A :";
            // 
            // lblCounterA
            // 
            this.lblCounterA.AutoSize = true;
            this.lblCounterA.Location = new System.Drawing.Point(78, 61);
            this.lblCounterA.Name = "lblCounterA";
            this.lblCounterA.Size = new System.Drawing.Size(13, 13);
            this.lblCounterA.TabIndex = 3;
            this.lblCounterA.Text = "0";
            // 
            // lblCounterB
            // 
            this.lblCounterB.AutoSize = true;
            this.lblCounterB.Location = new System.Drawing.Point(236, 61);
            this.lblCounterB.Name = "lblCounterB";
            this.lblCounterB.Size = new System.Drawing.Size(13, 13);
            this.lblCounterB.TabIndex = 5;
            this.lblCounterB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Counter B :";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(343, 36);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Time :";
            // 
            // ChangeBGColor
            // 
            this.ChangeBGColor.Location = new System.Drawing.Point(15, 99);
            this.ChangeBGColor.Name = "ChangeBGColor";
            this.ChangeBGColor.Size = new System.Drawing.Size(102, 23);
            this.ChangeBGColor.TabIndex = 8;
            this.ChangeBGColor.Text = "Change BG Color";
            this.ChangeBGColor.UseVisualStyleBackColor = true;
            this.ChangeBGColor.Click += new System.EventHandler(this.ChangeBGColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Color Name :";
            // 
            // textColorName
            // 
            this.textColorName.Location = new System.Drawing.Point(197, 102);
            this.textColorName.Name = "textColorName";
            this.textColorName.Size = new System.Drawing.Size(100, 20);
            this.textColorName.TabIndex = 10;
            // 
            // btnSampleCuncurrencyBottleneck
            // 
            this.btnSampleCuncurrencyBottleneck.Location = new System.Drawing.Point(12, 145);
            this.btnSampleCuncurrencyBottleneck.Name = "btnSampleCuncurrencyBottleneck";
            this.btnSampleCuncurrencyBottleneck.Size = new System.Drawing.Size(179, 23);
            this.btnSampleCuncurrencyBottleneck.TabIndex = 11;
            this.btnSampleCuncurrencyBottleneck.Text = "Sample Cuncurrency - Bottleneck";
            this.btnSampleCuncurrencyBottleneck.UseVisualStyleBackColor = true;
            this.btnSampleCuncurrencyBottleneck.Click += new System.EventHandler(this.btnSampleCuncurrencyBottleneck_Click);
            // 
            // btnAsyncAwait
            // 
            this.btnAsyncAwait.Location = new System.Drawing.Point(12, 174);
            this.btnAsyncAwait.Name = "btnAsyncAwait";
            this.btnAsyncAwait.Size = new System.Drawing.Size(179, 23);
            this.btnAsyncAwait.TabIndex = 12;
            this.btnAsyncAwait.Text = "Async-Await Sample";
            this.btnAsyncAwait.UseVisualStyleBackColor = true;
            this.btnAsyncAwait.Click += new System.EventHandler(this.btnAsyncAwait_Click);
            // 
            // btnWithTransaction
            // 
            this.btnWithTransaction.Location = new System.Drawing.Point(12, 224);
            this.btnWithTransaction.Name = "btnWithTransaction";
            this.btnWithTransaction.Size = new System.Drawing.Size(179, 23);
            this.btnWithTransaction.TabIndex = 13;
            this.btnWithTransaction.Text = "With Transaction";
            this.btnWithTransaction.UseVisualStyleBackColor = true;
            this.btnWithTransaction.Click += new System.EventHandler(this.btnWithTransaction_Click);
            // 
            // btnWithoutTransaction
            // 
            this.btnWithoutTransaction.Location = new System.Drawing.Point(12, 255);
            this.btnWithoutTransaction.Name = "btnWithoutTransaction";
            this.btnWithoutTransaction.Size = new System.Drawing.Size(179, 23);
            this.btnWithoutTransaction.TabIndex = 14;
            this.btnWithoutTransaction.Text = "Without Transaction";
            this.btnWithoutTransaction.UseVisualStyleBackColor = true;
            this.btnWithoutTransaction.Click += new System.EventHandler(this.btnWithoutTransaction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 290);
            this.Controls.Add(this.btnWithoutTransaction);
            this.Controls.Add(this.btnWithTransaction);
            this.Controls.Add(this.btnAsyncAwait);
            this.Controls.Add(this.btnSampleCuncurrencyBottleneck);
            this.Controls.Add(this.textColorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChangeBGColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCounterB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCounterA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartCounterB);
            this.Controls.Add(this.btnStartCounterA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartCounterA;
        private System.Windows.Forms.Button btnStartCounterB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCounterA;
        private System.Windows.Forms.Label lblCounterB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ChangeBGColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textColorName;
        private System.Windows.Forms.Button btnSampleCuncurrencyBottleneck;
        private System.Windows.Forms.Button btnAsyncAwait;
        private System.Windows.Forms.Button btnWithTransaction;
        private System.Windows.Forms.Button btnWithoutTransaction;
    }
}

