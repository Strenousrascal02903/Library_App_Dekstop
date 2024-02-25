﻿using System;
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
    public partial class Register : Form
    {
        
        private SqlConnection con = new SqlConnection("Data Source=LAPTOP-BCT87QOU;Initial Catalog=loginapp;Integrated Security=True;TrustServerCertificate=true");
        public Register()
        {
            InitializeComponent();
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO loginapp (ussername, password) VALUES (@ussername, @password)";

                con.Open();

                using (SqlCommand cmd1 = new SqlCommand(insertQuery, con))
                {
                    cmd1.Parameters.AddWithValue("@ussername", tb_nama.Text);
                    cmd1.Parameters.AddWithValue("@password", tb_pass.Text);

                    int rowsAffected = cmd1.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registration Success , Please Login", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Menyembunyikan form Register
                        this.Hide();

                        // Menampilkan Form1
                       Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error registering user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                con.Close();
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin menutup program ini?", "Info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
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
    }
}
