namespace CRUD_ControlEscolar.Vistas
{
    partial class CMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMaterias));
            dgvTotalMaterias = new DataGridView();
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            txtIDProfesor = new TextBox();
            label4 = new Label();
            btnEliminar = new Button();
            btnModify = new Button();
            btnGuardar = new Button();
            txtNameMateria = new TextBox();
            txtIDMateria = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            btnExit = new Button();
            btnMax = new Button();
            btnMin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTotalMaterias).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTotalMaterias
            // 
            dgvTotalMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalMaterias.Cursor = Cursors.Hand;
            dgvTotalMaterias.Location = new Point(329, 101);
            dgvTotalMaterias.Margin = new Padding(3, 4, 3, 4);
            dgvTotalMaterias.Name = "dgvTotalMaterias";
            dgvTotalMaterias.RowHeadersWidth = 51;
            dgvTotalMaterias.RowTemplate.Height = 25;
            dgvTotalMaterias.Size = new Size(567, 409);
            dgvTotalMaterias.TabIndex = 4;
            dgvTotalMaterias.VirtualMode = true;
            dgvTotalMaterias.CellContentClick += dgvTotalMaterias_CellContentClick;
            dgvTotalMaterias.CellDoubleClick += dgvTotalMaterias_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem });
            menuStrip1.Location = new Point(9, 67);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(88, 30);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, alumnosToolStripMenuItem, materiasToolStripMenuItem, usuariosToolStripMenuItem });
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
            // alumnosToolStripMenuItem
            // 
            alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            alumnosToolStripMenuItem.Size = new Size(190, 26);
            alumnosToolStripMenuItem.Text = "Profesores";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(190, 26);
            materiasToolStripMenuItem.Text = "Alumnos";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(190, 26);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // txtIDProfesor
            // 
            txtIDProfesor.Location = new Point(27, 208);
            txtIDProfesor.Margin = new Padding(3, 4, 3, 4);
            txtIDProfesor.Name = "txtIDProfesor";
            txtIDProfesor.Size = new Size(140, 27);
            txtIDProfesor.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 184);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 9;
            label4.Text = "ID De Profesor";
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
            // txtNameMateria
            // 
            txtNameMateria.Location = new Point(27, 128);
            txtNameMateria.Margin = new Padding(3, 4, 3, 4);
            txtNameMateria.Name = "txtNameMateria";
            txtNameMateria.Size = new Size(140, 27);
            txtNameMateria.TabIndex = 4;
            txtNameMateria.TextChanged += txtName_TextChanged;
            // 
            // txtIDMateria
            // 
            txtIDMateria.Enabled = false;
            txtIDMateria.Location = new Point(27, 52);
            txtIDMateria.Margin = new Padding(3, 4, 3, 4);
            txtIDMateria.Name = "txtIDMateria";
            txtIDMateria.Size = new Size(140, 27);
            txtIDMateria.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 104);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Materia";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 28);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtIDProfesor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtNameMateria);
            groupBox1.Controls.Add(txtIDMateria);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 101);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(301, 409);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Asignacion De Materia";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 65);
            panel1.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(884, 17);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 4;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.iconUserInterfacemax_removebg_preview;
            btnMax.BackgroundImageLayout = ImageLayout.Stretch;
            btnMax.FlatStyle = FlatStyle.Popup;
            btnMax.ForeColor = Color.Transparent;
            btnMax.Location = new Point(848, 17);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 3;
            btnMax.UseVisualStyleBackColor = false;
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
            btnMin.Location = new Point(812, 17);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 2;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(177, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OIP__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(925, 523);
            Controls.Add(panel1);
            Controls.Add(dgvTotalMaterias);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CMaterias";
            Text = "Materias";
            Load += CMaterias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTotalMaterias).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTotalMaterias;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private TextBox txtCorreo;
        private TextBox txtIDProfesor;
        private Label label5;
        private Label label4;
        private Button btnEliminar;
        private Button btnModify;
        private Button btnGuardar;
        private TextBox txtLastname;
        private TextBox txtNameMateria;
        private TextBox txtIDMateria;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnMin;
        private Button btnMax;
        private Button btnExit;
    }
}