using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRAKTIKUM_DESKTOP_XII_0081980338_Muhamad_Rafael
{
    public partial class login : Form
    {
        string Koneksi = "server=localhost;username=root;password=;database=db_apotek_petugas";
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection konfigurasi = new MySqlConnection(Koneksi);
            try
            {
                string username = txtUser.Text;
                string password = txtPass.Text;
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password));
                {
                    MessageBox.Show("username dan password tdk blh kocong");
                    txtUser.Focus();
                    return;
                }
                konfigurasi.Open();
                string query = "SELECT @username,@password,@status_aktif FORM tb_apoteker WHERE username = @username limit1";
                MySqlCommand cmd = new MySqlCommand(query, konfigurasi);
                cmd.Parameters.AddWithValue("@username", username);
                MySqlDataReader hasil = cmd.ExecuteReader();
                if (hasil.Read())
                {
                    if (password == hasil["password"].ToString())
                    {
                        Dashboard DASHBOARD = new Dashboard();
                        DASHBOARD.FormClosed += DASHBOARD_FormClosed;
                        DASHBOARD.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("password salah!");
                    }
                }
                else
                {
                    MessageBox.Show("username tdk di tmukn");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("terjadi kesalahan!:" + ex.Message);
            }
        }

        private void DASHBOARD_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
