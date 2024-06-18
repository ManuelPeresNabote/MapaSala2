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
    public partial class frmSalas : Form
    {
        DataTable dados;
        int LinhaSelecionada;

        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();
            foreach (var atributos in typeof(SalasEntidade).GetProperties())
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Maker", 20, 40,false,true);
            dados.Rows.Add(2, "Laboratório", 40, 40,true,false);
            dados.Rows.Add(3, "Quadra", 0, 0,false,false);

            dtGridSalas.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalasEntidade salas = new SalasEntidade();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtNome.Text;
            salas.IsLab = chkIsLab.Checked;
            salas.NumeroCadeiras = Convert.ToInt32(numCadeira.Value);
            salas.NumeroComputadores = Convert.ToInt32(numPc.Value);
            salas.Disponivel = chkDisponivel.Checked;

            dados.Rows.Add(salas.Linha());
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }
        private void LimparCampos()
        {
            txtId.Text = "";
            txtNome.Text = "";
            numPc.Value = 0;
            numCadeira.Value = 0;
            chkIsLab.Checked = false;
            chkDisponivel.Checked = false;
        }

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtId.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[0].Value.ToString();
            txtNome.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            numPc.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value);
            numCadeira.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            chkIsLab.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value);
            

        }

        private void bttExcluir_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void bttEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow minhamae = dtGridSalas.Rows[LinhaSelecionada];
            minhamae.Cells[0].Value = txtId.Text;
            minhamae.Cells[1].Value = txtNome.Text;
            minhamae.Cells[2].Value = numPc.Value;
            minhamae.Cells[3].Value = numCadeira.Value;
            minhamae.Cells[4].Value = chkIsLab.Checked;
            minhamae.Cells[5].Value = chkDisponivel.Checked;

        }
    }
}
