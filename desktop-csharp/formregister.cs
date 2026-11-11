using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp
{
    public partial class formregister : Form
    {
        string koneksi = "server=localhost;port3306;username=root;password=;database=db_spp_xii";
        public formregister()
        {
            InitializeComponent();
        }

        private void formregister_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection k = new MySqlConnection(koneksi);
            try
            {
                k.Open();
                string query = "INSERT INTO petugas (username, password, nama_petugas, level) VALUES(@username, @password, @nama_petugas, @level)";
                MySqlCommand komando = new MySqlCommand(query, k);
                komando.Parameters
            }
        }
    }
}
