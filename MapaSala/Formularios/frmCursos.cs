using Model.Entitidades;
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

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            CursoEntidade c = new CursoEntidade();
            c.Id = Convert.ToInt32(txtId.Text);
            c.Nome = txtNome.Text;
            c.Turno = txtTurno.Text;
            c.Ativo = chkAtivo.Checked;

            dados.Add(c);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtTurno.Text = "";
            chkAtivo.Checked = false;
        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
