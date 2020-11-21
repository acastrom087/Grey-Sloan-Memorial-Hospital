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
    public partial class frmAgregarCirujia : Form
    {
        NDoctor nDoctor = new NDoctor();
        NEnfermera nEnfermera = new NEnfermera();
       
        public frmAgregarCirujia()
        {
            InitializeComponent();
        }

        private void LlenarEnfermeras1()
        {
            var nur = new Dictionary<int, string>();
            foreach (EEnfermera eEnfermera  in nEnfermera.CargarEnfermeras())
            {
                nur.Add(eEnfermera.Id, eEnfermera.Nombre + " " + eEnfermera.Apellido1);

            }

            cbxEnfermero1.DataSource = nur.ToList();
            cbxEnfermero1.ValueMember = "Key";
            cbxEnfermero1.DisplayMember = "Value";
        }

        private void LlenarEnfermeras2()
        {
            var nur = new Dictionary<int, string>();
            foreach (EEnfermera eEnfermera in nEnfermera.CargarEnfermeras())
            {
                if(eEnfermera.Id.ToString() != cbxEnfermero1.SelectedValue.ToString()) 
                { 
                nur.Add(eEnfermera.Id, eEnfermera.Nombre + " " + eEnfermera.Apellido1);
                }
            }

            cbxEnfermero2.DataSource = nur.ToList();
            cbxEnfermero2.ValueMember = "Key";
            cbxEnfermero2.DisplayMember = "Value";
        }



        private void LlenarDoctores1()
        {
            var doc = new Dictionary<int, string>();
            foreach (EDoctor eDoctor in nDoctor.CargarDoctores())
            {
                doc.Add(eDoctor.Id, eDoctor.Nombre + " " + eDoctor.Apellido1);
                
            }
            
            cbxCirujano1.DataSource = doc.ToList();
            cbxCirujano1.ValueMember = "Key";
            cbxCirujano1.DisplayMember = "Value";
        }

        private void LlenarDoctores2()
        {
            var doc = new Dictionary<int, string>();
            foreach (EDoctor eDoctor in nDoctor.CargarDoctores())
            {
               if (eDoctor.Id.ToString() != cbxCirujano1.SelectedValue.ToString())
               {
                    doc.Add(eDoctor.Id, eDoctor.Nombre + " " + eDoctor.Apellido1);
               }
            }
            
            cbxCirujano2.DataSource = doc.ToList();
            cbxCirujano2.ValueMember = "Key";
            cbxCirujano2.DisplayMember = "Value";
        }



        private void frmAgregarCirujia_Load(object sender, EventArgs e)
        {
            LlenarDoctores1();
            LlenarEnfermeras1();
        }

        private void cbxCirujano1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDoctores2();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string feo = cbxCirujano1.SelectedValue.ToString();
            
            MessageBox.Show(feo);
        }

        private void cbxEnfermero1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarEnfermeras2();
        }
    }
}
