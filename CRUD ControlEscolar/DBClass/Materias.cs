using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_ControlEscolar.DBClass
{
    internal class Materias
    {
        public void MostrarMaterias(DataGridView tablaMaterias)
        {
            try
            {
                DBClass conexion = new DBClass();

                String cmd = "select materias.idMateria as 'ID Materia', profesores.idProfesor as 'ID Profesor', materias.Nombre as 'Materia', CONCAT(profesores.Nombre, profesores.Apellido) AS 'Profesor' from materias inner join profesores on idProfesor=id_profesor;";
                tablaMaterias.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conexion.CargarDriver());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaMaterias.DataSource = dt;
                conexion.CerrarConexion();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }


        public void SelectMaterias(DataGridView tablaP, TextBox ID, TextBox idprofe, TextBox materia)
        {
            try
            {
                ID.Text = tablaP.CurrentRow.Cells[0].Value.ToString();
                idprofe.Text = tablaP.CurrentRow.Cells[1].Value.ToString();
                materia.Text = tablaP.CurrentRow.Cells[2].Value.ToString();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }


        public void GuardarMaterias(TextBox idprofe, TextBox nombre)
        {
            try
            {
                if (string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(idprofe.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    String cmd = "insert into Materias (id_profesor, Nombre) values  ('"+ idprofe.Text
                        + "','" + nombre.Text + "');";

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
                throw ex;
            }
        }

        /*public void ModificarMateria(TextBox ID, TextBox Nombre, TextBox id_profesor)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Nombre.Text) ||
            string.IsNullOrEmpty(id_profesor.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    int.TryParse(id_profesor.Text, out int idProfesor);
                    String cmd = "update materias set  id_profesor='" + idProfesor + "', Nombre='" 
                        + Nombre.Text + "' where idMateria= '" + ID.Text + "';";


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
                throw ex;
                MessageBox.Show("NO se actualizaron los datos");
            }

        }*/

        public void ModificarMateria(TextBox ID, TextBox id_profesor, TextBox Nombre)
        {
            try
            {
                if (string.IsNullOrEmpty(ID.Text) || string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(id_profesor.Text))
                {
                    MessageBox.Show("FAVOR DE LLENAR LOS DATOS COMPLETOS");
                }
                else
                {
                    DBClass conexion = new DBClass();
                    int.TryParse(id_profesor.Text, out int idProfesor);

                    String cmd = "UPDATE materias SET id_profesor=@idProfesor, Nombre=@Nombre WHERE idMateria=@ID;";

                    using (MySqlConnection connection = conexion.CargarDriver())
                    using (MySqlCommand comando = new MySqlCommand(cmd, connection))
                    {
                        

                        // Set parameters to avoid SQL injection
                        comando.Parameters.AddWithValue("@idProfesor", idProfesor);
                        comando.Parameters.AddWithValue("@Nombre", Nombre.Text);
                        comando.Parameters.AddWithValue("@ID", ID.Text);

                        int rowsAffected = comando.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Se modificaron los datos");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el registro para actualizar");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de base de datos: " + ex.Message);
            }
        }



        public void EliminarMateria(TextBox ID)
        {
            try
            {
                DBClass conexion = new DBClass();
                String cmd = "delete from materias where idMateria= '" + ID.Text + "';";


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


    }
}