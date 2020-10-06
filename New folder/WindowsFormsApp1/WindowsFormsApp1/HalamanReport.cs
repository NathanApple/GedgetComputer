using ClosedXML.Excel;
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
    public partial class HalamanReport : Form
    {
        

        public HalamanReport()
        {
            InitializeComponent();
            refresh();
            keuntungan();
            petugasmember();
            datagridtitle();
        }

        private void exporttoexcel()
        {
            XLWorkbook wb = new XLWorkbook();

            DataTable dt = (DataTable)gridbarang.DataSource;
            wb.Worksheets.Add(dt, "Report Barang");

            DataTable dt1 = (DataTable)gridpetugas.DataSource;
            wb.Worksheets.Add(dt1, "Report Petugas");

            wb.SaveAs("../ReportFile.xlsx");
        }

        private void datagridtitle()
        {
            //gridbarang.Columns[0].HeaderText = "ID";
            //gridbarang.Columns[1].HeaderText = "Nama Barang";
            //gridbarang.Columns[2].HeaderText = "Barang Masuk";
            //gridbarang.Columns[3].HeaderText = "Terjual";
            //gridbarang.Columns[4].HeaderText = "Kelarisan";
            //gridbarang.Columns[5].HeaderText = "Digratiskan";
            //gridbarang.Columns[6].HeaderText = "Total Untung";

            //gridpetugas.Columns[0].HeaderText = "ID";
            //gridpetugas.Columns[1].HeaderText = "Nama Petugas";
            //gridpetugas.Columns[2].HeaderText = "Hasil Penjualan";
            //gridpetugas.Columns[3].HeaderText = "Level Petugas";

        }


        private void refresh()
        {
            barangterjual();
            barangmasuk();
            keuntungan();
            terlaku();
            teraktif();
            reportbarang();
            reportpetugas();

        }

        private void reportpetugas()
        {
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT id_petugas,nama_petugas,CAST(IFNULL(aktif,'0') AS CHAR CHARACTER SET utf8mb4) as akt,tingkat_petugas FROM
	                (
		                SELECT m_petugas.id_petugas as id,IFNULL(COUNT(*),'0') as aktif
		                FROM m_petugas
		                LEFT JOIN tbl_transaksi ON m_petugas.id_petugas = tbl_transaksi.id_petugas
		                WHERE (tanggal_transaksi BETWEEN '" + tanggal1+"' AND '"+tanggal2+@"') AND 
			                tbl_transaksi.validasi = 1
			                GROUP BY id
	                ) as query
	                RIGHT JOIN m_petugas ON query.id = m_petugas.id_petugas ";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_petugas"] + "", record["nama_petugas"] + "", record["akt"] + "", record["tingkat_petugas"] + "" });
            }

            DataTable dt = a.ConvertListToDataTable(list);

            dt.Columns[0].ColumnName = "ID Petugas";
            dt.Columns[1].ColumnName = "Nama Petugas";
            dt.Columns[2].ColumnName = "Total Penjualan";
            dt.Columns[3].ColumnName = "Level Petugas";

            gridpetugas.DataSource = dt;
            gridpetugas.Refresh();
        }

        private void reportbarang()
        {
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT SUM(A) as Tr,SUM(B) as Br,SUM(C) as laris,SUM(D) as gratis,SUM(untung) as Ut,id_barang as id,nama_barang as nm  FROM
		        ( 	SELECT SUM(tbl_detiltransaksi.jumlah_barang) as A,'0' as B,
                        COUNT(tbl_detiltransaksi.jumlah_barang) as C,'0' as D, 
				        tbl_detiltransaksi.id_barang as id,SUM(tbl_detiltransaksi.harga_barang) as untung
				        FROM tbl_detiltransaksi
				        LEFT JOIN tbl_transaksi ON tbl_detiltransaksi.id_transaksi = tbl_transaksi.id_transaksi
				        WHERE (tanggal_transaksi BETWEEN '" + tanggal1+"' AND '"+tanggal2+ @"') AND
				        tbl_transaksi.validasi = 1
				        GROUP BY id_barang
			        UNION ALL
			        SELECT '0',SUM(tbl_penambahanbarang.jumlah_barang) as b,'0','0',
			        tbl_penambahanbarang.id_barang as id, '0'
				        FROM tbl_penambahanbarang
				        WHERE (tanggal_penambahan BETWEEN '" + tanggal1+"' AND '"+tanggal2+ @"')
				        GROUP BY id_barang
                    UNION ALL
			        SELECT '0','0',jumlah as C,jumlah,id_barang as id,'0'
				        FROM tbl_bonus
				        LEFT JOIN tbl_transaksi ON tbl_bonus.id_transaksi = tbl_transaksi.id_transaksi
				        WHERE (tanggal_transaksi BETWEEN '" + tanggal1 + "' AND '" + tanggal2 + @"') AND
				        tbl_transaksi.validasi = 1
				        GROUP BY id_barang
	        ) as query
	        RIGHT JOIN m_barang ON query.id = m_barang.id_barang
	        WHERE m_barang.status_barang = 1
	        GROUP BY id_barang";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id"] + "", record["nm"] + "", record["Br"] + "", record["Tr"] + "", record["laris"] + "", record["gratis"] + "", record["Ut"] + "" });
            }

            DataTable dt = a.ConvertListToDataTable(list);

            dt.Columns[0].ColumnName = "ID Barang";
            dt.Columns[1].ColumnName = "Nama Barang";
            dt.Columns[2].ColumnName = "Barang Masuk";
            dt.Columns[3].ColumnName = "Terjual";
            dt.Columns[4].ColumnName = "Kelarisan";
            dt.Columns[5].ColumnName = "Digratiskan";
            dt.Columns[6].ColumnName = "Total Untung";

            gridbarang.DataSource = dt ;
            gridbarang.Refresh();

        }

        private void teraktif()
        {
            string teraktif = "";
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT COUNT(*) as banyak,m_petugas.nama_petugas as nama
                    FROM tbl_transaksi
                    LEFT JOIN m_petugas ON tbl_transaksi.id_petugas = m_petugas.id_petugas
                    WHERE(tanggal_transaksi BETWEEN '"+tanggal1+"' AND '"+tanggal2+@"') AND
                        tbl_transaksi.validasi = 1
                    GROUP BY tbl_transaksi.id_petugas
                    ORDER BY banyak DESC LIMIT 1";
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                teraktif = new JavaScriptSerializer().Serialize(rawrecord["nama"]);
            }

            tb_teraktif.Text = teraktif;
        }


        private void terlaku()
        {
            string terlaku = "";
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT m_barang.nama_barang as nama
                FROM tbl_detiltransaksi
                LEFT JOIN m_barang ON tbl_detiltransaksi.id_barang = m_barang.id_barang
                LEFT JOIN tbl_transaksi ON tbl_detiltransaksi.id_transaksi = tbl_transaksi.id_transaksi
                WHERE jumlah_barang = (
                    SELECT max(jumlah_barang) FROM tbl_detiltransaksi
                    ) AND(tanggal_transaksi BETWEEN '"+tanggal1+"' AND '"+tanggal2+ @"')
                    AND tbl_transaksi.validasi = 1
                GROUP BY m_barang.id_barang";
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                terlaku = new JavaScriptSerializer().Serialize(rawrecord["nama"]);
            }

            tb_terlaku.Text = terlaku;

        }

        private void petugasmember()
        {
            string query = "SELECT count(id_petugas) as petugas from m_petugas";
            string petugas = "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                petugas = new JavaScriptSerializer().Serialize(rawrecord["petugas"]);
            }
            tb_petugas.Text = petugas;

            query = "SELECT count(id_member) as member from m_member";
            string member = "";

            MYSQLquery b = new MYSQLquery();
            MySqlDataReader rawrecord2 = b.Select(query);
            while (rawrecord2.Read())
            {
                member = new JavaScriptSerializer().Serialize(rawrecord2["member"]);
            }
            tb_member.Text = member;


        }



        private void keuntungan()
        {
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT sum(harga_barang) as jumlah FROM tbl_detiltransaksi 
                LEFT JOIN tbl_transaksi ON tbl_transaksi.id_transaksi = tbl_detiltransaksi.id_transaksi
                WHERE(tanggal_transaksi BETWEEN '" + tanggal1 + "' AND '" + tanggal2 + "')";
            string jumlah = "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                jumlah = new JavaScriptSerializer().Serialize(rawrecord["jumlah"]);
            }

            tb_untung.Text = jumlah;
        }

        private void barangterjual()
        {
            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT sum(jumlah_barang) as jumlah FROM tbl_detiltransaksi 
                LEFT JOIN tbl_transaksi ON tbl_transaksi.id_transaksi = tbl_detiltransaksi.id_transaksi
                WHERE(tanggal_transaksi BETWEEN '"+tanggal1+"' AND '"+tanggal2+"')";
            string jumlah = "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                jumlah = new JavaScriptSerializer().Serialize(rawrecord["jumlah"]);
            }

            tb_terjual.Text = jumlah;
        }

        private void barangmasuk()
        {
            

            string tanggal1 = date1.Value.ToString("yyyy-MM-dd");
            string tanggal2 = date2.Value.ToString("yyyy-MM-dd");
            string query = @"SELECT sum(jumlah_barang) as jumlah FROM tbl_penambahanbarang 
                WHERE(tanggal_penambahan BETWEEN '" + tanggal1 + "' AND '" + tanggal2 + "')";
            string masuk = "";

            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            while (rawrecord.Read())
            {
                masuk = new JavaScriptSerializer().Serialize(rawrecord["jumlah"]);
            }

            tb_masuk.Text = masuk;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            exporttoexcel();
            MessageBox.Show("Success");
        }
    }
}
