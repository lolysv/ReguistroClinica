namespace Formularios
{
    partial class FrmConsultasCitasDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultasCitasDoctor));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCONSULTARCITAS = new System.Windows.Forms.Label();
            this.btmCitas = new System.Windows.Forms.Button();
            this.lblCitasDoctor = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(368, 12);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(150, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario Doctor";
            // 
            // lblCONSULTARCITAS
            // 
            this.lblCONSULTARCITAS.AutoSize = true;
            this.lblCONSULTARCITAS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCONSULTARCITAS.ForeColor = System.Drawing.Color.Black;
            this.lblCONSULTARCITAS.Location = new System.Drawing.Point(170, 60);
            this.lblCONSULTARCITAS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCONSULTARCITAS.Name = "lblCONSULTARCITAS";
            this.lblCONSULTARCITAS.Size = new System.Drawing.Size(97, 16);
            this.lblCONSULTARCITAS.TabIndex = 1;
            this.lblCONSULTARCITAS.Text = "Consultar Cita";
            this.lblCONSULTARCITAS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btmCitas
            // 
            this.btmCitas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btmCitas.Location = new System.Drawing.Point(38, 112);
            this.btmCitas.Margin = new System.Windows.Forms.Padding(4);
            this.btmCitas.Name = "btmCitas";
            this.btmCitas.Size = new System.Drawing.Size(368, 30);
            this.btmCitas.TabIndex = 2;
            this.btmCitas.Text = "Citas del Dia";
            this.btmCitas.UseVisualStyleBackColor = true;
            this.btmCitas.Click += new System.EventHandler(this.btmCitas_Click);
            // 
            // lblCitasDoctor
            // 
            this.lblCitasDoctor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCitasDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCitasDoctor.Location = new System.Drawing.Point(38, 186);
            this.lblCitasDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.lblCitasDoctor.Name = "lblCitasDoctor";
            this.lblCitasDoctor.Size = new System.Drawing.Size(368, 30);
            this.lblCitasDoctor.TabIndex = 3;
            this.lblCitasDoctor.Text = "Citas por Doctor";
            this.lblCitasDoctor.UseVisualStyleBackColor = true;
            this.lblCitasDoctor.Click += new System.EventHandler(this.lblCitasDoctor_Click);
            // 
            // dgv
            // 
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(38, 242);
            this.dgv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(848, 208);
            this.dgv.TabIndex = 4;
            // 
            // FrmConsultasCitasDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 547);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblCitasDoctor);
            this.Controls.Add(this.btmCitas);
            this.Controls.Add(this.lblCONSULTARCITAS);
            this.Controls.Add(this.lblUsuario);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConsultasCitasDoctor";
            this.Text = "CITAS DOCTOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCONSULTARCITAS;
        private System.Windows.Forms.Button btmCitas;
        private System.Windows.Forms.Button lblCitasDoctor;
        private System.Windows.Forms.DataGridView dgv;
    }
}

