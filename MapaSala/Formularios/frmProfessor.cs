using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class frmProfessor : Form
    {
        BindingSource dados;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridProfessor.DataSource = dados;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
