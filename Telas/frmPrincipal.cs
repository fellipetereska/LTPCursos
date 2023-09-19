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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno CadAluno = new frmCadastrarAluno();
            CadAluno.ShowDialog();
        }

        private void cadastrarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarProfessor CadProfessor = new frmCadastrarProfessor();
            CadProfessor.ShowDialog();
        }

        private void consultarAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmConsultarAlunos consultarAlunos = new frmConsultarAlunos();
            consultarAlunos.ShowDialog();
        }

        private void cadastrarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarCurso cadastrarCurso = new frmCadastrarCurso();
            cadastrarCurso.ShowDialog();
        }

        private void cadastrarDiciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrarDisciplinas cadastrarDisciplinas = new frmCadastrarDisciplinas();
            cadastrarDisciplinas.ShowDialog();
        }

        private void consultarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarProfessor consultarProfessor = new frmConsultarProfessor();
            consultarProfessor.ShowDialog();
        }

        private void consultarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCursos consultarlivros = new frmConsultarCursos();
            consultarlivros.ShowDialog();
        }

        private void consultarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarDisciplinas consultardisciplinas = new frmConsultarDisciplinas();
            consultardisciplinas.ShowDialog();
        }

        private void mudarDeMenuParaBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnBtns.Visible = true;
            menuStrip1.Visible = false;
        }

        private void btnCadastroAlunos_Click(object sender, EventArgs e)
        {
            frmCadastrarAluno CadAluno = new frmCadastrarAluno();
            CadAluno.ShowDialog();
        }

        private void btnConsultarAlunos_Click(object sender, EventArgs e)
        {
            frmConsultarAlunos consultarAlunos = new frmConsultarAlunos();
            consultarAlunos.ShowDialog();
        }

        private void btnCadastrarProfessores_Click(object sender, EventArgs e)
        {
            frmCadastrarProfessor CadProfessor = new frmCadastrarProfessor();
            CadProfessor.ShowDialog();
        }

        private void btnConsultarProfessores_Click(object sender, EventArgs e)
        {
            frmConsultarProfessor consultarProfessor = new frmConsultarProfessor();
            consultarProfessor.ShowDialog();
        }

        private void btnCadastraCursos_Click(object sender, EventArgs e)
        {
            frmCadastrarCurso cadastrarCurso = new frmCadastrarCurso();
            cadastrarCurso.ShowDialog();
        }

        private void btnConsultarCursos_Click(object sender, EventArgs e)
        {
            frmConsultarCursos consultarlivros = new frmConsultarCursos();
            consultarlivros.ShowDialog();
        }

        private void btnCadastrarMaterias_Click(object sender, EventArgs e)
        {
            frmCadastrarDisciplinas cadastrarDisciplinas = new frmCadastrarDisciplinas();
            cadastrarDisciplinas.ShowDialog();
        }

        private void btnConsultarMaterias_Click(object sender, EventArgs e)
        {
            frmConsultarDisciplinas consultardisciplinas = new frmConsultarDisciplinas();
            consultardisciplinas.ShowDialog();
        }

        private void btnUsarMenu_Click(object sender, EventArgs e)
        {
            pnBtns.Visible = false;
            menuStrip1.Visible = true;
        }
    }
}
