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

            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "MAT", true);
            dados.Rows.Add(2, "Português", "PORT", true);
            dados.Rows.Add(3, "Física", "FIS", false);

            dtGriddisciplinas.DataSource = dados;
        }

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade d = new DisciplinasEntidade();
            d.Id = Convert.ToInt32(txtId.Text);
            d.Nome = txtNome.Text;
            d.Sigla = txtSigla.Text;
            d.Ativo = chkAtivo.Checked;

            dados.Rows.Add(d.Linha());


        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
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

        private void dtGriddisciplinas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGriddisciplinas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGriddisciplinas.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtId.Text = dtGriddisciplinas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtGriddisciplinas.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNome.Text;
            minhamae.Cells[2].Value = txtSigla.Text;
        }
    }
}
