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
    public partial class frmDisciplinas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public frmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();
            dtGriddisciplinas.DataSource = dados;
        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade d = new DisciplinasEntidade();
            d.Id = Convert.ToInt32(txtId.Text);
            d.Nome = txtNome.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkAtivo.Checked;
            dados.Add(d);

        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNome.Text = "";
            txtSigla.Text = "";
            chkAtivo.Checked = false;
        }

        private void frmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            dtGriddisciplinas.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
