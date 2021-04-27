namespace PruebaBD
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.icoRestaurar = new System.Windows.Forms.PictureBox();
            this.icoMinimizar = new System.Windows.Forms.PictureBox();
            this.icoMaximizar = new System.Windows.Forms.PictureBox();
            this.icoCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.panelMenu.Controls.Add(this.btnAyuda);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnConsultar);
            this.panelMenu.Controls.Add(this.btnBorrar);
            this.panelMenu.Controls.Add(this.btnInscribir);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(286, 650);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 592);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(286, 58);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Cerrar Sesion";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(0, 176);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(286, 58);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.TabStop = false;
            this.btnConsultar.Text = "Usuarios";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(0, 231);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(286, 58);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.TabStop = false;
            this.btnBorrar.Text = "Examenes";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnInscribir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscribir.FlatAppearance.BorderSize = 0;
            this.btnInscribir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInscribir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribir.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInscribir.Image = ((System.Drawing.Image)(resources.GetObject("btnInscribir.Image")));
            this.btnInscribir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInscribir.Location = new System.Drawing.Point(0, 122);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(286, 58);
            this.btnInscribir.TabIndex = 0;
            this.btnInscribir.TabStop = false;
            this.btnInscribir.Text = "Registrar";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.panelTitulo.Controls.Add(this.icoRestaurar);
            this.panelTitulo.Controls.Add(this.icoMinimizar);
            this.panelTitulo.Controls.Add(this.icoMaximizar);
            this.panelTitulo.Controls.Add(this.icoCerrar);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(286, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1014, 39);
            this.panelTitulo.TabIndex = 1;
            // 
            // icoRestaurar
            // 
            this.icoRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icoRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("icoRestaurar.Image")));
            this.icoRestaurar.Location = new System.Drawing.Point(940, 3);
            this.icoRestaurar.Name = "icoRestaurar";
            this.icoRestaurar.Size = new System.Drawing.Size(28, 31);
            this.icoRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoRestaurar.TabIndex = 2;
            this.icoRestaurar.TabStop = false;
            this.icoRestaurar.Visible = false;
            this.icoRestaurar.Click += new System.EventHandler(this.icoRestaurar_Click);
            // 
            // icoMinimizar
            // 
            this.icoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("icoMinimizar.Image")));
            this.icoMinimizar.Location = new System.Drawing.Point(906, 3);
            this.icoMinimizar.Name = "icoMinimizar";
            this.icoMinimizar.Size = new System.Drawing.Size(28, 31);
            this.icoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMinimizar.TabIndex = 0;
            this.icoMinimizar.TabStop = false;
            this.icoMinimizar.Click += new System.EventHandler(this.icoMinimizar_Click);
            // 
            // icoMaximizar
            // 
            this.icoMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icoMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("icoMaximizar.Image")));
            this.icoMaximizar.Location = new System.Drawing.Point(940, 3);
            this.icoMaximizar.Name = "icoMaximizar";
            this.icoMaximizar.Size = new System.Drawing.Size(28, 31);
            this.icoMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoMaximizar.TabIndex = 1;
            this.icoMaximizar.TabStop = false;
            this.icoMaximizar.Click += new System.EventHandler(this.icoMaximizar_Click);
            // 
            // icoCerrar
            // 
            this.icoCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icoCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.icoCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.icoCerrar.Image = ((System.Drawing.Image)(resources.GetObject("icoCerrar.Image")));
            this.icoCerrar.Location = new System.Drawing.Point(974, 3);
            this.icoCerrar.Name = "icoCerrar";
            this.icoCerrar.Size = new System.Drawing.Size(28, 31);
            this.icoCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icoCerrar.TabIndex = 0;
            this.icoCerrar.TabStop = false;
            this.icoCerrar.Click += new System.EventHandler(this.icoCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(286, 39);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(1014, 611);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(0, 296);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(286, 58);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.TabStop = false;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icoRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox icoMinimizar;
        private System.Windows.Forms.PictureBox icoMaximizar;
        private System.Windows.Forms.PictureBox icoCerrar;
        private System.Windows.Forms.PictureBox icoRestaurar;
        private System.Windows.Forms.Button btnAyuda;
    }
}

