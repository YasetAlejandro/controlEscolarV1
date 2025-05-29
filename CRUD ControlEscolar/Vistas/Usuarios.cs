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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            DBClass.CUsuarios objusuario = new DBClass.CUsuarios();
            objusuario.MostrarUsuarios(dgvUsuarios);
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DBClass.CUsuarios objusuarios = new DBClass.CUsuarios();
            objusuarios.MostrarUsuarios(dgvUsuarios);

        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuInicio menuInicio = new MenuInicio();
            menuInicio.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstudianteCrud estudianteCrud = new EstudianteCrud();
            estudianteCrud.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMaterias materia = new CMaterias();
            materia.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
