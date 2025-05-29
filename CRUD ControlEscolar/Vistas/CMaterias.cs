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
    public partial class CMaterias : Form
    {
        public CMaterias()
        {
            InitializeComponent();
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.MostrarMaterias(dgvTotalMaterias);
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstudianteCrud objest = new EstudianteCrud();
            _ = objest.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio objmenu = new MenuInicio();
            _ = objmenu.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objprof = new Form1();
            _ = objprof.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.GuardarMaterias(txtIDProfesor, txtNameMateria);
            objmat.MostrarMaterias(dgvTotalMaterias);
            LimpiarCampos(txtIDMateria, txtIDProfesor, txtNameMateria);

        }

        private void LimpiarCampos(TextBox ID, TextBox idprofe, TextBox materia)
        {
            // Limpiar el contenido de los campos de texto
            ID.Text = string.Empty;
            idprofe.Text = string.Empty;
            materia.Text = string.Empty;
        }

        private void dgvTotalMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.MostrarMaterias(dgvTotalMaterias);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.ModificarMateria(txtIDMateria, txtIDProfesor, txtNameMateria);
            objmat.MostrarMaterias(dgvTotalMaterias);
            LimpiarCampos(txtIDMateria, txtIDProfesor, txtNameMateria);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.EliminarMateria(txtIDMateria);
            objmat.MostrarMaterias(dgvTotalMaterias);
            LimpiarCampos(txtIDMateria, txtIDProfesor, txtNameMateria);

        }

        private void CMaterias_Load(object sender, EventArgs e)
        {

        }

        private void dgvTotalMaterias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBClass.Materias objmat = new DBClass.Materias();
            objmat.SelectMaterias(dgvTotalMaterias, txtIDMateria, txtIDProfesor, txtNameMateria);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
