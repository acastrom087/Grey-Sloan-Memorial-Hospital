namespace Hospital
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnCirujia = new System.Windows.Forms.Button();
            this.btnEnfermera = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(307, 135);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(95, 76);
            this.btnDoctor.TabIndex = 0;
            this.btnDoctor.Text = "Doctor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnCirujia
            // 
            this.btnCirujia.Location = new System.Drawing.Point(521, 266);
            this.btnCirujia.Name = "btnCirujia";
            this.btnCirujia.Size = new System.Drawing.Size(95, 76);
            this.btnCirujia.TabIndex = 1;
            this.btnCirujia.Text = "Cirujias";
            this.btnCirujia.UseVisualStyleBackColor = true;
            this.btnCirujia.Click += new System.EventHandler(this.btnCirujia_Click);
            // 
            // btnEnfermera
            // 
            this.btnEnfermera.Location = new System.Drawing.Point(521, 135);
            this.btnEnfermera.Name = "btnEnfermera";
            this.btnEnfermera.Size = new System.Drawing.Size(95, 76);
            this.btnEnfermera.TabIndex = 2;
            this.btnEnfermera.Text = "Enfermeras";
            this.btnEnfermera.UseVisualStyleBackColor = true;
            this.btnEnfermera.Click += new System.EventHandler(this.btnEnfermera_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Location = new System.Drawing.Point(307, 266);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(95, 76);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnEnfermera);
            this.Controls.Add(this.btnCirujia);
            this.Controls.Add(this.btnDoctor);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnCirujia;
        private System.Windows.Forms.Button btnEnfermera;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}