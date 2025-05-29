using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CRUD_ControlEscolar.Vistas
{
    public partial class EstudianteCrud : Form
    {
        public EstudianteCrud()
        {
            InitializeComponent();
            DBClass.Estudiantes objestudiantes = new DBClass.Estudiantes();
            objestudiantes.MostrarAlumnos(dgvTotalAlumnos);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EstudianteCrud_Load(object sender, EventArgs e)
        {

        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vistas.MenuInicio ola = new Vistas.MenuInicio();
            _ = ola.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 vista = new Form1();
            vista.ShowDialog();
        }

        private void dgvTotalAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIDAlumno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBClass.Estudiantes objest = new DBClass.Estudiantes();
            objest.UsuarioAlumno(txtNameAlumno, txtLastnameAlumno, txtTelefonoAlumno);
            objest.MostrarAlumnos(dgvTotalAlumnos);
            LimpiarCampos(txtNameAlumno, txtLastnameAlumno, txtCorreoAlumno, txtTelefonoAlumno, txtIDAlumno);
        }

        private void LimpiarCampos(TextBox Nombre, TextBox Apellido, TextBox Telefono, TextBox correo, TextBox ID)
        {
            // Limpiar el contenido de los campos de texto
            Nombre.Text = string.Empty;
            Apellido.Text = string.Empty;
            Telefono.Text = string.Empty;
            correo.Text = string.Empty;
            ID.Text = string.Empty;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DBClass.Estudiantes objest = new DBClass.Estudiantes();
            objest.ModificarAlumnos(txtIDAlumno, txtNameAlumno, txtLastnameAlumno, txtTelefonoAlumno, txtCorreoAlumno);
            objest.MostrarAlumnos(dgvTotalAlumnos);
            objest.ModificarAlumnos(txtIDAlumno, txtNameAlumno, txtLastnameAlumno, txtTelefonoAlumno, txtCorreoAlumno);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBClass.Estudiantes objest = new DBClass.Estudiantes();
            objest.EliminarAlumno(txtIDAlumno);
            objest.MostrarAlumnos(dgvTotalAlumnos);
            objest.ModificarAlumnos(txtIDAlumno, txtNameAlumno, txtLastnameAlumno, txtTelefonoAlumno, txtCorreoAlumno);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMaterias objmat = new CMaterias();
            _ = objmat.ShowDialog();
        }

        private void dgvTotalAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBClass.Estudiantes objalumnos = new DBClass.Estudiantes();
            objalumnos.SelectAlumnos(dgvTotalAlumnos, txtIDAlumno, txtNameAlumno, txtLastnameAlumno, txtTelefonoAlumno, txtCorreoAlumno);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}