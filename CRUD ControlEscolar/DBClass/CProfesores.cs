using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ControlEscolar.DBClass
{
    internal class CProfesores
    {
        public void MostrarProfesores(DataGridView tablaProfesores)
        {
            try
            {
                DBClass conexion = new DBClass();

                String cmd = "Select idProfesor as 'ID', Nombre, Apellido, Telefono, Correo from profesores;";
                tablaProfesores.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd,conexion.CargarDriver());
                DataTable dt= new DataTable();
                adapter.Fill(dt);
                tablaProfesores.DataSource= dt;
                conexion.CerrarConexion();
            }
            catch(MySqlException ex)
            {
                throw;
            }

        }
        public void GuardarProfesores(TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Correo)
        {
            try
            {
                if(string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellido.Text) ||
             string.IsNullOrEmpty(Telefono.Text) || string.IsNullOrEmpty(Correo.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "insert into profesores (Nombre, Apellido, Telefono, Correo) values ('" + Nombre.Text + "','" + Apellido.Text
                        + "','" + Telefono.Text + "','" + Correo.Text + "');";

                    MySqlCommand comando = new MySqlCommand(cmd, conexion.CargarDriver());
                    MySqlDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Se guardaron los datos");
                    while (reader.Read())
                    {

                    }
                    conexion.CerrarConexion();
                }
                   
            }
            catch (MySqlException ex)
            {
                throw;
            }

        }
        public void SelectProfesores(DataGridView tablaP,TextBox ID,TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Correo)
        {
            try
            {
                ID.Text = tablaP.CurrentRow.Cells[0].Value.ToString();
                Nombre.Text = tablaP.CurrentRow.Cells[1].Value.ToString();
                Apellido.Text = tablaP.CurrentRow.Cells[2].Value.ToString();
                Telefono.Text = tablaP.CurrentRow.Cells[3].Value.ToString();
                Correo.Text = tablaP.CurrentRow.Cells[4].Value.ToString();
            }
            catch (MySqlException ex)
            {
                throw;
            }

        }

        public void ModificarProfesores(TextBox ID,TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Correo)
        {
            try
            {
                if(string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellido.Text) ||
            string.IsNullOrEmpty(Telefono.Text) || string.IsNullOrEmpty(Correo.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "update profesores set Nombre='" + Nombre.Text + "', Apellido='" + Apellido.Text
                        + "', Telefono='" + Telefono.Text + "', Correo='" + Correo.Text + "' where idProfesor= '" + ID.Text + "';";


                    MySqlCommand comando = new MySqlCommand(cmd, conexion.CargarDriver());
                    MySqlDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Se modificaron los datos");
                    while (reader.Read())
                    {

                    }
                    conexion.CerrarConexion();
                }
                
            }
            catch (MySqlException ex)
            {
                throw;
                MessageBox.Show("NO se actualizaron los datos");
            }

        }

        public void EliminarProfesores(TextBox ID)
        {
            try
            {
                DBClass conexion = new DBClass();
                String cmd = "delete from profesores where idProfesor= '"+ ID.Text +"';";


                MySqlCommand comando = new MySqlCommand(cmd, conexion.CargarDriver());
                MySqlDataReader reader = comando.ExecuteReader();
                MessageBox.Show("Se eliminaron los datos");
                while (reader.Read())
                {

                }
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                throw;
                MessageBox.Show("NO se eliminaron los datos");
            }

        }

        public void UsuarioConProfesor(TextBox Nombre, TextBox Apellido, TextBox Telefono)
        {
            try
            {
                if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellido.Text) ||
             string.IsNullOrEmpty(Telefono.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "CALL UsuarioConProfesor('" + Nombre.Text + "','" + Apellido.Text + "','" + Telefono.Text + "', 2);";
                    MySqlCommand comando = new MySqlCommand(cmd, conexion.CargarDriver());
                    MySqlDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Se guardaron los datos");
                    while (reader.Read())
                    {

                    }
                    conexion.CerrarConexion();
                }

            }
            catch (MySqlException ex)
            {
                throw;
            }
        }

        public void EliminarProfesorUsuario(TextBox ID)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text))
                {
                    MessageBox.Show("INGRESA UN ID");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "CALL EliminarProfesor('" + ID.Text + "');";

                    MySqlCommand comando = new MySqlCommand(cmd, conexion.CargarDriver());
                    MySqlDataReader reader = comando.ExecuteReader();
                    MessageBox.Show("Se eliminaron los datos");
                    while (reader.Read())
                    {

                    }
                    conexion.CerrarConexion();
                }

            }
            catch (MySqlException ex)
            {
                throw;
                MessageBox.Show("NO se eliminaron los datos");
            }
        }
    }
}
