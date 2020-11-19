namespace Hospital
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(398, 149);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 31);
            this.btnEditar.TabIndex = 56;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(644, 149);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(119, 31);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(106, 149);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(119, 31);
            this.btnAgregar.TabIndex = 54;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Apellido1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Apellido2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(106, 98);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(119, 22);
            this.txtCedula.TabIndex = 48;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(398, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(119, 22);
            this.txtNombre.TabIndex = 47;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(398, 98);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(119, 22);
            this.txtApellido1.TabIndex = 46;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(644, 27);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(119, 22);
            this.txtApellido2.TabIndex = 45;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(106, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(119, 22);
            this.txtId.TabIndex = 44;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 201);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.Size = new System.Drawing.Size(776, 237);
            this.dgvPacientes.TabIndex = 57;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtId);
            this.Name = "frmPaciente";
            this.Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridView dgvPacientes;
    }
}