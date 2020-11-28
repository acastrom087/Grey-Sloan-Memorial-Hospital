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
        NPaciente nPaciente = new NPaciente();
        NCirujia nCirujia = new NCirujia();
        NQuirofano nQuirofano = new NQuirofano();
        
       
       
        public frmAgregarCirujia()
        {
            InitializeComponent();
        }

        private void LlenarQuirofanos()
        {
            var qui = new Dictionary<int, int?>();
            foreach (var i in nQuirofano.CargarQuirofanos()) 
            {
                qui.Add(i.Id, i.NumeroQuirofano);

            }
            cbxQuirofano.DataSource = qui.ToList();
            cbxQuirofano.ValueMember = "Key";
            cbxQuirofano.DisplayMember = "Value";

        }

        private void LlenarPacientes()
        {
            var paciente = new Dictionary<int, string>();
            foreach (EPaciente ePaciente in nPaciente.CargarPacientes()) 
            {
                //foreach (ECirujia eCirujia in nCirujia.CargarCirujias()  )
                //{
                   // if(ePaciente.Id != eCirujia.id_paciente)
                   // {
                        paciente.Add(ePaciente.Id, ePaciente.Nombre + " " + ePaciente.Apellido1);
                   // }
                //}

            }
            cbxPaciente.DataSource = paciente.ToList();
            cbxPaciente.ValueMember = "Key";
            cbxPaciente.DisplayMember = "Value";

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
            LlenarPacientes();
            LlenarQuirofanos();
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd / MM / yyyy HH: mm";
            dtpFinal.Format = DateTimePickerFormat.Custom;
            dtpFinal.CustomFormat = "dd / MM / yyyy HH: mm";
        }

        private void cbxCirujano1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarDoctores2();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ECirujia eCirujia = new ECirujia();
                eCirujia.id_quirofano = int.Parse(cbxQuirofano.SelectedValue.ToString());
                eCirujia.id_cirujano_principal = int.Parse(cbxCirujano1.SelectedValue.ToString());
                eCirujia.id_cirujano2 = int.Parse(cbxCirujano2.SelectedValue.ToString());
                eCirujia.id_enfermero1 = int.Parse(cbxEnfermero1.SelectedValue.ToString());
                eCirujia.id_enfermero2 = int.Parse(cbxEnfermero2.SelectedValue.ToString());
                eCirujia.id_paciente = int.Parse(cbxPaciente.SelectedValue.ToString());
                eCirujia.fecha = DateTime.Parse(dtpFecha.Value.ToString("dd/MM/yyyy"));
                eCirujia.horaInicio = DateTime.Parse(dtpInicio.Value.ToString("dd/MM/yyyy HH:mm"));
                eCirujia.horaFinal = DateTime.Parse(dtpFinal.Value.ToString("dd/MM/yyyy HH:mm"));
                nCirujia.GuardarCirujias(eCirujia, 0);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbxEnfermero1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarEnfermeras2();
        }
    }
}
