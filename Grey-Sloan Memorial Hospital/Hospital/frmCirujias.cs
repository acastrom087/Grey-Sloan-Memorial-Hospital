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
    public partial class frmCirujias : Form
    {
        NCirujia nCirujia = new NCirujia();
        
        public frmCirujias()
        {
            InitializeComponent();
        }

        private void CargarCirujuas()
        {
            
            dgvCirujias.DataSource = null;
            dgvCirujias.DataSource = nCirujia.MostrarCirujias();
            
        }

        private void frmCirujias_Load(object sender, EventArgs e)
        {
            CargarCirujuas();

        }

 

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = int.Parse(dgvCirujias.CurrentRow.Cells[0].Value.ToString());
                nCirujia.EliminarCirujias(pid);
                CargarCirujuas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarCirujia frm = new frmAgregarCirujia();
            frm.Show();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            CargarCirujuas();
        }
    }
}
