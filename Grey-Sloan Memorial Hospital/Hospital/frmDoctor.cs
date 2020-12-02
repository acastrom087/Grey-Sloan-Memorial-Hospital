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
    public partial class frmDoctor : Form
    {
        NDoctor nDoctor = new NDoctor();
        public frmDoctor()
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

                EDoctor eDoctor = new EDoctor();
                eDoctor.Cedula = txtCedula.Text;
                eDoctor.Nombre = txtNombre.Text;
                eDoctor.Apellido1 = txtApellido1.Text;
                eDoctor.Apellido2 = txtApellido2.Text;
                eDoctor.Salario = decimal.Parse( txtSalario.Text);
                eDoctor.Corazon.Ritmo = 90;
                if(cbxEspecialidad.SelectedItem == null)
                {
                    throw new Exception("Debe Seleccionar una especialidad");
                }
                else
                {
                    eDoctor.Especialidad = cbxEspecialidad.SelectedItem.ToString();
                }
                
                int pid = int.Parse(txtId.Text);
                nDoctor.GuardarDoctor(eDoctor, pid);
                CargarDoctores();
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void CargarDoctores()
        {
            dgvDoctores.DataSource = null;
            dgvDoctores.DataSource = nDoctor.CargarDoctores();
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido2.Text = "";
            txtApellido1.Text = "";
            cbxEspecialidad.SelectedItem = null;
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            CargarDoctores();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtSalario.Text = dgvDoctores.CurrentRow.Cells[2].Value.ToString();
            txtId.Text = dgvDoctores.CurrentRow.Cells[3].Value.ToString();
            txtCedula.Text = dgvDoctores.CurrentRow.Cells[4].Value.ToString();
            txtNombre.Text = dgvDoctores.CurrentRow.Cells[5].Value.ToString();
            txtApellido1.Text = dgvDoctores.CurrentRow.Cells[6].Value.ToString();
            txtApellido2.Text = dgvDoctores.CurrentRow.Cells[7].Value.ToString();
            cbxEspecialidad.Text = dgvDoctores.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int pid = int.Parse(dgvDoctores.CurrentRow.Cells[1].Value.ToString());
            nDoctor.EliminarDoctor(pid);
            CargarDoctores();
        }

        private void dgvDoctores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            EDoctor eDoctor = new EDoctor();
            eDoctor.ModificarSalario(2);
        }
    }
}
