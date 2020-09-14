namespace Interface_Figurer
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
            this.lblMått1 = new System.Windows.Forms.Label();
            this.lblMått2 = new System.Windows.Forms.Label();
            this.tbxBredd = new System.Windows.Forms.TextBox();
            this.tbxHöjd = new System.Windows.Forms.TextBox();
            this.lbxFigurer = new System.Windows.Forms.ListBox();
            this.BtnSkapa = new System.Windows.Forms.Button();
            this.tbxDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMått1
            // 
            this.lblMått1.AutoSize = true;
            this.lblMått1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMått1.Location = new System.Drawing.Point(71, 240);
            this.lblMått1.Name = "lblMått1";
            this.lblMått1.Size = new System.Drawing.Size(47, 18);
            this.lblMått1.TabIndex = 0;
            this.lblMått1.Text = "Bredd";
            // 
            // lblMått2
            // 
            this.lblMått2.AutoSize = true;
            this.lblMått2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMått2.Location = new System.Drawing.Point(71, 278);
            this.lblMått2.Name = "lblMått2";
            this.lblMått2.Size = new System.Drawing.Size(39, 18);
            this.lblMått2.TabIndex = 1;
            this.lblMått2.Text = "Höjd";
            // 
            // tbxBredd
            // 
            this.tbxBredd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBredd.Location = new System.Drawing.Point(144, 237);
            this.tbxBredd.Name = "tbxBredd";
            this.tbxBredd.Size = new System.Drawing.Size(91, 24);
            this.tbxBredd.TabIndex = 2;
            // 
            // tbxHöjd
            // 
            this.tbxHöjd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHöjd.Location = new System.Drawing.Point(144, 275);
            this.tbxHöjd.Name = "tbxHöjd";
            this.tbxHöjd.Size = new System.Drawing.Size(91, 24);
            this.tbxHöjd.TabIndex = 3;
            // 
            // lbxFigurer
            // 
            this.lbxFigurer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxFigurer.FormattingEnabled = true;
            this.lbxFigurer.ItemHeight = 18;
            this.lbxFigurer.Location = new System.Drawing.Point(59, 55);
            this.lbxFigurer.Name = "lbxFigurer";
            this.lbxFigurer.Size = new System.Drawing.Size(193, 130);
            this.lbxFigurer.TabIndex = 4;
            this.lbxFigurer.SelectedIndexChanged += new System.EventHandler(this.lbxFigurer_SelectedIndexChanged);
            // 
            // BtnSkapa
            // 
            this.BtnSkapa.Location = new System.Drawing.Point(342, 227);
            this.BtnSkapa.Name = "BtnSkapa";
            this.BtnSkapa.Size = new System.Drawing.Size(132, 72);
            this.BtnSkapa.TabIndex = 5;
            this.BtnSkapa.Text = "Skapa";
            this.BtnSkapa.UseVisualStyleBackColor = true;
            this.BtnSkapa.Click += new System.EventHandler(this.BtnSkapa_Click);
            // 
            // tbxDisplay
            // 
            this.tbxDisplay.Location = new System.Drawing.Point(580, 55);
            this.tbxDisplay.Multiline = true;
            this.tbxDisplay.Name = "tbxDisplay";
            this.tbxDisplay.Size = new System.Drawing.Size(180, 233);
            this.tbxDisplay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxDisplay);
            this.Controls.Add(this.BtnSkapa);
            this.Controls.Add(this.lbxFigurer);
            this.Controls.Add(this.tbxHöjd);
            this.Controls.Add(this.tbxBredd);
            this.Controls.Add(this.lblMått2);
            this.Controls.Add(this.lblMått1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMått1;
        private System.Windows.Forms.Label lblMått2;
        private System.Windows.Forms.TextBox tbxBredd;
        private System.Windows.Forms.TextBox tbxHöjd;
        private System.Windows.Forms.ListBox lbxFigurer;
        private System.Windows.Forms.Button BtnSkapa;
        private System.Windows.Forms.TextBox tbxDisplay;
    }
}

