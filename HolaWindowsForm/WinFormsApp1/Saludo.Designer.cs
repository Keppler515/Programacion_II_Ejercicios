namespace WinFormsApp1
{
    partial class Saludo
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
            this.lblHola = new System.Windows.Forms.Label();
            this.lblSoy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHola
            // 
            this.lblHola.AutoSize = true;
            this.lblHola.BackColor = System.Drawing.SystemColors.Control;
            this.lblHola.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblHola.Location = new System.Drawing.Point(20, 54);
            this.lblHola.Name = "lblHola";
            this.lblHola.Size = new System.Drawing.Size(72, 25);
            this.lblHola.TabIndex = 0;
            this.lblHola.Text = "Saludo";
            // 
            // lblSoy
            // 
            this.lblSoy.AutoSize = true;
            this.lblSoy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoy.Location = new System.Drawing.Point(20, 147);
            this.lblSoy.Name = "lblSoy";
            this.lblSoy.Size = new System.Drawing.Size(50, 21);
            this.lblSoy.TabIndex = 1;
            this.lblSoy.Text = "Datos";
            // 
            // Saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.lblSoy);
            this.Controls.Add(this.lblHola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Saludo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHola;
        private System.Windows.Forms.Label lblSoy;
    }
}