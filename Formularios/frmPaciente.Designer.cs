namespace Formularios
{
    partial class frmPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCitasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarCitasToolStripMenuItem
            // 
            this.registrarCitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarCitasToolStripMenuItem1,
            this.consultarCitasToolStripMenuItem1});
            this.registrarCitasToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarCitasToolStripMenuItem.Name = "registrarCitasToolStripMenuItem";
            this.registrarCitasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.registrarCitasToolStripMenuItem.Text = "Citas";
            this.registrarCitasToolStripMenuItem.Click += new System.EventHandler(this.registrarCitasToolStripMenuItem_Click);
            // 
            // registrarCitasToolStripMenuItem1
            // 
            this.registrarCitasToolStripMenuItem1.Name = "registrarCitasToolStripMenuItem1";
            this.registrarCitasToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.registrarCitasToolStripMenuItem1.Text = "Registrar Citas";
            this.registrarCitasToolStripMenuItem1.Click += new System.EventHandler(this.registrarCitasToolStripMenuItem1_Click);
            // 
            // consultarCitasToolStripMenuItem1
            // 
            this.consultarCitasToolStripMenuItem1.Name = "consultarCitasToolStripMenuItem1";
            this.consultarCitasToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.consultarCitasToolStripMenuItem1.Text = "Consultar Citas";
            this.consultarCitasToolStripMenuItem1.Click += new System.EventHandler(this.consultarCitasToolStripMenuItem1_Click);
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(536, 478);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPaciente";
            this.Text = "Formulario Paciente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCitasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarCitasToolStripMenuItem1;
    }
}