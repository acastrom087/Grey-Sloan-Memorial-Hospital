using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace Hospital
{
    public partial class frmEnfermera : Form
    {
        NEnfermera nEnfermera = new NEnfermera();
        public frmEnfermera()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")
                {
                    txtId.Text = "0";
                }

                EEnfermera nurse = new EEnfermera();
                nurse.Cedula = txtCedula.Text;
                nurse.Nombre = txtNombre.Text;
                nurse.Apellido1 = txtApellido1.Text;
                nurse.Apellido2 = txtApellido2.Text;
                nurse.Salario = decimal.Parse( txtSalario.Text);
                int pid = int.Parse(txtId.Text);
                nEnfermera.GuardarEnfermera(nurse, pid);
                CargarEnfermeras();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CargarEnfermeras()
        {
            dgvEnfermera.DataSource = null;
            dgvEnfermera.DataSource = nEnfermera.CargarEnfermeras();
        }

        private void Limpiar()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtId.Text = "";
            txtSalario.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = dgvEnfermera.CurrentRow.Cells[0].Value.ToString();
            txtId.Text = dgvEnfermera.CurrentRow.Cells[2].Value.ToString();
            txtCedula.Text = dgvEnfermera.CurrentRow.Cells[3].Value.ToString();
            txtNombre.Text = dgvEnfermera.CurrentRow.Cells[4].Value.ToString();
            txtApellido1.Text = dgvEnfermera.CurrentRow.Cells[5].Value.ToString();
            txtApellido2.Text = dgvEnfermera.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(dgvEnfermera.CurrentRow.Cells[0].Value.ToString());
            nEnfermera.EliminarEnfermera(pid);
            CargarEnfermeras();
        }

        private void frmEnfermera_Load(object sender, EventArgs e)
        {
            CargarEnfermeras();
        }

        private void dgvEnfermera_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnIva_Click(object sender, EventArgs e)
        {
            EEnfermera eEnfermera = new EEnfermera();
            int pid = int.Parse(dgvEnfermera.CurrentRow.Cells[2].Value.ToString());
            eEnfermera.ModificarSalario(pid);
            CargarEnfermeras();
        }
    }
}
