﻿namespace PrimeFactors
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddToPrimeList = new System.Windows.Forms.Button();
            this.listBoxPrimes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(73, 75);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(86, 32);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Prime Or Not ?";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNumber.Location = new System.Drawing.Point(73, 49);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(225, 20);
            this.textBoxNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a Value";
            // 
            // buttonAddToPrimeList
            // 
            this.buttonAddToPrimeList.Location = new System.Drawing.Point(212, 75);
            this.buttonAddToPrimeList.Name = "buttonAddToPrimeList";
            this.buttonAddToPrimeList.Size = new System.Drawing.Size(86, 46);
            this.buttonAddToPrimeList.TabIndex = 4;
            this.buttonAddToPrimeList.Text = "Find Prime And Add To List";
            this.buttonAddToPrimeList.UseVisualStyleBackColor = true;
            this.buttonAddToPrimeList.Click += new System.EventHandler(this.buttonAddToPrimeList_Click);
            // 
            // listBoxPrimes
            // 
            this.listBoxPrimes.FormattingEnabled = true;
            this.listBoxPrimes.Location = new System.Drawing.Point(73, 122);
            this.listBoxPrimes.Name = "listBoxPrimes";
            this.listBoxPrimes.Size = new System.Drawing.Size(225, 95);
            this.listBoxPrimes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 229);
            this.Controls.Add(this.listBoxPrimes);
            this.Controls.Add(this.buttonAddToPrimeList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Factors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddToPrimeList;
        private System.Windows.Forms.ListBox listBoxPrimes;
    }
}

