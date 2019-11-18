namespace FrontEnd
{
    partial class AdmColaboradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmColaboradores));
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.cbArea = new System.Windows.Forms.ComboBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.btCrear = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnslide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Location = new System.Drawing.Point(29, 190);
            this.dgvColaboradores.MultiSelect = false;
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.RowHeadersWidth = 51;
            this.dgvColaboradores.RowTemplate.Height = 24;
            this.dgvColaboradores.Size = new System.Drawing.Size(762, 248);
            this.dgvColaboradores.TabIndex = 13;
            this.dgvColaboradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID(Cédula):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.Location = new System.Drawing.Point(25, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.Location = new System.Drawing.Point(25, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label5.Location = new System.Drawing.Point(376, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label6.Location = new System.Drawing.Point(376, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha Ingreso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label7.Location = new System.Drawing.Point(376, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Area:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label8.Location = new System.Drawing.Point(376, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Puesto:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(124, 23);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(226, 20);
            this.tbID.TabIndex = 1;
            this.tbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbID_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(124, 70);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(226, 20);
            this.tbNombre.TabIndex = 2;
            this.tbNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombre_KeyPress);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(124, 146);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(226, 20);
            this.tbEdad.TabIndex = 4;
            this.tbEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEdad_KeyPress);
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(124, 111);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(226, 21);
            this.cbGenero.TabIndex = 3;
            this.cbGenero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGenero_KeyPress);
            // 
            // cbArea
            // 
            this.cbArea.FormattingEnabled = true;
            this.cbArea.Location = new System.Drawing.Point(440, 108);
            this.cbArea.MinimumSize = new System.Drawing.Size(297, 0);
            this.cbArea.Name = "cbArea";
            this.cbArea.Size = new System.Drawing.Size(297, 21);
            this.cbArea.TabIndex = 7;
            this.cbArea.SelectedIndexChanged += new System.EventHandler(this.cbArea_SelectedIndexChanged);
            this.cbArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbArea_KeyPress);
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(440, 146);
            this.cbPuesto.MinimumSize = new System.Drawing.Size(297, 0);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(297, 21);
            this.cbPuesto.TabIndex = 8;
            this.cbPuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbPuesto_KeyPress);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "";
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNacimiento.Location = new System.Drawing.Point(529, 23);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(262, 20);
            this.dtpNacimiento.TabIndex = 5;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.CustomFormat = "";
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIngreso.Location = new System.Drawing.Point(505, 67);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(286, 20);
            this.dtpIngreso.TabIndex = 6;
            // 
            // btCrear
            // 
            this.btCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btCrear.FlatAppearance.BorderSize = 0;
            this.btCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCrear.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btCrear.ForeColor = System.Drawing.Color.White;
            this.btCrear.Image = ((System.Drawing.Image)(resources.GetObject("btCrear.Image")));
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(0, 144);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(250, 40);
            this.btCrear.TabIndex = 9;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btModificar
            // 
            this.btModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btModificar.FlatAppearance.BorderSize = 0;
            this.btModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModificar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btModificar.ForeColor = System.Drawing.Color.White;
            this.btModificar.Image = ((System.Drawing.Image)(resources.GetObject("btModificar.Image")));
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModificar.Location = new System.Drawing.Point(3, 191);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(250, 40);
            this.btModificar.TabIndex = 10;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btEliminar.FlatAppearance.BorderSize = 0;
            this.btEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEliminar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btEliminar.ForeColor = System.Drawing.Color.White;
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(0, 248);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(250, 40);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Controls.Add(this.label9);
            this.MenuVertical.Controls.Add(this.btEliminar);
            this.MenuVertical.Controls.Add(this.btCrear);
            this.MenuVertical.Controls.Add(this.btModificar);
            this.MenuVertical.Controls.Add(this.shapeContainer1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(250, 511);
            this.MenuVertical.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(5, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(239, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "MUNICIPALIDAD SAN JOSE";
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.label10);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnslide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(250, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(813, 45);
            this.BarraTitulo.TabIndex = 17;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(259, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "ADMINISTACIÓN DE COLABORADORES";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.iconcerrar.Location = new System.Drawing.Point(793, 0);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(20, 20);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcerrar.TabIndex = 16;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnslide
            // 
            this.btnslide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnslide.Image = ((System.Drawing.Image)(resources.GetObject("btnslide.Image")));
            this.btnslide.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnslide.Location = new System.Drawing.Point(0, -2);
            this.btnslide.Name = "btnslide";
            this.btnslide.Size = new System.Drawing.Size(35, 35);
            this.btnslide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnslide.TabIndex = 15;
            this.btnslide.TabStop = false;
            this.btnslide.Click += new System.EventHandler(this.btnslide_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpIngreso);
            this.panel1.Controls.Add(this.cbPuesto);
            this.panel1.Controls.Add(this.dgvColaboradores);
            this.panel1.Controls.Add(this.dtpNacimiento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbArea);
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbEdad);
            this.panel1.Controls.Add(this.cbGenero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 466);
            this.panel1.TabIndex = 18;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(250, 511);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 44;
            this.lineShape1.X2 = 201;
            this.lineShape1.Y1 = 423;
            this.lineShape1.Y2 = 423;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(90, 443);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdmColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdmColaboradores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdmColaboradores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmColaboradores_FormClosing);
            this.Load += new System.EventHandler(this.AdmColaboradores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnslide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.ComboBox cbArea;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox btnslide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}