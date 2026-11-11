using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_csharp
{
    internal class Koneksi
    {
        public string koneksi = "server=localhost;port3306;username=root;password=;database=db_spp_xii";
        public static MySqlConnection GetKoneksi(string koneksi)
        {
            try
            {
                if (string.IsNullOrEmpty( koneksi) ) { return null; }
            }
            catch (Exception)
            {
                MessageBox.Show("maaf login anda bermasalah, silahkan coba lagi nanti");
            }
        }
        
    }
}
