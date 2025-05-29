using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ControlEscolar.DBClass
{
    internal class CUsuarios
    {
        public void MostrarUsuarios(DataGridView tablaUsuarios)
        {
            try
            {
                DBClass conexion = new DBClass();

                String cmd = "Select * from usuarios ORDER BY Usuario ASC;";
                tablaUsuarios.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conexion.CargarDriver());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaUsuarios.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }

    }
}
