using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using desktop_csharp.views;
using MySql.Data.MySqlClient;

namespace desktop_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
             
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = BtnLogin;
            txtPassword.UseSystemPasswordChar = true;

            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //1. validasi input kosong 
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("username tidak noleh kosong!", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("password tidak boleh kosong", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
                
            }
            MySqlConnection k = Koneksi.GetKoneksi();
            MySqlCommand komando = new MySqlCommand();
            try
            {
                string query = "SELECT * FROM petugas WHERE username = @username AND @password";
                komando.Parameters.AddWithValue("@username");
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterPetugas FormRegister = new FormRegisterPetugas();
            FormRegister.show(this););
        }
    }
}
