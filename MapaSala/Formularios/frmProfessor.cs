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
        DataTable dados;
        int LinhaSelecionada;
        public frmProfessor()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(ProfessoresEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Silvia Marangoni", "Marangoni");
            dados.Rows.Add(2, "Luciano", "Lu");
            dados.Rows.Add(3, "Rafael", "Rafa" );

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
            dados.Rows.Add(p);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtApelido.Text = "";
            txtNome.Text = "";
            txtId.Text = "";
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {

        }

        private void dtGridProfessor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtApelido.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtId.Text = dtGridProfessor.Rows[LinhaSelecionada].Cells[3].Value.ToString();
        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            dtGridProfessor.Rows.RemoveAt(LinhaSelecionada);
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtGridProfessor.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNome.Text;
            minhamae.Cells[2].Value = txtApelido.Text;
        }
    }
}
