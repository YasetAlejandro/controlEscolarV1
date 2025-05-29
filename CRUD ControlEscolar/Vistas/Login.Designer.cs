namespace CRUD_ControlEscolar.Vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnExit = new Button();
            btnMax = new Button();
            btnMin = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnMostrar = new CheckBox();
            btnSign = new Button();
            txtPassword = new TextBox();
            label1 = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Brown;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnMin);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 58);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.iconUserInterfaceclose_removebg_preview;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Transparent;
            btnExit.Location = new Point(758, 19);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 3;
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
            btnMax.Location = new Point(722, 19);
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
            btnMin.FlatAppearance.BorderColor = Color.Black;
            btnMin.FlatStyle = FlatStyle.Popup;
            btnMin.ForeColor = Color.Transparent;
            btnMin.Location = new Point(686, 19);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(30, 30);
            btnMin.TabIndex = 1;
            btnMin.UseVisualStyleBackColor = false;
            btnMin.Click += btnMin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_sombrax2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 55);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(btnMostrar);
            panel2.Controls.Add(btnSign);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(lblUser);
            panel2.Location = new Point(224, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 339);
            panel2.TabIndex = 1;
            // 
            // btnMostrar
            // 
            btnMostrar.AutoSize = true;
            btnMostrar.Location = new Point(261, 247);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(82, 24);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.CheckedChanged += btnMostrar_CheckedChanged;
            // 
            // btnSign
            // 
            btnSign.FlatStyle = FlatStyle.System;
            btnSign.Location = new Point(154, 242);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(94, 29);
            btnSign.TabIndex = 4;
            btnSign.Text = "SIGN";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(135, 158);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "PASSWORD:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(69, 90);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(245, 27);
            txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblUser.Location = new Point(137, 54);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(111, 20);
            lblUser.TabIndex = 0;
            lblUser.Text = "USERNAME:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = Properties.Resources.OIP__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 575);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMin;
        private PictureBox pictureBox1;
        private Button btnMax;
        private Button btnExit;
        private Panel panel2;
        private Label label1;
        private TextBox txtUser;
        private Label lblUser;
        private Button btnSign;
        private TextBox txtPassword;
        private CheckBox btnMostrar;
    }
}