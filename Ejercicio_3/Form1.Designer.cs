﻿namespace Ejercicio_3
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
            this.cmbde = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbpara = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbde
            // 
            this.cmbde.FormattingEnabled = true;
            this.cmbde.Items.AddRange(new object[] {
            "Metro",
            "Centimetro",
            "Pulgada"});
            this.cmbde.Location = new System.Drawing.Point(42, 105);
            this.cmbde.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbde.Name = "cmbde";
            this.cmbde.Size = new System.Drawing.Size(194, 33);
            this.cmbde.TabIndex = 0;
            this.cmbde.SelectedIndexChanged += new System.EventHandler(this.cmbde_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "De";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbpara
            // 
            this.cmbpara.FormattingEnabled = true;
            this.cmbpara.Items.AddRange(new object[] {
            "Metro",
            "Centimetro",
            "Pulgada"});
            this.cmbpara.Location = new System.Drawing.Point(311, 105);
            this.cmbpara.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbpara.Name = "cmbpara";
            this.cmbpara.Size = new System.Drawing.Size(194, 33);
            this.cmbpara.TabIndex = 2;
            this.cmbpara.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 311);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convertir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(198, 250);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(136, 30);
            this.txtvalor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(548, 419);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbpara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbde);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbpara;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtvalor;
    }
}

