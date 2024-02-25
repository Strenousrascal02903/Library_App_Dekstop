namespace LibraryApp
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
            panel1 = new Panel();
            tb_nama = new TextBox();
            tb_pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            btn_close = new Button();
            cb_show = new CheckBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.login;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 640);
            panel1.TabIndex = 0;
            // 
            // tb_nama
            // 
            tb_nama.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_nama.Location = new Point(550, 175);
            tb_nama.Multiline = true;
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(269, 55);
            tb_nama.TabIndex = 1;
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tb_pass.Location = new Point(550, 288);
            tb_pass.Multiline = true;
            tb_pass.Name = "tb_pass";
            tb_pass.PasswordChar = '*';
            tb_pass.Size = new Size(269, 55);
            tb_pass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(550, 156);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 2;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Bisque;
            label2.Location = new Point(550, 269);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Bisque;
            btn_login.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.Sienna;
            btn_login.Location = new Point(550, 392);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(269, 67);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_close
            // 
            btn_close.BackColor = Color.Red;
            btn_close.ForeColor = SystemColors.ButtonFace;
            btn_close.Location = new Point(819, 594);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(89, 34);
            btn_close.TabIndex = 4;
            btn_close.Text = "Close";
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // cb_show
            // 
            cb_show.AutoSize = true;
            cb_show.ForeColor = Color.Bisque;
            cb_show.Location = new Point(555, 350);
            cb_show.Name = "cb_show";
            cb_show.Size = new Size(108, 19);
            cb_show.TabIndex = 5;
            cb_show.Text = "Show Password";
            cb_show.UseVisualStyleBackColor = true;
            cb_show.CheckedChanged += cb_show_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(586, 462);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 6;
            label3.Text = "Don't Have An Account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SeaShell;
            linkLabel1.Location = new Point(729, 462);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 15);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.VisitedLinkColor = Color.Blue;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(920, 640);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(cb_show);
            Controls.Add(btn_close);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_pass);
            Controls.Add(tb_nama);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox tb_nama;
        private TextBox tb_pass;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private Button btn_close;
        private CheckBox cb_show;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}