using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryApp
{
    public partial class Edit : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCT87QOU;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=true");

        public Edit()
        {
            InitializeComponent();
            bind_data();
        }
        private void bind_data()
        {
            // Mengambil data dari tabel materi2 dan menampilkannya di DataGridView
            SqlCommand cmd1 = new SqlCommand("SELECT nopinjam, nama AS nama, buku AS buku, tgl_pinjam As tgl_pinjam ,tgl_kembali As tgl_kembali ,status As status ,kondisi FROM library", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                panel2.VerticalScroll.Value = e.NewValue;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                // Memeriksa apakah semua data telah diisi
                if (string.IsNullOrWhiteSpace(tb_nopinjam.Text) ||
                    string.IsNullOrWhiteSpace(tb_namaP.Text) ||
                    string.IsNullOrWhiteSpace(cb_buku.Text) ||
                    !(cbx_baik.Checked || cbx_ringan.Checked || cbx_parah.Checked || cbx_hilang.Checked) ||
                    !(rd_belum.Checked || rd_sudah.Checked))
                {
                    MessageBox.Show("Please insert all data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Menghentikan eksekusi jika data belum lengkap
                }

                // Membuat query untuk memeriksa keberadaan data yang sama
                string checkQuery = "SELECT COUNT(*) FROM library WHERE nopinjam = @nopinjam";
                SqlCommand cmdCheck = new SqlCommand(checkQuery, con);
                cmdCheck.Parameters.AddWithValue("@nopinjam", tb_nopinjam.Text);

                con.Open();
                int count = (int)cmdCheck.ExecuteScalar();
                con.Close();

                // Jika jumlah data yang ditemukan lebih dari 0, berarti data sudah ada
                if (count > 0)
                {
                    MessageBox.Show("Data with that ID already exists.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Semua data telah diisi dan data belum ada, melanjutkan dengan perintah INSERT
                SqlCommand cmd2 = new SqlCommand("INSERT INTO library (nopinjam, nama, buku, tgl_pinjam, tgl_kembali, status, kondisi) VALUES (@nopinjam, @nama, @buku, @tgl_pinjam, @tgl_kembali, @status, @kondisi)", con);
                cmd2.Parameters.AddWithValue("@nopinjam", tb_nopinjam.Text);
                cmd2.Parameters.AddWithValue("@nama", tb_namaP.Text);
                cmd2.Parameters.AddWithValue("@buku", cb_buku.Text);
                cmd2.Parameters.AddWithValue("@tgl_pinjam", dtp_pinjam.Value.Date.ToString("yyyy-MM-dd"));
                cmd2.Parameters.AddWithValue("@tgl_kembali", dtp_kembali.Value.Date.ToString("yyyy-MM-dd"));

                string kondisi = "";

                if (cbx_baik.Checked)
                {
                    kondisi += cbx_baik.Text + ", ";
                }
                if (cbx_ringan.Checked)
                {
                    kondisi += cbx_ringan.Text + ", ";
                }
                if (cbx_parah.Checked)
                {
                    kondisi += cbx_parah.Text + ", ";
                }
                if (cbx_hilang.Checked)
                {
                    kondisi += cbx_hilang.Text + ", ";
                }

                if (!string.IsNullOrEmpty(kondisi))
                {
                    kondisi = kondisi.TrimEnd(',', ' ');
                }

                cmd2.Parameters.AddWithValue("@kondisi", kondisi);
                cmd2.Parameters.AddWithValue("@status", (rd_belum.Checked) ? "Belum Dikembalikan" : "Sudah Dikembalikan");

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                // Memuat ulang data setelah data baru dimasukkan
                bind_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            // Membersihkan semua input fields
            tb_nopinjam.Text = "";
            tb_namaP.Text = "";
            cb_buku.SelectedIndex = -1; // Menghapus pemilihan buku dari combobox


            // Membersihkan semua CheckBoxes
            cbx_baik.Checked = false;
            cbx_ringan.Checked = false;
            cbx_parah.Checked = false;
            cbx_hilang.Checked = false;

            // Mereset nilai DateTimePicker
            dtp_pinjam.Value = DateTime.Now;
            dtp_kembali.Value = DateTime.Now;

            rd_belum.Checked = false;
            rd_sudah.Checked = false;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_nopinjam.Text))
                {
                    MessageBox.Show("Silakan pilih data yang akan diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mengupdate data
                SqlCommand cmd = new SqlCommand("UPDATE library SET nama=@nama, buku=@buku, tgl_pinjam=@tgl_pinjam, tgl_kembali=@tgl_kembali, status=@status, kondisi=@kondisi WHERE nopinjam=@nopinjam", con);
                cmd.Parameters.AddWithValue("@nama", tb_namaP.Text);
                cmd.Parameters.AddWithValue("@buku", cb_buku.Text);
                cmd.Parameters.AddWithValue("@tgl_pinjam", dtp_pinjam.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@tgl_kembali", dtp_kembali.Value.Date.ToString("yyyy-MM-dd"));

                // Membuat variabel untuk status dan menginisialisasi dengan string kosong
                string kondisi = "";

                // Memeriksa setiap CheckBox dan menambahkan nilai ke variabel status jika dicentang
                if (cbx_baik.Checked)
                {
                    kondisi += cbx_baik.Text + ", ";
                }
                if (cbx_ringan.Checked)
                {
                    kondisi += cbx_ringan.Text + ", ";
                }
                if (cbx_parah.Checked)
                {
                    kondisi += cbx_parah.Text + ", ";
                }
                if (cbx_hilang.Checked)
                {
                    kondisi += cbx_hilang.Text + ", ";
                }

                // Menghapus koma ekstra di akhir string
                if (!string.IsNullOrEmpty(kondisi))
                {
                    kondisi = kondisi.TrimEnd(',', ' ');
                }

                cmd.Parameters.AddWithValue("@kondisi", kondisi);

                // Menambahkan nilai kondisi
                cmd.Parameters.AddWithValue("@status", rd_belum.Checked ? "Belum Dikembalikan" : "Sudah Dikembalikan");

                // Parameter untuk WHERE clause
                cmd.Parameters.AddWithValue("@nopinjam", tb_nopinjam.Text);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    // Memberi pesan bahwa data berhasil diperbarui
                    MessageBox.Show("Data success to update.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bind_data();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Data Not Found.", "Updated Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menampilkan data yang dipilih ke TextBox ketika pengguna mengklik sel dalam DataGridView
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedrow = dataGridView1.Rows[e.RowIndex];
                tb_nopinjam.Text = selectedrow.Cells["nopinjam"].Value.ToString();
                tb_namaP.Text = selectedrow.Cells["nama"].Value.ToString();
                cb_buku.SelectedItem = selectedrow.Cells["buku"].Value.ToString();

                // Mengatur tanggal pinjam dan tanggal kembali dari DataGridView
                dtp_pinjam.Value = Convert.ToDateTime(selectedrow.Cells["tgl_pinjam"].Value);
                dtp_kembali.Value = Convert.ToDateTime(selectedrow.Cells["tgl_kembali"].Value);

                // Menetapkan status kondisi dari DataGridView ke RadioButton yang sesuai
                string status = selectedrow.Cells["status"].Value.ToString();
                if (status == "Belum Dikembalikan")
                {
                    rd_belum.Checked = true;
                }
                else if (status == "Sudah Dikembalikan")
                {
                    rd_sudah.Checked = true;
                }

                // Membersihkan semua CheckBoxes
                cbx_baik.Checked = false;
                cbx_ringan.Checked = false;
                cbx_parah.Checked = false;
                cbx_hilang.Checked = false;

                // Mendapatkan nilai status dari DataGridView
                string[] statusArray = selectedrow.Cells["kondisi"].Value.ToString().Split(',');

                // Mengatur CheckBoxes sesuai dengan nilai status dari DataGridView
                foreach (string kondisi in statusArray)
                {
                    if (kondisi.Trim() == cbx_baik.Text)
                    {
                        cbx_baik.Checked = true;
                    }
                    else if (kondisi.Trim() == cbx_ringan.Text)
                    {
                        cbx_ringan.Checked = true;
                    }
                    else if (kondisi.Trim() == cbx_parah.Text)
                    {
                        cbx_parah.Checked = true;
                    }
                    else if (kondisi.Trim() == cbx_hilang.Text)
                    {
                        cbx_hilang.Checked = true;
                    }
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Menampilkan pesan konfirmasi sebelum menghapus data
            DialogResult result = MessageBox.Show("Do you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Menghapus data terpilih dari tabel library
                if (!string.IsNullOrEmpty(tb_nopinjam.Text))
                {
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM library WHERE nopinjam=@nopinjam", con);
                    cmdDelete.Parameters.AddWithValue("@nopinjam", tb_nopinjam.Text);

                    con.Open();
                    cmdDelete.ExecuteNonQuery();
                    con.Close();

                    // Memuat ulang data setelah data dihapus
                    bind_data();

                    // Membersihkan input fields setelah penghapusan
                    tb_nopinjam.Text = "";
                    tb_namaP.Text = "";
                    cb_buku.SelectedIndex = -1;
                    cbx_baik.Checked = false;
                    cbx_ringan.Checked = false;
                    cbx_parah.Checked = false;
                    cbx_hilang.Checked = false;
                    dtp_pinjam.Value = DateTime.Now;
                    dtp_kembali.Value = DateTime.Now;
                    rd_belum.Checked = false;
                    rd_sudah.Checked = false;
                }
                else
                {
                    MessageBox.Show("Choose data that do you want to delete.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }


        private void tb_nopinjam_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mengecek apakah karakter yang dimasukkan bukan angka atau backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Jika bukan angka, membatalkan input
                e.Handled = true;
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do You Want To Log Out?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Close This Program", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }
    }
}
