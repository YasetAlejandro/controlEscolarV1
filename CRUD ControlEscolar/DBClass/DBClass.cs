using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ControlEscolar.DBClass
{
    internal class DBClass
    {
        MySqlConnection cn = new MySqlConnection();
        
        static string user = "root";
        static string password = "";
        static string servidor = "localhost";
        static string bd = "controlescolar1";
        static string puerto = "3306";
        string cadenaconexion = "server="+servidor+";"+"port="+puerto+";"+ "user id="+user+ ";"+ "password="+password+ ";"+"database="+bd+";";

        public MySqlConnection CargarDriver()
        {
            try
            {
                cn.ConnectionString = cadenaconexion;
                cn.Open();
                //MessageBox.Show("Se conecto");
            }catch (MySqlException ex)
            {
                throw;
            }
            return cn;
        }
        public void CerrarConexion()
        {
            cn.Close();
        }

    }
}
