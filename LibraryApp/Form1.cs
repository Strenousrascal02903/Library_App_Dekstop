using Microsoft.Data.SqlClient;
namespace LibraryApp


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCT87QOU;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=true");
                con.Open();

                // Memeriksa kombinasi ussername dan password
                string query = "SELECT COUNT(*) FROM loginapp WHERE ussername=@ussername AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ussername", tb_nama.Text);
                cmd.Parameters.AddWithValue("@password", tb_pass.Text);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login Success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dashboard dash = new Dashboard();
                    dash.Show();
                }
                else
                {
                    // Memeriksa apakah hanya ussername yang salah tetapi password benar
                    string passwordQuery = "SELECT COUNT(*) FROM loginapp WHERE password=@password";
                    SqlCommand passwordCmd = new SqlCommand(passwordQuery, con);
                    passwordCmd.Parameters.AddWithValue("@password", tb_pass.Text);
                    int passwordCount = (int)passwordCmd.ExecuteScalar();

                    if (passwordCount > 0)
                    {
                        MessageBox.Show("Invalid ussername", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Error Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_show.Checked == true)
            {

                tb_pass.PasswordChar = '\0';
            }
            else
            {

                tb_pass.PasswordChar = '*';
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Close This Program", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Register regis = new Register();
            regis.Show();
        }
    }
}