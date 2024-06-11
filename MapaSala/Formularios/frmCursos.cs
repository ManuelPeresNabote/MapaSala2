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
    public partial class frmCursos : Form
    {
        BindingSource dados;
        public frmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridcursos.DataSource = dados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
