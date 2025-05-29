using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_ControlEscolar.Vistas
{
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 vista = new Form1();
            _ = vista.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("APLICACION HECHA POR ALUMNOS DE ISOF GPO.01");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }


        private void alumnoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EstudianteCrud objAlumnos = new EstudianteCrud();
            objAlumnos.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMaterias objmat = new CMaterias();
            objmat.ShowDialog();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}