using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapaSala.Formularios;

namespace MapaSala
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalas s = new frmSalas();
            s.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfessor s = new frmProfessor();
            s.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisciplinas s = new frmDisciplinas();
            s.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCursos s = new frmCursos();
            s.ShowDialog();
        }
    }
}
