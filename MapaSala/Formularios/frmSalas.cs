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
        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalasEntidade salas = new SalasEntidade();
            salas.Id = Convert.ToInt32(txtId.Text);
            salas.Nome = txtNome.Text;
            salas.IsLab = chkIsLab.Checked;
            salas.NumeroCadeiras = Convert.ToInt32(txtNumCadeira.Value);
            salas.NumeroComputadores = Convert.ToInt32(txtNumPc.Value);
            salas.Disponivel = chkDisponivel.Checked;

            dados.Add(salas);
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
