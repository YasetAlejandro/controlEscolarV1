using CRUD_ControlEscolar.Vistas;

namespace CRUD_ControlEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBClass.CProfesores objetoProfesores = new DBClass.CProfesores();
            objetoProfesores.MostrarProfesores(dgvTotalProfesores);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DBClass.CProfesores objProfesores = new DBClass.CProfesores();
            objProfesores.UsuarioConProfesor(txtName, txtLastname, txtTelefono);
            objProfesores.MostrarProfesores(dgvTotalProfesores);
            LimpiarCampos(txtName, txtLastname, txtTelefono, txtCorreo, txtID);

        }

        private void dgvTotalProfesores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DBClass.CProfesores objProfesores = new DBClass.CProfesores();
            objProfesores.SelectProfesores(dgvTotalProfesores, txtID, txtName, txtLastname, txtTelefono, txtCorreo);

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DBClass.CProfesores objProfesores = new DBClass.CProfesores();
            objProfesores.ModificarProfesores(txtID, txtName, txtLastname, txtTelefono, txtCorreo);
            objProfesores.MostrarProfesores(dgvTotalProfesores);
            LimpiarCampos(txtName, txtLastname, txtTelefono, txtCorreo, txtID);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DBClass.CProfesores objProfesores = new DBClass.CProfesores();
            objProfesores.EliminarProfesorUsuario(txtID);
            objProfesores.MostrarProfesores(dgvTotalProfesores);
            LimpiarCampos(txtName, txtLastname, txtTelefono, txtCorreo, txtID);
        }

        private void dgvTotalProfesores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        internal void HideDialog()
        {
            throw new NotImplementedException();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vistas.MenuInicio objmenu = new Vistas.MenuInicio();
            _ = objmenu.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vistas.EstudianteCrud vista = new Vistas.EstudianteCrud();
            _ = vista.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvTotalProfesores_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMaterias objmat = new CMaterias();
            objmat.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}