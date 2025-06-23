namespace Ejercicio_1
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbtabla = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.Pink;
            this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(71, 69);
            this.txtnumero.Multiline = true;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(80, 36);
            this.txtnumero.TabIndex = 0;
            this.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese un número";
            // 
            // lbtabla
            // 
            this.lbtabla.BackColor = System.Drawing.Color.Pink;
            this.lbtabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtabla.FormattingEnabled = true;
            this.lbtabla.ItemHeight = 25;
            this.lbtabla.Location = new System.Drawing.Point(248, 52);
            this.lbtabla.Name = "lbtabla";
            this.lbtabla.Size = new System.Drawing.Size(143, 304);
            this.lbtabla.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(439, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbtabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumero);
            this.Name = "Form1";
            this.Text = "Tabla de multiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbtabla;
        private System.Windows.Forms.Button button1;
    }
}

