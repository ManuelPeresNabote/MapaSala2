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
        DataTable dados;
        int LinhaSelecionada;
        public frmCursos()
        {
            InitializeComponent();
            dados = new DataTable();

            foreach (var atributos in typeof(CursoEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Desenvolvimento de Sistemas", "Manhã", true);
            dados.Rows.Add(2, "Administração", "Manhã", true);
            dados.Rows.Add(3, "Serviços Jurísdicos", "Noite", false);
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

            dados.Rows.Add(c);
        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtId.Text = "";
            txtTurno.Text = "";
            chkAtivo.Checked = false;
        }


        private void bttExcluir_Click(object sender, EventArgs e)
        {
            dtGridcursos.Rows.RemoveAt(LinhaSelecionada);
        }

        private void dtGridcursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridcursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtGridcursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtId.Text = dtGridcursos.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            chkAtivo.Checked = Convert.ToBoolean(dtGridcursos.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtGridcursos.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNome.Text;
            minhamae.Cells[2].Value = txtTurno.Text;
            minhamae.Cells[3].Value = chkAtivo.Checked;
        }
    }
}
