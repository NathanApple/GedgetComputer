using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public static string namakasir = "";
        public static string idkasir = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = tb_nama.Text;
            string pw = tb_pw.Text;
            MYSQLquery a = new MYSQLquery();
            string cekquery = "SELECT id_petugas FROM m_petugas WHERE nama_petugas = '" + nama + "' AND password_petugas = '" + pw + "';";
            MySqlDataReader rawrecord = a.Select(cekquery);
            if (rawrecord.HasRows)
            {
                namakasir = nama;
                while (rawrecord.Read())
                {
                    idkasir = new JavaScriptSerializer().Serialize(rawrecord["id_petugas"]);
                }
                this.Hide();
                new HalamanUtamaKasir().ShowDialog();
                this.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Username atau Password Salah");
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
