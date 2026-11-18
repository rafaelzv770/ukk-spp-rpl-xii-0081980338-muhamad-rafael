using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PRAKTIKUM_DESKTOP_XII_0081980338_Muhamad_Rafael
{
    public partial class Register : Form
    {
        string Koneksi = "server=localhost;username=root;password=;database=db_apotek_petugas";
        private string query;

        public Register()
        {
            InitializeComponent();

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(this.Koneksi);
            string query = "SELECT @role FORM tb_petugas";
            MySqlCommand cmd = new MySqlCommand(query, con);


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection konfigurasi = new MySqlConnection(this.Koneksi);
            MySqlCommand cmd = new MySqlCommand();

            cmd.ExecuteNonQuery();
            MessageBox.Show("data berhasil disimpan", "sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {
                konfigurasi.Open();

                string str = "INSERT INTO `tb_apoteker` (`id_petugas`, `username`, `password`, `nama_petugas`, `shift`, `role`, `status_aktif`) VALUES (@id_petugas, @nama_petugas, @username, @password, @shift, @role";
                MySqlCommand komando = new MySqlCommand(query, konfigurasi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("@username", txtUser.Text.Length < 6));
                cmd.Parameters.Add(new MySqlParameter("@password", txtPass.Text.Length < 6));
                cmd.Parameters.Add(new MySqlParameter("@role", cmboboxRole.SelectedItem.ToString()));
                if (txtPass.Text != txtConPass.Text)
                {
                    MessageBox.Show("password dan konfirmasi salah");
                }
                else
                {
                    MessageBox.Show("password dan konfirmasi benar");
                    txtUser.Clear();
                    txtPass.Clear();
                    txtConPass.Clear();

                }
            }
            catch (Exception)
            {
                konfigurasi.Close();

            }
            MessageBox.Show("gagal menyimpan data. pesan kesalahan:" + "kesalahan");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            login login = new login();
            login.Show();
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
