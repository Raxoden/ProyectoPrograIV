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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
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
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsUsuario,
            this.tsColaborador});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            // 
            // tsUsuario
            // 
            this.tsUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tsUsuario, "tsUsuario");
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsColaborador
            // 
            this.tsColaborador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsColaborador.Name = "tsColaborador";
            resources.ApplyResources(this.tsColaborador, "tsColaborador");
            this.tsColaborador.Click += new System.EventHandler(this.colaboradoresToolStripMenuItem_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbUsuario, "lbUsuario");
            this.lbUsuario.Name = "lbUsuario";
            // 
            // lbID
            // 
            this.lbID.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbID, "lbID");
            this.lbID.Name = "lbID";
            // 
            // lbArea
            // 
            this.lbArea.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbArea, "lbArea");
            this.lbArea.Name = "lbArea";
            // 
            // lbPuesto
            // 
            this.lbPuesto.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbPuesto, "lbPuesto");
            this.lbPuesto.Name = "lbPuesto";
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.ShowIcon = false;
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