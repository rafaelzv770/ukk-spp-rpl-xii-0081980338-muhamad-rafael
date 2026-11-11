using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Mysqlx.Notice.Warning.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace desktop_csharp.model
{
    internal class SessionUser
    {
        
        public SessionUser(int id, string username, string password ,string nama, string level)
        {
            Id_petugas = id;
            Username = username;
            Password = password;
            Nama_petugas = nama;
            Level = level.ToLower();
            IsLoggedin = true;
        }

        

        public static void SetSession(int id, string username, string nama, string level)
        {
            
        }
        public static void ClearSession()
        {
            Id_petugas = 0;
            Username = null;
            Password = null;
            Nama_petugas = null;
            Level = null;
            Isloggedin = IsLoggedin;
        }

        public static int Id_petugas { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Nama_petugas { get; set; }
        public static string Level { get; set; }
        public static bool Isloggedin { get; private set; }
        public static bool IsLoggedin { get; set; }

        public static bool IsAdmin()
        {
            return Level == "admin";
        }
    }
}
