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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            this.tsUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.tsUsuario, "tsUsuario");
            this.tsUsuario.ForeColor = System.Drawing.Color.White;
            this.tsUsuario.Name = "tsUsuario";
            this.tsUsuario.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tsColaborador
            // 
            this.tsColaborador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.tsColaborador, "tsColaborador");
            this.tsColaborador.ForeColor = System.Drawing.Color.White;
            this.tsColaborador.Name = "tsColaborador";
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
            this.lbPuesto.Click += new System.EventHandler(this.lbPuesto_Click);
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            resources.ApplyResources(this.lineShape4, "lineShape4");
            this.lineShape4.Click += new System.EventHandler(this.lineShape4_Click);
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            resources.ApplyResources(this.lineShape3, "lineShape3");
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            resources.ApplyResources(this.lineShape2, "lineShape2");
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            resources.ApplyResources(this.lineShape1, "lineShape1");
            // 
            // iconcerrar
            // 
            resources.ApplyResources(this.iconcerrar, "iconcerrar");
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // Menu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.iconcerrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbPuesto);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.PictureBox iconcerrar;
    }
}