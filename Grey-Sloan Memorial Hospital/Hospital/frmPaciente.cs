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
    public partial class frmPaciente : Form
    {
        NPaciente nPaciente = new NPaciente();
        public frmPaciente()
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

                EPaciente ePaciente = new EPaciente();
                ePaciente.Cedula = txtCedula.Text;
                ePaciente.Nombre = txtNombre.Text;
                ePaciente.Apellido1 = txtApellido1.Text;
                ePaciente.Apellido2 = txtApellido2.Text;
                int pid = int.Parse(txtId.Text);
                nPaciente.GuardarPaciente(ePaciente, pid);
                CargarPacientes();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
        }

        private void CargarPacientes()
        {
            dgvPacientes.DataSource = null;
            dgvPacientes.DataSource = nPaciente.CargarPacientes();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
            txtCedula.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
            txtNombre.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
            txtApellido1.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
            txtApellido2.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(dgvPacientes.CurrentRow.Cells[1].Value.ToString());
            nPaciente.EliminarPaciente(pid);
            CargarPacientes();
        }

        private void dgvPacientes_MouseClick(object sender, MouseEventArgs e)
        {
            Limpiar();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            CargarPacientes();
        }

        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(dgvPacientes.CurrentRow.Cells[1].Value.ToString());
            frmEnfermedad frm = new frmEnfermedad(pid);
            frm.Show();
        }
    }
}
