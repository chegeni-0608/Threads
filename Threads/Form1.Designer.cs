﻿namespace Threads
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
            this.SuspendLayout();
            // 
            // btnStartCounterA
            // 
            this.btnStartCounterA.Location = new System.Drawing.Point(23, 26);
            this.btnStartCounterA.Name = "btnStartCounterA";
            this.btnStartCounterA.Size = new System.Drawing.Size(102, 23);
            this.btnStartCounterA.TabIndex = 0;
            this.btnStartCounterA.Text = "Start Counter A";
            this.btnStartCounterA.UseVisualStyleBackColor = true;
            this.btnStartCounterA.Click += new System.EventHandler(this.btnStartCounterA_Click);
            // 
            // btnStartCounterB
            // 
            this.btnStartCounterB.Location = new System.Drawing.Point(199, 26);
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
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Counter A :";
            // 
            // lblCounterA
            // 
            this.lblCounterA.AutoSize = true;
            this.lblCounterA.Location = new System.Drawing.Point(86, 61);
            this.lblCounterA.Name = "lblCounterA";
            this.lblCounterA.Size = new System.Drawing.Size(13, 13);
            this.lblCounterA.TabIndex = 3;
            this.lblCounterA.Text = "0";
            // 
            // lblCounterB
            // 
            this.lblCounterB.AutoSize = true;
            this.lblCounterB.Location = new System.Drawing.Point(262, 61);
            this.lblCounterB.Name = "lblCounterB";
            this.lblCounterB.Size = new System.Drawing.Size(13, 13);
            this.lblCounterB.TabIndex = 5;
            this.lblCounterB.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Counter B :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 239);
            this.Controls.Add(this.lblCounterB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCounterA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartCounterB);
            this.Controls.Add(this.btnStartCounterA);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

