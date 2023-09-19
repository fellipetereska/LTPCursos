using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cursos
{
    public partial class frmCadastrarAluno : Form
    {
        public frmCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNome.Clear();
            maskCPF.Clear();
            maskRG.Clear();
            dtNascimento.Text = "06/09/2023 21:30";
            dtMatricula.Text = "06/09/2023 21:30";
            txtEndereço.Clear();
            cbxSexo.Text = "";
            cbxCurso.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarAluno aluno = new cadastrarAluno(
                0, 
                txtNome.Text, 
                maskCPF.Text, 
                maskRG.Text, 
                txtEndereço.Text, 
                dtMatricula.Text, 
                dtNascimento.Text, 
                cbxCurso.Text, 
                cbxSexo.Text 
                );

            aluno.Inserir();
            MessageBox.Show("Aluno Inserido com sucesso!");

            txtMatricula.Clear();
            txtNome.Clear();
            maskCPF.Clear();
            maskRG.Clear();
            dtNascimento.Text = "06/09/2023 21:30";
            dtMatricula.Text = "06/09/2023 21:30";
            txtEndereço.Clear();
            cbxSexo.Text = "";
            cbxCurso.Text = "";




            //string cmdValue = "'"+txtNome.Text + "','" + maskCPF.Text +"','"+ maskRG.Text+"','"+txtEndereço.Text+"','"+dtMatricula.Value+"','"+dtNascimento.Value+"','"+cbxCurso.Text+"','"+cbxSexo.Text+"'";

            //string conn = "server=db4free.net;uid=fellipetereska;pwd=mdaiik123;database=db_tereska;port=3306;";
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = conn;
            //con.Open();

            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "INSERT INTO alunos (nome, cpf, rg, endereco, dataMatricula, dataNascimento, curso, sexo) VALUES (" + cmdValue+")";
            //MessageBox.Show("Cadastrado com Sucesso!");
            //cmd.ExecuteNonQuery();

            //con.Close();
        }

        private void frmCadastrarAluno_Load(object sender, EventArgs e)
        {
            //DataTable cbxCursos = new DataTable();

            //string conn = "server=db4free.net;uid=fellipetereska;pwd=mdaiik123;database=db_tereska;port=3306;";
            //MySqlConnection con = new MySqlConnection();
            //con.ConnectionString = conn;
            //con.Open();

            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "SELECT nome FROM cursos";
            //cbxCursos.Load(cmd.ExecuteReader());
            //cbxCurso.DataSource = cbxCursos;
            //cbxCurso.DisplayMember = "nome";
            //con.Close();
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxCurso_Click(object sender, EventArgs e)
        {

        }
    }
}
