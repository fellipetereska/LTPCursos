using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursos
{
    internal class banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            string con = @"server=db4free.net;uid=fellipetereska;pwd=mdaiik123;database=db_tereska;port=3306;";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = con;
            conn.Open();
            cmd.Connection = conn;
            return cmd;
        }
    }
}
