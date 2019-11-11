namespace FrontEnd
{
    partial class AdmUsuarios
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.dgvColaboradores = new System.Windows.Forms.DataGridView();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPrivilegio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContrasenna = new System.Windows.Forms.TextBox();
            this.tbConfirmar = new System.Windows.Forms.TextBox();
            this.btCrear = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(169, 22);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(211, 22);
            this.tbId.TabIndex = 0;
            // 
            // dgvColaboradores
            // 
            this.dgvColaboradores.AllowUserToAddRows = false;
            this.dgvColaboradores.AllowUserToDeleteRows = false;
            this.dgvColaboradores.AllowUserToResizeColumns = false;
            this.dgvColaboradores.AllowUserToResizeRows = false;
            this.dgvColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaboradores.Location = new System.Drawing.Point(12, 204);
            this.dgvColaboradores.MultiSelect = false;
            this.dgvColaboradores.Name = "dgvColaboradores";
            this.dgvColaboradores.ReadOnly = true;
            this.dgvColaboradores.RowHeadersWidth = 51;
            this.dgvColaboradores.RowTemplate.Height = 24;
            this.dgvColaboradores.Size = new System.Drawing.Size(370, 234);
            this.dgvColaboradores.TabIndex = 1;
            this.dgvColaboradores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaboradores_CellClick);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(418, 204);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(370, 234);
            this.dgvUsuarios.TabIndex = 2;
            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // rbPrivilegio
            // 
            this.rbPrivilegio.AutoSize = true;
            this.rbPrivilegio.Location = new System.Drawing.Point(418, 23);
            this.rbPrivilegio.Name = "rbPrivilegio";
            this.rbPrivilegio.Size = new System.Drawing.Size(93, 21);
            this.rbPrivilegio.TabIndex = 4;
            this.rbPrivilegio.TabStop = true;
            this.rbPrivilegio.Text = "Privilegios";
            this.rbPrivilegio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar contraseña:";
            // 
            // tbContrasenna
            // 
            this.tbContrasenna.Location = new System.Drawing.Point(169, 67);
            this.tbContrasenna.Name = "tbContrasenna";
            this.tbContrasenna.Size = new System.Drawing.Size(211, 22);
            this.tbContrasenna.TabIndex = 7;
            // 
            // tbConfirmar
            // 
            this.tbConfirmar.Location = new System.Drawing.Point(169, 115);
            this.tbConfirmar.Name = "tbConfirmar";
            this.tbConfirmar.Size = new System.Drawing.Size(211, 22);
            this.tbConfirmar.TabIndex = 8;
            // 
            // btCrear
            // 
            this.btCrear.Location = new System.Drawing.Point(660, 27);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(108, 39);
            this.btCrear.TabIndex = 9;
            this.btCrear.Text = "Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(660, 81);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(108, 39);
            this.btModificar.TabIndex = 10;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(660, 135);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(108, 39);
            this.btEliminar.TabIndex = 11;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // AdmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btCrear);
            this.Controls.Add(this.tbConfirmar);
            this.Controls.Add(this.tbContrasenna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPrivilegio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.dgvColaboradores);
            this.Controls.Add(this.tbId);
            this.Name = "AdmUsuarios";
            this.Text = "AdmUsuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.AdmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaboradores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DataGridView dgvColaboradores;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPrivilegio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbContrasenna;
        private System.Windows.Forms.TextBox tbConfirmar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btEliminar;
    }
}