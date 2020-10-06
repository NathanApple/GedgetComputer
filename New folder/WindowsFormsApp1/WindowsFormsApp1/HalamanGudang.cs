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

namespace WindowsFormsApp1
{
    public partial class HalamanGudang : Form
    {
        private string idbarang = "";
        private string jmlhbarang = "";
        private string idkasir = "";

        public HalamanGudang()
        {
            InitializeComponent();
            selecthistori();
            idkasir = FormLogin.idkasir;
        }

        private void selecthistori()
        {
            string query = "";

            if (tb_search.Text != "")
            {
                string search = tb_search.Text;
                query = @"SELECT id,nama,IFNULL(SUM(jumlah),0) as qty FROM
                        (
                        SELECT m_barang.id_barang as id,
                        m_barang.nama_barang as nama,
                        tbl_penambahanbarang.jumlah_barang as jumlah
                        FROM tbl_penambahanbarang
                        LEFT JOIN m_barang ON m_barang.id_barang = tbl_penambahanbarang.id_barang
                        WHERE m_barang.status_barang = 1
                        UNION ALL
                        SELECT m_barang.id_barang AS id,
                        m_barang.nama_barang as nama,
                        concat('-',tbl_detiltransaksi.jumlah_barang) AS jumlah 
                        FROM tbl_detiltransaksi
                        LEFT JOIN m_barang ON m_barang.id_barang = tbl_detiltransaksi.id_barang
                        WHERE m_barang.status_barang = 1
                        ) AS query
                        WHERE nama like '%"+search+"%' OR id like '%"+search+@"%' 
                        GROUP BY id";
            }
            else
            {
                query = @"SELECT id,nama,IFNULL(SUM(jumlah),0) as qty FROM
                        (
                        SELECT m_barang.id_barang as id,
                        m_barang.nama_barang as nama,
                        tbl_penambahanbarang.jumlah_barang as jumlah
                        FROM tbl_penambahanbarang
                        LEFT JOIN m_barang ON m_barang.id_barang = tbl_penambahanbarang.id_barang
                        WHERE m_barang.status_barang = 1
                        UNION ALL
                        SELECT m_barang.id_barang AS id,
                        m_barang.nama_barang as nama,
                        concat('-',tbl_detiltransaksi.jumlah_barang) AS jumlah 
                        FROM tbl_detiltransaksi
                        LEFT JOIN m_barang ON m_barang.id_barang = tbl_detiltransaksi.id_barang
                        WHERE m_barang.status_barang = 1
                        ) AS query
                        GROUP BY id";
                
            }

            MYSQLquery a = new MYSQLquery();

            MySqlDataReader rawrecord = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (rawrecord.Read())
            {
                list.Add(new string[] { rawrecord["id"] + "", rawrecord["nama"] + "", rawrecord["qty"] + "" });
            }

            datagridbarang.DataSource = a.ConvertListToDataTable(list);
            datagridbarang.Refresh();


        }

        private void HalamanGudang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void datagridbarang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idbarang = datagridbarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            jmlhbarang = datagridbarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_nama.Text = datagridbarang.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void datagridbarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string ket = tb_keterangan.Text;
            string qty = tb_qty.Text;
            string query = "INSERT INTO tbl_penambahanbarang(id_barang,id_petugas,jumlah_barang,keterangan_penambahan) VALUES ("+idbarang+","+idkasir+","+qty+",'"+ket+"')";
            MYSQLquery a = new MYSQLquery();
            a.Insert(query);
            MessageBox.Show("Success");
            idbarang = "";
            jmlhbarang = "";
            tb_nama.Text = "";
            tb_qty.Text = "0";
            tb_keterangan.Text = "";
            selecthistori();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ket = tb_keterangan.Text;
            int jumlah = Int32.Parse(jmlhbarang);
            int qty = (Int32.Parse(tb_qty.Text) - jumlah);
            string query = "INSERT INTO tbl_penambahanbarang(id_barang,id_petugas,jumlah_barang,keterangan_penambahan) VALUES (" + idbarang + "," + idkasir + "," + qty + ",'" + ket + "')";
            MYSQLquery a = new MYSQLquery();
            a.Insert(query);
            MessageBox.Show("Success Update");
            idbarang = "";
            jmlhbarang = "";
            tb_nama.Text = "";
            tb_qty.Text = "0";
            tb_keterangan.Text = "";
            selecthistori();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            selecthistori();
        }
    }
}
