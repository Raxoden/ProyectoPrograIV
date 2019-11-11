namespace FrontEnd
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbPuesto = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.tsColaborador});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(605, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsUsuario
            // 
            this.tsUsuario.Enabled = false;
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Size = new System.Drawing.Size(79, 24);
            this.tsUsuario.Text = "Usuarios";
            this.tsUsuario.Visible = false;
            this.tsUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsColaborador
            // 
            this.tsColaborador.Name = "tsColaborador";
            this.tsColaborador.Size = new System.Drawing.Size(121, 24);
            this.tsColaborador.Text = "Colaboradores";
            this.tsColaborador.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(12, 47);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(61, 17);
            this.lbUsuario.TabIndex = 2;
            this.lbUsuario.Text = "Usuario:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(12, 94);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 3;
            this.lbID.Text = "ID:";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(12, 141);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(42, 17);
            this.lbArea.TabIndex = 4;
            this.lbArea.Text = "Area:";
            // 
            // lbPuesto
            // 
            this.lbPuesto.AutoSize = true;
            this.lbPuesto.Location = new System.Drawing.Point(12, 188);
            this.lbPuesto.Name = "lbPuesto";
            this.lbPuesto.Size = new System.Drawing.Size(56, 17);
            this.lbPuesto.TabIndex = 5;
            this.lbPuesto.Text = "Puesto:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 241);
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsColaborador;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbPuesto;
    }
}