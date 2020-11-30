namespace Hospital
{
    partial class frmAgregarCirujia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarCirujia));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.cbxPaciente = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxCirujano1 = new System.Windows.Forms.ComboBox();
            this.cbxCirujano2 = new System.Windows.Forms.ComboBox();
            this.cbxEnfermero1 = new System.Windows.Forms.ComboBox();
            this.cbxEnfermero2 = new System.Windows.Forms.ComboBox();
            this.cbxQuirofano = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label565 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtpFinal
            // 
            this.dtpFinal.CustomFormat = "";
            this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinal.Location = new System.Drawing.Point(634, 181);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.ShowUpDown = true;
            this.dtpFinal.Size = new System.Drawing.Size(218, 22);
            this.dtpFinal.TabIndex = 39;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(634, 67);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowUpDown = true;
            this.dtpInicio.Size = new System.Drawing.Size(218, 22);
            this.dtpInicio.TabIndex = 38;
            // 
            // cbxPaciente
            // 
            this.cbxPaciente.FormattingEnabled = true;
            this.cbxPaciente.Location = new System.Drawing.Point(394, 276);
            this.cbxPaciente.Name = "cbxPaciente";
            this.cbxPaciente.Size = new System.Drawing.Size(121, 24);
            this.cbxPaciente.TabIndex = 37;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(394, 362);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 22);
            this.dtpFecha.TabIndex = 36;
            // 
            // cbxCirujano1
            // 
            this.cbxCirujano1.FormattingEnabled = true;
            this.cbxCirujano1.Location = new System.Drawing.Point(124, 225);
            this.cbxCirujano1.Name = "cbxCirujano1";
            this.cbxCirujano1.Size = new System.Drawing.Size(121, 24);
            this.cbxCirujano1.TabIndex = 35;
            this.cbxCirujano1.SelectionChangeCommitted += new System.EventHandler(this.cbxCirujano1_SelectionChangeCommitted);
            // 
            // cbxCirujano2
            // 
            this.cbxCirujano2.FormattingEnabled = true;
            this.cbxCirujano2.Location = new System.Drawing.Point(124, 360);
            this.cbxCirujano2.Name = "cbxCirujano2";
            this.cbxCirujano2.Size = new System.Drawing.Size(121, 24);
            this.cbxCirujano2.TabIndex = 34;
            // 
            // cbxEnfermero1
            // 
            this.cbxEnfermero1.FormattingEnabled = true;
            this.cbxEnfermero1.Location = new System.Drawing.Point(394, 69);
            this.cbxEnfermero1.Name = "cbxEnfermero1";
            this.cbxEnfermero1.Size = new System.Drawing.Size(121, 24);
            this.cbxEnfermero1.TabIndex = 33;
            this.cbxEnfermero1.SelectionChangeCommitted += new System.EventHandler(this.cbxEnfermero1_SelectionChangeCommitted);
            // 
            // cbxEnfermero2
            // 
            this.cbxEnfermero2.FormattingEnabled = true;
            this.cbxEnfermero2.Location = new System.Drawing.Point(394, 174);
            this.cbxEnfermero2.Name = "cbxEnfermero2";
            this.cbxEnfermero2.Size = new System.Drawing.Size(121, 24);
            this.cbxEnfermero2.TabIndex = 32;
            // 
            // cbxQuirofano
            // 
            this.cbxQuirofano.FormattingEnabled = true;
            this.cbxQuirofano.Location = new System.Drawing.Point(634, 364);
            this.cbxQuirofano.Name = "cbxQuirofano";
            this.cbxQuirofano.Size = new System.Drawing.Size(121, 24);
            this.cbxQuirofano.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(634, 276);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.TabIndex = 30;
            // 
            // label565
            // 
            this.label565.AutoSize = true;
            this.label565.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label565.Location = new System.Drawing.Point(287, 73);
            this.label565.Name = "label565";
            this.label565.Size = new System.Drawing.Size(101, 20);
            this.label565.TabIndex = 29;
            this.label565.Text = "Enfermero1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(541, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Quirofano:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Cirujano1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cirujano2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(550, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(550, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Enfermero2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(572, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(394, 404);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 34);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAgregarCirujia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.cbxPaciente);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbxCirujano1);
            this.Controls.Add(this.cbxCirujano2);
            this.Controls.Add(this.cbxEnfermero1);
            this.Controls.Add(this.cbxEnfermero2);
            this.Controls.Add(this.cbxQuirofano);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label565);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAgregarCirujia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarCirujia";
            this.Load += new System.EventHandler(this.frmAgregarCirujia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.ComboBox cbxPaciente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cbxCirujano1;
        private System.Windows.Forms.ComboBox cbxCirujano2;
        private System.Windows.Forms.ComboBox cbxEnfermero1;
        private System.Windows.Forms.ComboBox cbxEnfermero2;
        private System.Windows.Forms.ComboBox cbxQuirofano;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label565;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
    }
}