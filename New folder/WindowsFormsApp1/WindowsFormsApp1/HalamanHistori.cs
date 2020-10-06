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
    public partial class HalamanHistori : Form
    {
        public HalamanHistori()
        {
            InitializeComponent();
            selecthistori();
        }

        private void selecthistori()
        {
            string query = @"SELECT id_transaksi,id_petugas,id_member,harga_transaksi,tanggal_transaksi
                            ,bonus,potongan_harga FROM tbl_transaksi
                            ORDER BY tanggal_transaksi DESC";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_transaksi"] + "", record["id_petugas"] + "", record["id_member"] + "", record["harga_transaksi"] + "", 
                                        record["tanggal_transaksi"] + "", record["bonus"] + "", record["potongan_harga"] + "" });
            }

            DataTable dt = a.ConvertListToDataTable(list);

            dt.Columns[0].ColumnName = "ID Tr";
            dt.Columns[1].ColumnName = "ID Petugas";
            dt.Columns[2].ColumnName = "ID Member";
            dt.Columns[3].ColumnName = "Total Harga";
            dt.Columns[4].ColumnName = "Tanggal";
            dt.Columns[5].ColumnName = "Bonus";
            dt.Columns[6].ColumnName = "Pot. Harga";

            dg_histori.DataSource = dt;
            dg_histori.Refresh();
        }

        private void HalamanHistori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM tbl_transaksi WHERE validasi = 0";
            MYSQLquery a = new MYSQLquery();
            a.Delete(query);
            MessageBox.Show("All transaction cache has been deleted");
        }

        private void dg_histori_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string idtr = dg_histori.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectbonus(idtr);
            selectdetil(idtr);

        }


        private void selectdetil(string idtr)
        {
            string query = @"SELECT id_detil,m_barang.nama_barang as nama,tbl_detiltransaksi.harga_barang as harga,
                            jumlah_barang, (tbl_detiltransaksi.harga_barang * tbl_detiltransaksi.jumlah_barang) as total 
                            FROM tbl_detiltransaksi
                            LEFT JOIN m_barang ON m_barang.id_barang = tbl_detiltransaksi.id_barang
                            WHERE tbl_detiltransaksi.id_transaksi = " + idtr + "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_detil"] + "", record["nama"] + "", record["harga"] + "", record["jumlah_barang"] + "",
                                        record["total"] + "" });
            }

            DataTable dt = a.ConvertListToDataTable(list);

            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Nama Barang";
            dt.Columns[2].ColumnName = "Harga";
            dt.Columns[3].ColumnName = "Jumlah";
            dt.Columns[4].ColumnName = "TOTAL";

            dg_detil.DataSource = dt;
            dg_detil.Refresh();
        }

        private void selectbonus(string idtr)
        {
            string query = @"SELECT id_bonus,m_barang.nama_barang as nama,jumlah 
                            FROM tbl_bonus
                            LEFT JOIN m_barang ON m_barang.id_barang = tbl_bonus.id_barang
                            WHERE tbl_bonus.id_transaksi = " + idtr + "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_bonus"] + "", record["nama"] + "", record["jumlah"] + ""});
            }

            DataTable dt = a.ConvertListToDataTable(list);
            try
            {
                dt.Columns[0].ColumnName = "ID";
                dt.Columns[1].ColumnName = "Nama Barang";
                dt.Columns[2].ColumnName = "Jumlah";
            } catch (Exception e)
            {
                
            }

            dg_bonus.DataSource = dt;
            dg_bonus.Refresh();
        }

    }
}
