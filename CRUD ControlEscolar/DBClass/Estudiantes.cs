using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ControlEscolar.DBClass
{
    internal class Estudiantes
    {
        public void MostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                DBClass conexion = new DBClass();

                String cmd = "Select idAlumno as 'ID', Nombre, Apellido, Telefono, Correo from alumnos;";
                tablaAlumnos.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conexion.CargarDriver());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlumnos.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                throw;
            }

        }

        public void SelectAlumnos(DataGridView tablaP, TextBox ID, TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Correo)
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

        public void ModificarAlumnos(TextBox ID, TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox Correo)
        {
            try
            {
                if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellido.Text) ||
            string.IsNullOrEmpty(Telefono.Text) || string.IsNullOrEmpty(Correo.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "update alumnos set Nombre='" + Nombre.Text + "', Apellido='" + Apellido.Text
                        + "', Telefono='" + Telefono.Text + "', Correo='" + Correo.Text + "' where idAlumno= '" + ID.Text + "';";


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

        public void UsuarioAlumno(TextBox Nombre, TextBox Apellido, TextBox Telefono)
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
                    String cmd = "CALL UsuarioAlumno('" + Nombre.Text + "','" + Apellido.Text + "','" + Telefono.Text + "', 3);";
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

        public void EliminarAlumno(TextBox ID)
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
                    String cmd = "CALL EliminarAlumno('" + ID.Text + "');";

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
