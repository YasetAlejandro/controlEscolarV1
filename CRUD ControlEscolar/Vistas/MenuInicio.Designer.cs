namespace CRUD_ControlEscolar.Vistas
{
    partial class MenuInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicio));
            menuStrip1 = new MenuStrip();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            profesorToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            materiasToolStripMenuItem = new ToolStripMenuItem();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            button1 = new Button();
            btnMax = new Button();
            btnMin = new Button();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, archivoToolStripMenuItem });
            menuStrip1.Location = new Point(9, 63);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(163, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profesorToolStripMenuItem, alumnoToolStripMenuItem, materiasToolStripMenuItem });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(82, 24);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // profesorToolStripMenuItem
            // 
            profesorToolStripMenuItem.Name = "profesorToolStripMenuItem";
            profesorToolStripMenuItem.Size = new Size(149, 26);
            profesorToolStripMenuItem.Text = "Profesor";
            profesorToolStripMenuItem.Click += profesorToolStripMenuItem_Click;
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(149, 26);
            alumnoToolStripMenuItem.Text = "Alumno";
            alumnoToolStripMenuItem.Click += alumnoToolStripMenuItem_Click_1;
            // 
            // materiasToolStripMenuItem
            // 
            materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            materiasToolStripMenuItem.Size = new Size(149, 26);
            materiasToolStripMenuItem.Text = "Materias";
            materiasToolStripMenuItem.Click += materiasToolStripMenuItem_Click;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem, salirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(224, 26);
            acercaDeToolStripMenuItem.Text = "Control Escolar";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "Acerca De";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem1
            // 
            salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            salirToolStripMenuItem1.Size = new Size(224, 26);
            salirToolStripMenuItem1.Text = "Cerrar Sesion";
            salirToolStripMenuItem1.Click += salirToolStripMenuItem1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 61);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(758, 14);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.iconUserInterfacemax_removebg_preview;
            btnMax.BackgroundImageLayout = ImageLayout.Stretch;
            btnMax.FlatStyle = FlatStyle.Popup;
            btnMax.Location = new Point(722, 14);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 2;
            btnMax.UseVisualStyleBackColor = false;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Right;
            btnMin.BackColor = Color.Transparent;
            btnMin.BackgroundImage = Properties.Resources.iconUserInterfaceMin_removebg_preview;
            btnMin.BackgroundImageLayout = ImageLayout.Stretch;
            btnMin.FlatStyle = FlatStyle.Popup;
            btnMin.ForeColor = Color.Transparent;
            btnMin.Location = new Point(686, 14);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 1;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MenuInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2021_08_19_at_8_39_42_PM;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 451);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MenuInicio";
            Text = "Registrar";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem profesorToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem materiasToolStripMenuItem;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem1;
        private Panel panel1;
        private Button btnMax;
        private Button btnMin;
        private PictureBox pictureBox1;
        private Button button1;
    }
}