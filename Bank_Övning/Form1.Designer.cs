﻿namespace Bank_Övning
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxBelopp = new System.Windows.Forms.TextBox();
            this.BtnInsättning = new System.Windows.Forms.Button();
            this.BtnUttag = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPersonNr = new System.Windows.Forms.TextBox();
            this.tbxRänesats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxKredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegestrera = new System.Windows.Forms.Button();
            this.lbxKonton = new System.Windows.Forms.ListBox();
            this.BtnUpdatera = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUttag);
            this.groupBox1.Controls.Add(this.BtnInsättning);
            this.groupBox1.Controls.Add(this.tbxBelopp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insättning/Uttag";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belopp:";
            // 
            // tbxBelopp
            // 
            this.tbxBelopp.Location = new System.Drawing.Point(67, 30);
            this.tbxBelopp.Name = "tbxBelopp";
            this.tbxBelopp.Size = new System.Drawing.Size(79, 20);
            this.tbxBelopp.TabIndex = 1;
            // 
            // BtnInsättning
            // 
            this.BtnInsättning.Location = new System.Drawing.Point(150, 102);
            this.BtnInsättning.Name = "BtnInsättning";
            this.BtnInsättning.Size = new System.Drawing.Size(80, 28);
            this.BtnInsättning.TabIndex = 2;
            this.BtnInsättning.Text = "Insättning";
            this.BtnInsättning.UseVisualStyleBackColor = true;
            // 
            // BtnUttag
            // 
            this.BtnUttag.Location = new System.Drawing.Point(150, 136);
            this.BtnUttag.Name = "BtnUttag";
            this.BtnUttag.Size = new System.Drawing.Size(80, 31);
            this.BtnUttag.TabIndex = 3;
            this.BtnUttag.Text = "Uttag";
            this.BtnUttag.UseVisualStyleBackColor = true;
            this.BtnUttag.Click += new System.EventHandler(this.BtnUttag_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnRegestrera);
            this.groupBox2.Controls.Add(this.tbxKredit);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbxRänesats);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbxPersonNr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(335, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 164);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öppna konto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "PersonNr";
            // 
            // tbxPersonNr
            // 
            this.tbxPersonNr.Location = new System.Drawing.Point(96, 31);
            this.tbxPersonNr.Name = "tbxPersonNr";
            this.tbxPersonNr.Size = new System.Drawing.Size(75, 20);
            this.tbxPersonNr.TabIndex = 1;
            // 
            // tbxRänesats
            // 
            this.tbxRänesats.Location = new System.Drawing.Point(96, 57);
            this.tbxRänesats.Name = "tbxRänesats";
            this.tbxRänesats.Size = new System.Drawing.Size(75, 20);
            this.tbxRänesats.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Räntesats";
            // 
            // tbxKredit
            // 
            this.tbxKredit.Location = new System.Drawing.Point(96, 83);
            this.tbxKredit.Name = "tbxKredit";
            this.tbxKredit.Size = new System.Drawing.Size(75, 20);
            this.tbxKredit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kredit";
            // 
            // BtnRegestrera
            // 
            this.BtnRegestrera.Location = new System.Drawing.Point(123, 124);
            this.BtnRegestrera.Name = "BtnRegestrera";
            this.BtnRegestrera.Size = new System.Drawing.Size(81, 34);
            this.BtnRegestrera.TabIndex = 6;
            this.BtnRegestrera.Text = "Regestrera";
            this.BtnRegestrera.UseVisualStyleBackColor = true;
            // 
            // lbxKonton
            // 
            this.lbxKonton.FormattingEnabled = true;
            this.lbxKonton.Location = new System.Drawing.Point(615, 32);
            this.lbxKonton.Name = "lbxKonton";
            this.lbxKonton.Size = new System.Drawing.Size(274, 147);
            this.lbxKonton.TabIndex = 2;
            // 
            // BtnUpdatera
            // 
            this.BtnUpdatera.Location = new System.Drawing.Point(619, 205);
            this.BtnUpdatera.Name = "BtnUpdatera";
            this.BtnUpdatera.Size = new System.Drawing.Size(269, 42);
            this.BtnUpdatera.TabIndex = 3;
            this.BtnUpdatera.Text = "Uppdatera med årsränta";
            this.BtnUpdatera.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 324);
            this.Controls.Add(this.BtnUpdatera);
            this.Controls.Add(this.lbxKonton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnUttag;
        private System.Windows.Forms.Button BtnInsättning;
        private System.Windows.Forms.TextBox tbxBelopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxPersonNr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnRegestrera;
        private System.Windows.Forms.TextBox tbxKredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRänesats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbxKonton;
        private System.Windows.Forms.Button BtnUpdatera;
    }
}

