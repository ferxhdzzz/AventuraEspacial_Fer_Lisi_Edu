namespace AventuraEspacial_Fer_Lisi_Edu
{
    partial class AventuraEspacial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPlaneta = new System.Windows.Forms.PictureBox();
            this.lbPlaneta = new System.Windows.Forms.Label();
            this.lbTemperatura = new System.Windows.Forms.Label();
            this.lbOxigeno = new System.Windows.Forms.Label();
            this.lbDaño = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaneta)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlaneta
            // 
            this.picPlaneta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlaneta.Location = new System.Drawing.Point(12, 103);
            this.picPlaneta.Name = "picPlaneta";
            this.picPlaneta.Size = new System.Drawing.Size(400, 300);
            this.picPlaneta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlaneta.TabIndex = 0;
            this.picPlaneta.TabStop = false;
            // 
            // lbPlaneta
            // 
            this.lbPlaneta.AutoSize = true;
            this.lbPlaneta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaneta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbPlaneta.Location = new System.Drawing.Point(7, 415);
            this.lbPlaneta.Name = "lbPlaneta";
            this.lbPlaneta.Size = new System.Drawing.Size(84, 25);
            this.lbPlaneta.TabIndex = 1;
            this.lbPlaneta.Text = " Planeta:";
            // 
            // lbTemperatura
            // 
            this.lbTemperatura.AutoSize = true;
            this.lbTemperatura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperatura.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbTemperatura.Location = new System.Drawing.Point(7, 463);
            this.lbTemperatura.Name = "lbTemperatura";
            this.lbTemperatura.Size = new System.Drawing.Size(122, 25);
            this.lbTemperatura.TabIndex = 2;
            this.lbTemperatura.Text = "Temperatura:";
            // 
            // lbOxigeno
            // 
            this.lbOxigeno.AutoSize = true;
            this.lbOxigeno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOxigeno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbOxigeno.Location = new System.Drawing.Point(7, 506);
            this.lbOxigeno.Name = "lbOxigeno";
            this.lbOxigeno.Size = new System.Drawing.Size(87, 25);
            this.lbOxigeno.TabIndex = 3;
            this.lbOxigeno.Text = "Oxígeno:";
            this.lbOxigeno.Click += new System.EventHandler(this.lbOxigeno_Click);
            // 
            // lbDaño
            // 
            this.lbDaño.AutoSize = true;
            this.lbDaño.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDaño.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbDaño.Location = new System.Drawing.Point(7, 552);
            this.lbDaño.Name = "lbDaño";
            this.lbDaño.Size = new System.Drawing.Size(61, 25);
            this.lbDaño.TabIndex = 4;
            this.lbDaño.Text = "Daño:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(836, 114);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 160);
            this.listBox1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Explorar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(854, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(853, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 75);
            this.button3.TabIndex = 8;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AventuraEspacial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbDaño);
            this.Controls.Add(this.lbOxigeno);
            this.Controls.Add(this.lbTemperatura);
            this.Controls.Add(this.lbPlaneta);
            this.Controls.Add(this.picPlaneta);
            this.Name = "AventuraEspacial";
            this.Text = "AventuraEspacial";
            ((System.ComponentModel.ISupportInitialize)(this.picPlaneta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlaneta;
        private System.Windows.Forms.Label lbPlaneta;
        private System.Windows.Forms.Label lbTemperatura;
        private System.Windows.Forms.Label lbOxigeno;
        private System.Windows.Forms.Label lbDaño;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

