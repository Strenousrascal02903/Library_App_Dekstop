namespace LibraryApp
{
    partial class Register
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
            panel1 = new Panel();
            btn_login = new Button();
            label2 = new Label();
            label1 = new Label();
            tb_pass = new TextBox();
            tb_nama = new TextBox();
            btn_close = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            cb_show = new CheckBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.register;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 640);
            panel1.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Sienna;
            btn_login.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = SystemColors.ButtonFace;
            btn_login.Location = new Point(553, 370);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(269, 67);
            btn_login.TabIndex = 10;
            btn_login.Text = "Register";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(553, 262);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(553, 149);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 9;
            label1.Text = "Nama";
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_pass.Location = new Point(553, 281);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(269, 55);
            tb_pass.TabIndex = 6;
            // 
            // tb_nama
            // 
            tb_nama.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_nama.Location = new Point(553, 168);
            tb_nama.Multiline = true;
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(269, 55);
            tb_nama.TabIndex = 7;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.ForeColor = SystemColors.ButtonFace;
            btn_close.Location = new Point(819, 594);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(89, 34);
            btn_close.TabIndex = 11;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(583, 440);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 12;
            label3.Text = "Already Have Account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = Color.Sienna;
            linkLabel1.LinkColor = Color.Sienna;
            linkLabel1.Location = new Point(722, 440);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(37, 15);
            linkLabel1.TabIndex = 13;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.VisitedLinkColor = Color.Blue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.ForeColor = Color.Sienna;
            cb_show.Location = new Point(553, 345);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(108, 19);
            cb_show.TabIndex = 14;
            cb_show.Text = "Show Password";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(920, 640);
            Controls.Add(cb_show);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(btn_close);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_pass);
            Controls.Add(tb_nama);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_login;
        private Label label2;
        private Label label1;
        private TextBox tb_pass;
        private TextBox tb_nama;
        private Button btn_close;
        private Label label3;
        private LinkLabel linkLabel1;
        private CheckBox cb_show;
    }
}