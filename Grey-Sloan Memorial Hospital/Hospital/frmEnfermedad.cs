using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace Hospital
{
    public partial class frmEnfermedad : Form
    {
        int Id = 0;
        NEnfermedad nEnfermedad = new NEnfermedad();
        NPaciente nPaciente = new NPaciente();
        public frmEnfermedad(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void LlenarEnfermedad()
        {
            var nur = new Dictionary<int, string>();
            foreach (EEnfermedad eEnfermedad in nEnfermedad.CargarEnfermedades())
            {
                nur.Add(eEnfermedad.Id, eEnfermedad.Nombre );

            }

            cbxEnfermedades.DataSource = nur.ToList();
            cbxEnfermedades.ValueMember = "Key";
            cbxEnfermedades.DisplayMember = "Value";
        }

        private void frmEnfermedad_Load(object sender, EventArgs e)
        {
            LlenarEnfermedad();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int pid = int.Parse( cbxEnfermedades.SelectedValue.ToString());
            nPaciente.Agregacion(Id, pid);
            this.Close();

        }
    }
}
