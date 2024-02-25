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
    public partial class Dashboard : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCT87QOU;Initial Catalog=library;Integrated Security=True;TrustServerCertificate=true");

        public Dashboard()
        {
            InitializeComponent();
            bind_data();
            SetAutoSizeModeForColumns();


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Show();
            Edit edit = new Edit();
            edit.Show();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Membuat perintah SQL untuk melakukan pencarian berdasarkan nama depan
                SqlCommand cmdSearch = new SqlCommand("SELECT nopinjam, nama, buku, tgl_pinjam, tgl_kembali, status, kondisi FROM library WHERE nama LIKE @nama + '%'", con);
                cmdSearch.Parameters.AddWithValue("@nama", tb_search.Text);

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmdSearch;

                DataTable dt = new DataTable();
                dt.Clear();
                da.Fill(dt);

                // Menampilkan hasil pencarian dalam DataGridView
                dataGridView1.DataSource = dt;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Membuat bitmap untuk menampung gambar DataGridView
            Bitmap imgBitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);

            // Menggambar DataGridView ke dalam bitmap
            dataGridView1.DrawToBitmap(imgBitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));

            // Menggambar bitmap ke dalam area cetak pada PrintPage
            e.Graphics.DrawImage(imgBitmap, 15 , 15);
        }

        private void SetAutoSizeModeForColumns()
        {

            // Mengatur AutoSizeMode untuk kolom
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            // Mengatur AutoSizeRowsMode untuk baris
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
