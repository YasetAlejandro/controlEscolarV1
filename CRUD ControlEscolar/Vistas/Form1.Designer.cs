namespace CRUD_ControlEscolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnEliminar = new Button();
            btnModify = new Button();
            btnGuardar = new Button();
            txtLastname = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvTotalProfesores = new DataGridView();
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalProfesores).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModify);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(11, 113);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(365, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Profesor";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtCorreo
            // 
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(241, 217);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(102, 27);
            txtCorreo.TabIndex = 12;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 217);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(102, 27);
            txtTelefono.TabIndex = 11;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(185, 221);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Correo";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.White;
            label4.Location = new Point(7, 221);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
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
            // txtLastname
            // 
            txtLastname.Location = new Point(80, 167);
            txtLastname.Margin = new Padding(3, 4, 3, 4);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(268, 27);
            txtLastname.TabIndex = 5;
            txtLastname.TextChanged += txtLastname_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(81, 113);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(268, 27);
            txtName.TabIndex = 4;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(80, 60);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(134, 27);
            txtID.TabIndex = 3;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 171);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 113);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 60);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // dgvTotalProfesores
            // 
            dgvTotalProfesores.BackgroundColor = SystemColors.ActiveBorder;
            dgvTotalProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTotalProfesores.Cursor = Cursors.Hand;
            dgvTotalProfesores.GridColor = SystemColors.ControlLight;
            dgvTotalProfesores.Location = new Point(395, 113);
            dgvTotalProfesores.Margin = new Padding(3, 4, 3, 4);
            dgvTotalProfesores.Name = "dgvTotalProfesores";
            dgvTotalProfesores.RowHeadersWidth = 51;
            dgvTotalProfesores.RowTemplate.Height = 25;
            dgvTotalProfesores.Size = new Size(832, 419);
            dgvTotalProfesores.TabIndex = 1;
            dgvTotalProfesores.VirtualMode = true;
            dgvTotalProfesores.CellContentClick += dgvTotalProfesores_CellContentClick_1;
            dgvTotalProfesores.CellDoubleClick += dgvTotalProfesores_CellDoubleClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 67);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(88, 30);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.BackColor = Color.Transparent;
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem, alumnosToolStripMenuItem, materiasToolStripMenuItem, usuariosToolStripMenuItem });
            consultaToolStripMenuItem.ForeColor = Color.White;
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
            alumnosToolStripMenuItem.Text = "Alumnos";
            alumnosToolStripMenuItem.Click += alumnosToolStripMenuItem_Click;
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
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1274, 64);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(1229, 23);
            button3.Name = "button3";
            button3.Size = new Size(30, 29);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.iconUserInterfacemax_removebg_preview;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(1193, 23);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.iconUserInterfaceMin_removebg_preview;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1157, 23);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2021_08_19_at_8_39_42_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1269, 555);
            Controls.Add(panel1);
            Controls.Add(dgvTotalProfesores);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Profesores";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTotalProfesores).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnEliminar;
        private Button btnModify;
        private Button btnGuardar;
        private TextBox txtLastname;
        private TextBox txtName;
        private TextBox txtID;
        private Label label3;
        private Label label2;
        private DataGridView dgvTotalProfesores;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
    }
}