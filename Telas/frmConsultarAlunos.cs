using MySql.Data.MySqlClient;
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
    public partial class frmConsultarAlunos : Form
    {
        public frmConsultarAlunos()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultarAlunos_Load(object sender, EventArgs e)
        {
            DataTable tabelaalunos = new DataTable();

            //string conn = "server=localhost;uid=root;pwd=mdaiik123;database=db_cadastros";
            string conn = "server=db4free.net;uid=fellipetereska;pwd=mdaiik123;database=db_tereska;port=3306;";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = conn;
            con.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM alunos";
            tabelaalunos.Load(cmd.ExecuteReader());
            gridAlunos.DataSource = tabelaalunos;
            con.Close();
        }
    }
}
