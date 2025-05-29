namespace CRUD_ControlEscolar.Vistas
{
    partial class EstudianteCrud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudianteCrud));
            txtCorreoAlumno = new TextBox();
            txtTelefonoAlumno = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnEliminar = new Button();
            btnModify = new Button();
            btnGuardar = new Button();
            txtLastnameAlumno = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtNameAlumno = new TextBox();
            txtIDAlumno = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvTotalAlumnos = new DataGridView();
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnMin = new Button();
            btnMax = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalAlumnos).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCorreoAlumno
            // 
            txtCorreoAlumno.Enabled = false;
            txtCorreoAlumno.Location = new Point(241, 217);
            txtCorreoAlumno.Margin = new Padding(3, 4, 3, 4);
            txtCorreoAlumno.Name = "txtCorreoAlumno";
            txtCorreoAlumno.Size = new Size(102, 27);
            txtCorreoAlumno.TabIndex = 12;
            // 
            // txtTelefonoAlumno
            // 
            txtTelefonoAlumno.Location = new Point(75, 217);
            txtTelefonoAlumno.Margin = new Padding(3, 4, 3, 4);
            txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            txtTelefonoAlumno.Size = new Size(102, 27);
            txtTelefonoAlumno.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(185, 221);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 221);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 9;
            label4.Text = "Telefono";
            label4.Click += label4_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatStyle = FlatStyle.System;
            btnEliminar.Location = new Point(161, 325);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(129, 45);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModify
            // 
            btnModify.FlatStyle = FlatStyle.System;
            btnModify.Location = new Point(23, 325);
            btnModify.Margin = new Padding(3, 4, 3, 4);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(131, 45);
            btnModify.TabIndex = 7;
            btnModify.Text = "Modificar";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.Location = new Point(23, 271);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(267, 47);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtLastnameAlumno
            // 
            txtLastnameAlumno.Location = new Point(75, 167);
            txtLastnameAlumno.Margin = new Padding(3, 4, 3, 4);
            txtLastnameAlumno.Name = "txtLastnameAlumno";
            txtLastnameAlumno.Size = new Size(268, 27);
            txtLastnameAlumno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 172);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCorreoAlumno);
            groupBox1.Controls.Add(txtTelefonoAlumno);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtLastnameAlumno);
            groupBox1.Controls.Add(txtNameAlumno);
            groupBox1.Controls.Add(txtIDAlumno);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 91);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(390, 440);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Alumno";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtNameAlumno
            // 
            txtNameAlumno.Location = new Point(75, 113);
            txtNameAlumno.Margin = new Padding(3, 4, 3, 4);
            txtNameAlumno.Name = "txtNameAlumno";
            txtNameAlumno.Size = new Size(268, 27);
            txtNameAlumno.TabIndex = 4;
            // 
            // txtIDAlumno
            // 
            txtIDAlumno.Enabled = false;
            txtIDAlumno.Location = new Point(75, 60);
            txtIDAlumno.Margin = new Padding(3, 4, 3, 4);
            txtIDAlumno.Name = "txtIDAlumno";
            txtIDAlumno.Size = new Size(134, 27);
            txtIDAlumno.TabIndex = 3;
            txtIDAlumno.TextChanged += txtIDAlumno_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 115);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 61);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // dgvTotalAlumnos
            // 
            dgvTotalAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalAlumnos.Cursor = Cursors.Hand;
            dgvTotalAlumnos.Location = new Point(435, 91);
            dgvTotalAlumnos.Margin = new Padding(3, 4, 3, 4);
            dgvTotalAlumnos.Name = "dgvTotalAlumnos";
            dgvTotalAlumnos.RowHeadersWidth = 51;
            dgvTotalAlumnos.RowTemplate.Height = 25;
            dgvTotalAlumnos.Size = new Size(832, 440);
            dgvTotalAlumnos.TabIndex = 2;
            dgvTotalAlumnos.VirtualMode = true;
            dgvTotalAlumnos.CellContentClick += dgvTotalAlumnos_CellContentClick;
            dgvTotalAlumnos.CellDoubleClick += dgvTotalAlumnos_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem });
            menuStrip1.Location = new Point(9, 57);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(88, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, profesoresToolStripMenuItem, materiasToolStripMenuItem, usuariosToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(80, 24);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(190, 26);
            menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            menuPrincipalToolStripMenuItem.Click += menuPrincipalToolStripMenuItem_Click;
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(190, 26);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(190, 26);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(190, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1314, 66);
            panel1.TabIndex = 4;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = Properties.Resources.iconUserInterfaceMin_removebg_preview;
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatAppearance.BorderColor = Color.Black;
            btnMin.FlatStyle = FlatStyle.Popup;
            btnMin.ForeColor = Color.Transparent;
            btnMin.Location = new Point(1191, 17);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 6;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.iconUserInterfacemax_removebg_preview;
            btnMax.BackgroundImageLayout = ImageLayout.Stretch;
            btnMax.FlatStyle = FlatStyle.Popup;
            btnMax.ForeColor = Color.Transparent;
            btnMax.Location = new Point(1227, 17);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 5;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(1263, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax21;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // EstudianteCrud
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1304, 544);
            Controls.Add(panel1);
            Controls.Add(dgvTotalAlumnos);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "EstudianteCrud";
            Text = "Estudiantes";
            Load += EstudianteCrud_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalAlumnos).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreoAlumno;
        private TextBox txtTelefonoAlumno;
        private Label label5;
        private Label label4;
        private Button btnEliminar;
        private Button btnModify;
        private Button btnGuardar;
        private TextBox txtLastnameAlumno;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox txtNameAlumno;
        private TextBox txtIDAlumno;
        private Label label2;
        private Label label1;
        private DataGridView dgvTotalAlumnos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Button btnMax;
        private Button btnMin;
    }
}