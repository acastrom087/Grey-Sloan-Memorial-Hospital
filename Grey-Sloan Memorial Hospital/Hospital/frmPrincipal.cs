using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            frmDoctor frm = new frmDoctor();
            frm.Show();
        }

        private void btnEnfermera_Click(object sender, EventArgs e)
        {
            frmEnfermera frm = new frmEnfermera();
            frm.Show();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmPaciente frm = new frmPaciente();
            frm.Show();
        }

        private void btnCirujia_Click(object sender, EventArgs e)
        {
            frmCirujias frm = new frmCirujias();
            frm.Show();
        }
    }
}
