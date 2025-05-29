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
    public partial class Login : Form
    {
        public string user1 = "10002552";
        public string pass1 = "EVA10002552";
        public string user2 = "10003223";
        public string pass2 = "YME10003223";
        public Login()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUser.Text == user1 && txtPassword.Text == pass1)
            {
                this.Hide();
                MenuInicio menuInicio = new MenuInicio();
                menuInicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtUser.Text == user2 && txtPassword.Text == pass2)
            {
                this.Hide();
                MenuInicio menuInicio = new MenuInicio();
                menuInicio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecto", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMostrar_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = btnMostrar.Checked ? '\0' : '*';
        }
    }
}
