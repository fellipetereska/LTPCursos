using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursos
{
    public partial class frmCadastrarProfessor : Form
    {
        public frmCadastrarProfessor()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            numCpf.Value = 0;
            numRg.Value = 0;
            cbxSexo.Text = "";
            cbxCurso.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
