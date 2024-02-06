
namespace KioscoConsulta
{
    partial class PantallaAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaAcceso));
            this.BtIngreso = new System.Windows.Forms.Button();
            this.TbUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre_FA = new System.Windows.Forms.Label();
            this.lblNumEmp_FA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtIngreso
            // 
            this.BtIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIngreso.Location = new System.Drawing.Point(246, 521);
            this.BtIngreso.Margin = new System.Windows.Forms.Padding(6);
            this.BtIngreso.Name = "BtIngreso";
            this.BtIngreso.Size = new System.Drawing.Size(286, 100);
            this.BtIngreso.TabIndex = 0;
            this.BtIngreso.Text = "INGRESAR";
            this.BtIngreso.UseVisualStyleBackColor = true;
            this.BtIngreso.Click += new System.EventHandler(this.BtIngreso_Click);
            // 
            // TbUsuario
            // 
            this.TbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsuario.Location = new System.Drawing.Point(39, 541);
            this.TbUsuario.Margin = new System.Windows.Forms.Padding(6);
            this.TbUsuario.Name = "TbUsuario";
            this.TbUsuario.Size = new System.Drawing.Size(178, 75);
            this.TbUsuario.TabIndex = 1;
            this.TbUsuario.UseSystemPasswordChar = true;
            // 
            // lblNombre_FA
            // 
            this.lblNombre_FA.AutoSize = true;
            this.lblNombre_FA.Location = new System.Drawing.Point(286, 52);
            this.lblNombre_FA.Name = "lblNombre_FA";
            this.lblNombre_FA.Size = new System.Drawing.Size(133, 31);
            this.lblNombre_FA.TabIndex = 2;
            this.lblNombre_FA.Text = "NOMBRE";
            // 
            // lblNumEmp_FA
            // 
            this.lblNumEmp_FA.AutoSize = true;
            this.lblNumEmp_FA.Location = new System.Drawing.Point(80, 52);
            this.lblNumEmp_FA.Name = "lblNumEmp_FA";
            this.lblNumEmp_FA.Size = new System.Drawing.Size(149, 31);
            this.lblNumEmp_FA.TabIndex = 3;
            this.lblNumEmp_FA.Text = "NUM_EMP";
            // 
            // PantallaAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblNumEmp_FA);
            this.Controls.Add(this.lblNombre_FA);
            this.Controls.Add(this.TbUsuario);
            this.Controls.Add(this.BtIngreso);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PantallaAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiosco_información";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtIngreso;
        private System.Windows.Forms.TextBox TbUsuario;
        public System.Windows.Forms.Label lblNombre_FA;
        public System.Windows.Forms.Label lblNumEmp_FA;
    }
}

