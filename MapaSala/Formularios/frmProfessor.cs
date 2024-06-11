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
            ProfessoresEntidade p = new ProfessoresEntidade();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Nome = txtNome.Text;
            p.Apelido = txtApelido.Text;
            dados.Add(p);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtApelido.Text = "";
            txtNome.Text = "";
            txtId.Text = "";
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
