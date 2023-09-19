using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Cursos
{
    public class cadastrarAluno
    {
        //Metodo Construtor
        public cadastrarAluno(int id=0, string nome=null, string cpf = null, string rg = null, string endereço = null, string dtMatricula = null, string dtNascimento = null, string curso = null, string sexo = null)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Endereco = endereço;
            this.DtMatricula = dtMatricula;
            this.DtNascimento = dtNascimento;
            this.Curso = curso;
            this.Sexo = sexo;
        }

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }
        public string DtMatricula { get; set; }
        public string DtNascimento { get; set; }
        public string Curso { get; set; }
        public string Sexo { get; set; }

        public void Inserir()
        {
            string cmdValue = "'" + Nome + "','" + Cpf + "','" + Rg + "','" + Endereco + "','" + DtMatricula + "','" + DtNascimento + "','" + Curso + "','" + Sexo + "'";
            var cmd = banco.Abrir();
            cmd.CommandText = "INSERT INTO alunos (nome, cpf, rg, endereco, dataMatricula, dataNascimento, curso, sexo) VALUES ("+cmdValue+")";
            cmd.ExecuteNonQuery();

            //MySqlCommand cmd = new MySqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = "INSERT INTO alunos (nome, cpf, rg, endereco, dataMatricula, dataNascimento, curso, sexo) VALUES (" + cmdValue+")";
            //MessageBox.Show("Cadastrado com Sucesso!");
            //cmd.ExecuteNonQuery();
        }
    }
}
