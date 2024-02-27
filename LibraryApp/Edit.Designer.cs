namespace LibraryApp
{
    partial class Edit
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
            button3 = new Button();
            btn_logout = new Button();
            btn_edit = new Button();
            btn_dashboard = new Button();
            label1 = new Label();
            panel2 = new Panel();
            btn_clear = new Button();
            btn_delete = new Button();
            btn_update = new Button();
            btn_create = new Button();
            rd_sudah = new RadioButton();
            rd_belum = new RadioButton();
            cbx_hilang = new CheckBox();
            cbx_parah = new CheckBox();
            cbx_ringan = new CheckBox();
            cbx_baik = new CheckBox();
            dtp_kembali = new DateTimePicker();
            dtp_pinjam = new DateTimePicker();
            cb_buku = new ComboBox();
            tb_namaP = new TextBox();
            label5 = new Label();
            label9 = new Label();
            label8 = new Label();
            label4 = new Label();
            tb_nopinjam = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Sienna;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(btn_edit);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 640);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SaddleBrown;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Bisque;
            button3.Location = new Point(0, 567);
            button3.Name = "button3";
            button3.Size = new Size(185, 51);
            button3.TabIndex = 8;
            button3.Text = "Close";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.SaddleBrown;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.ForeColor = Color.Bisque;
            btn_logout.Location = new Point(0, 512);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(185, 49);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "Log out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Bisque;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_edit.ForeColor = Color.SaddleBrown;
            btn_edit.Location = new Point(0, 156);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(185, 53);
            btn_edit.TabIndex = 6;
            btn_edit.Text = "Edit Data";
            btn_edit.UseVisualStyleBackColor = false;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.SaddleBrown;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.ForeColor = Color.Bisque;
            btn_dashboard.Location = new Point(0, 108);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(185, 51);
            btn_dashboard.TabIndex = 5;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 4;
            label1.Text = "Library App";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackgroundImage = Properties.Resources.bg1;
            panel2.Controls.Add(btn_clear);
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(btn_create);
            panel2.Controls.Add(rd_sudah);
            panel2.Controls.Add(rd_belum);
            panel2.Controls.Add(cbx_hilang);
            panel2.Controls.Add(cbx_parah);
            panel2.Controls.Add(cbx_ringan);
            panel2.Controls.Add(cbx_baik);
            panel2.Controls.Add(dtp_kembali);
            panel2.Controls.Add(dtp_pinjam);
            panel2.Controls.Add(cb_buku);
            panel2.Controls.Add(tb_namaP);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tb_nopinjam);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(185, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(815, 640);
            panel2.TabIndex = 1;
            panel2.Scroll += panel2_Scroll;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Sienna;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_clear.ForeColor = Color.Bisque;
            btn_clear.Location = new Point(729, 322);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(74, 32);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Sienna;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.Bisque;
            btn_delete.Location = new Point(649, 322);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(74, 32);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Sienna;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.Bisque;
            btn_update.Location = new Point(569, 322);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(74, 32);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.Sienna;
            btn_create.FlatAppearance.BorderSize = 0;
            btn_create.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_create.ForeColor = Color.Bisque;
            btn_create.Location = new Point(489, 322);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(74, 32);
            btn_create.TabIndex = 9;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // rd_sudah
            // 
            rd_sudah.AutoSize = true;
            rd_sudah.BackColor = Color.Transparent;
            rd_sudah.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rd_sudah.ForeColor = Color.SeaShell;
            rd_sudah.Location = new Point(524, 234);
            rd_sudah.Name = "rd_sudah";
            rd_sudah.Size = new Size(152, 20);
            rd_sudah.TabIndex = 8;
            rd_sudah.TabStop = true;
            rd_sudah.Text = "Sudah Dikembalikan";
            rd_sudah.UseVisualStyleBackColor = false;
            // 
            // rd_belum
            // 
            rd_belum.AutoSize = true;
            rd_belum.BackColor = Color.Transparent;
            rd_belum.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            rd_belum.ForeColor = Color.SeaShell;
            rd_belum.Location = new Point(524, 208);
            rd_belum.Name = "rd_belum";
            rd_belum.Size = new Size(150, 20);
            rd_belum.TabIndex = 8;
            rd_belum.TabStop = true;
            rd_belum.Text = "Belum Dikembalikan";
            rd_belum.UseVisualStyleBackColor = false;
            // 
            // cbx_hilang
            // 
            cbx_hilang.AutoSize = true;
            cbx_hilang.BackColor = Color.Transparent;
            cbx_hilang.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_hilang.ForeColor = Color.SeaShell;
            cbx_hilang.Location = new Point(274, 271);
            cbx_hilang.Name = "cbx_hilang";
            cbx_hilang.Size = new Size(123, 20);
            cbx_hilang.TabIndex = 7;
            cbx_hilang.Text = "Hilang halaman";
            cbx_hilang.UseVisualStyleBackColor = false;
            // 
            // cbx_parah
            // 
            cbx_parah.AutoSize = true;
            cbx_parah.BackColor = Color.Transparent;
            cbx_parah.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_parah.ForeColor = Color.SeaShell;
            cbx_parah.Location = new Point(274, 246);
            cbx_parah.Name = "cbx_parah";
            cbx_parah.Size = new Size(107, 20);
            cbx_parah.TabIndex = 7;
            cbx_parah.Text = "Rusak parah";
            cbx_parah.UseVisualStyleBackColor = false;
            // 
            // cbx_ringan
            // 
            cbx_ringan.AutoSize = true;
            cbx_ringan.BackColor = Color.Transparent;
            cbx_ringan.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_ringan.ForeColor = Color.SeaShell;
            cbx_ringan.Location = new Point(274, 220);
            cbx_ringan.Name = "cbx_ringan";
            cbx_ringan.Size = new Size(110, 20);
            cbx_ringan.TabIndex = 7;
            cbx_ringan.Text = "Rusak ringan";
            cbx_ringan.UseVisualStyleBackColor = false;
            // 
            // cbx_baik
            // 
            cbx_baik.AutoSize = true;
            cbx_baik.BackColor = Color.Transparent;
            cbx_baik.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cbx_baik.ForeColor = Color.SeaShell;
            cbx_baik.Location = new Point(274, 194);
            cbx_baik.Name = "cbx_baik";
            cbx_baik.Size = new Size(52, 20);
            cbx_baik.TabIndex = 7;
            cbx_baik.Text = "Baik";
            cbx_baik.UseVisualStyleBackColor = false;
            // 
            // dtp_kembali
            // 
            dtp_kembali.Location = new Point(508, 136);
            dtp_kembali.Name = "dtp_kembali";
            dtp_kembali.Size = new Size(200, 23);
            dtp_kembali.TabIndex = 6;
            // 
            // dtp_pinjam
            // 
            dtp_pinjam.Location = new Point(277, 136);
            dtp_pinjam.Name = "dtp_pinjam";
            dtp_pinjam.Size = new Size(200, 23);
            dtp_pinjam.TabIndex = 6;
            // 
            // cb_buku
            // 
            cb_buku.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_buku.FormattingEnabled = true;
            cb_buku.Items.AddRange(new object[] { "Fiksi", "Non Fiksi", "Referensi", "Ilmiah", "Agama", "Sains dan Teknologi", "Seni dan Desain", "Hobi dan Keterampilan" });
            cb_buku.Location = new Point(36, 271);
            cb_buku.Name = "cb_buku";
            cb_buku.Size = new Size(207, 23);
            cb_buku.TabIndex = 5;
            // 
            // tb_namaP
            // 
            tb_namaP.Location = new Point(36, 204);
            tb_namaP.Name = "tb_namaP";
            tb_namaP.Size = new Size(207, 23);
            tb_namaP.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaShell;
            label5.Location = new Point(36, 243);
            label5.Name = "label5";
            label5.Size = new Size(74, 16);
            label5.TabIndex = 3;
            label5.Text = "Jenis Buku";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.SeaShell;
            label9.Location = new Point(277, 175);
            label9.Name = "label9";
            label9.Size = new Size(87, 16);
            label9.TabIndex = 3;
            label9.Text = "Kondisi Buku";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SeaShell;
            label8.Location = new Point(531, 176);
            label8.Name = "label8";
            label8.Size = new Size(85, 16);
            label8.TabIndex = 3;
            label8.Text = "Status Buku";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaShell;
            label4.Location = new Point(36, 176);
            label4.Name = "label4";
            label4.Size = new Size(107, 16);
            label4.TabIndex = 3;
            label4.Text = "Nama Peminjam";
            // 
            // tb_nopinjam
            // 
            tb_nopinjam.Location = new Point(36, 136);
            tb_nopinjam.Name = "tb_nopinjam";
            tb_nopinjam.Size = new Size(207, 23);
            tb_nopinjam.TabIndex = 4;
            tb_nopinjam.KeyPress += tb_nopinjam_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SeaShell;
            label7.Location = new Point(531, 108);
            label7.Name = "label7";
            label7.Size = new Size(150, 16);
            label7.TabIndex = 3;
            label7.Text = "Tanggal Pengembalian";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaShell;
            label6.Location = new Point(301, 108);
            label6.Name = "label6";
            label6.Size = new Size(138, 16);
            label6.TabIndex = 3;
            label6.Text = "Tanggal Peminjaman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaShell;
            label3.Location = new Point(36, 108);
            label3.Name = "label3";
            label3.Size = new Size(129, 16);
            label3.TabIndex = 3;
            label3.Text = "Nomor Peminjaman";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(767, 268);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaShell;
            label2.Location = new Point(36, 28);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "Edit data";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 640);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_logout;
        private Button btn_edit;
        private Button btn_dashboard;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker dtp_kembali;
        private DateTimePicker dtp_pinjam;
        private ComboBox cb_buku;
        private TextBox tb_namaP;
        private Label label5;
        private Label label4;
        private TextBox tb_nopinjam;
        private Label label7;
        private Label label6;
        private Label label3;
        private RadioButton rd_sudah;
        private RadioButton rd_belum;
        private CheckBox cbx_hilang;
        private CheckBox cbx_parah;
        private CheckBox cbx_ringan;
        private CheckBox cbx_baik;
        private Label label9;
        private Label label8;
        private Button btn_clear;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_create;
        private Button button3;
    }
}