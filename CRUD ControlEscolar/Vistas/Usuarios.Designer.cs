namespace CRUD_ControlEscolar.Vistas
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            dgvUsuarios = new DataGridView();
            menuStrip1 = new MenuStrip();
            menuPrincipalToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipalToolStripMenuItem1 = new ToolStripMenuItem();
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            alumnosToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(14, 88);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(632, 471);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dataGridUsuarios_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem });
            menuStrip1.Location = new Point(9, 54);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(89, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuPrincipalToolStripMenuItem1, profesoresToolStripMenuItem, alumnosToolStripMenuItem, materiasToolStripMenuItem });
            menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            menuPrincipalToolStripMenuItem.Size = new Size(80, 24);
            menuPrincipalToolStripMenuItem.Text = "Consulta";
            // 
            // menuPrincipalToolStripMenuItem1
            // 
            menuPrincipalToolStripMenuItem1.Name = "menuPrincipalToolStripMenuItem1";
            menuPrincipalToolStripMenuItem1.Size = new Size(190, 26);
            menuPrincipalToolStripMenuItem1.Text = "Menu Principal";
            menuPrincipalToolStripMenuItem1.Click += menuPrincipalToolStripMenuItem1_Click;
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(190, 26);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 56);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.iconUserInterfaceMin_removebg_preview;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(557, 17);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
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
            button2.Location = new Point(593, 17);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(629, 17);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax21;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 44);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(671, 588);
            Controls.Add(panel1);
            Controls.Add(dgvUsuarios);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Usuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private ToolStripMenuItem alumnosToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}