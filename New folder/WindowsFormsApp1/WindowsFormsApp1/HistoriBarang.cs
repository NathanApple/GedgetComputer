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
    public partial class HistoriBarang : Form
    {

        private void selecthistory()
        {
            string query = @"SELECT id,idbrg,nama,jumlah,keterangan,Tanggal FROM
                            (
                            SELECT 
                            concat('BR',tbl_penambahanbarang.id_penambahan) as id,
                            tbl_penambahanbarang.id_barang as idbrg,m_barang.nama_barang as nama,
                            tbl_penambahanbarang.jumlah_barang as jumlah, 
                            tbl_penambahanbarang.keterangan_penambahan as keterangan,
                            tbl_penambahanbarang.tanggal_penambahan as Tanggal 
                            FROM tbl_penambahanbarang
                            LEFT JOIN m_barang ON tbl_penambahanbarang.id_barang = m_barang.id_barang
                            UNION
                            SELECT 
                            concat('TR',tbl_detiltransaksi.id_detil) as id,
                            tbl_detiltransaksi.id_barang as idbrg,
                            m_barang.nama_barang as nama,
                            concat('-',tbl_detiltransaksi.jumlah_barang) as jumlah,
                            'Transaksi' AS keterangan, 
                            tbl_transaksi.tanggal_transaksi AS Tanggal
                            FROM tbl_detiltransaksi
                            LEFT JOIN tbl_transaksi ON tbl_detiltransaksi.id_transaksi = tbl_transaksi.id_transaksi
                            LEFT JOIN m_barang ON tbl_detiltransaksi.id_barang = m_barang.id_barang
                            ) AS query
                            ORDER BY Tanggal DESC";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (rawrecord.Read())
            {
                list.Add(new string[] { rawrecord["id"] + "", rawrecord["idbrg"] + "", rawrecord["nama"] + "", rawrecord["jumlah"] + "", rawrecord["keterangan"] + "", rawrecord["tanggal"] + "" });
            }

            dataGridView2.DataSource = a.ConvertListToDataTable(list);
            dataGridView2.Refresh();

        }

        public HistoriBarang()
        {
            InitializeComponent();
            selecthistory();
            headergrid();
        }

        private void headergrid()
        {
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "ID Barang";
            dataGridView2.Columns[2].HeaderText = "Nama Barang";
            dataGridView2.Columns[3].HeaderText = "Jumlah";
            dataGridView2.Columns[4].HeaderText = "Keterangan";
            dataGridView2.Columns[5].HeaderText = "Tanggal";
        }


        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_transaksi WHERE validasi = 0";
            MYSQLquery a = new MYSQLquery();
            a.Delete(query);
            MessageBox.Show("All Transaction cache has been deleted");
            selecthistory();
        }
    }
}
