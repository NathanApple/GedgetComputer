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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace WindowsFormsApp1
{
    public partial class HalamanKasir : Form
    {

        public static string transaksi = "";
        private string idmember = "";
        private string idkasir = "";
        private string potharga = "0";
        private string bonus = "Tidak ada bonus";
        public HalamanKasir()
        {
            InitializeComponent();
            idkasir = FormLogin.idkasir;
            tb_kasir.Text = FormLogin.namakasir;
        }

        private void total()
        {
            try
            {

                tb_total.Text = (from DataGridViewRow row in dataGridView1.Rows
                                   where row.Cells[0].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells[5].FormattedValue)).Sum().ToString();
            } catch (Exception e)
            {
                MessageBox.Show(e + "");
            }


        }

        private void HalamanKasir_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            selectquerybarang();

            MYSQLquery a = new MYSQLquery();
            string petugas = idkasir;
            string member = "1";
            string query = "INSERT INTO tbl_transaksi(id_petugas,id_member) VALUES (" + petugas + "," + member+ ");";
            a.Insert(query);

            MySqlDataReader rawrecord = a.Select("SELECT max(id_transaksi) as maxid FROM tbl_transaksi");
            while (rawrecord.Read())
            {
                transaksi = new JavaScriptSerializer().Serialize(rawrecord["maxid"]) ;

            }
            MessageBox.Show("Success, ID Transaksi : "+transaksi);
            btn_insert.Enabled = true;
            btn_cek.Enabled = true;
            selectdetil();
        }

        private void selectquerybarang()
        {
            if (tb_search.Text != "")
            {
                search();
            }
            else
            {
                MYSQLquery a = new MYSQLquery();
                MySqlDataReader rawrecord = a.Select("SELECT id_barang,nama_barang,harga_barang FROM m_barang WHERE status_barang = 1");
                List<string[]> list = new List<string[]>();

                while (rawrecord.Read())
                {
                    list.Add(new string[] { rawrecord["id_barang"] + "", rawrecord["nama_barang"] + "", rawrecord["harga_barang"] + "" });
                }

                datagridbarang.DataSource = a.ConvertListToDataTable(list);
                tb_search.Text = "";
                datagridbarang.Refresh();
                datagridbarang.Refresh();
            }

        }

        private void selectdetil()
        {
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select("SELECT tbl_detiltransaksi.id_detil AS id_detil,tbl_detiltransaksi.id_barang AS id_barang, m_barang.nama_barang as nama_barang, tbl_detiltransaksi.harga_barang as harga_barang, tbl_detiltransaksi.jumlah_barang as jumlah_barang, (tbl_detiltransaksi.harga_barang*tbl_detiltransaksi.jumlah_barang) AS total_harga FROM tbl_detiltransaksi LEFT JOIN m_barang ON tbl_detiltransaksi.id_barang = m_barang.id_barang WHERE id_transaksi = " + transaksi+";");
            List<string[]> list = new List<string[]>();

            while (rawrecord.Read())
            {
                list.Add(new string[] { rawrecord["id_detil"] + "", rawrecord["id_barang"] + "", rawrecord["nama_barang"] + "", rawrecord["harga_barang"] + "", rawrecord["jumlah_barang"] + "", rawrecord["total_harga"] + "" });
            }

            dataGridView1.DataSource = a.ConvertListToDataTable(list);
            tb_search.Text = "";
            dataGridView1.Refresh();
            dataGridView1.Refresh();
            total();
        }

        private void search()
        {
            string search = tb_search.Text;
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select("SELECT * FROM `m_barang` WHERE status_barang = 1 AND (nama_barang LIKE '%" + search + "%' or id_barang LIKE '%" + search + "%')");
            List<string[]> list = new List<string[]>();

            while (rawrecord.Read())
            {
                list.Add(new string[] { rawrecord["id_barang"] + "", rawrecord["nama_barang"] + "", rawrecord["harga_barang"] + "" });
            }

            datagridbarang.DataSource = a.ConvertListToDataTable(list);
            datagridbarang.Refresh();
        }

        private void datagridbarang_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_item.Text = datagridbarang.SelectedCells[1].Value.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.datagridbarang.SelectedRows.Count > 0)
            {
                string id = datagridbarang.SelectedCells[0].Value.ToString();
                string harga = datagridbarang.SelectedCells[2].Value.ToString();
                MYSQLquery a = new MYSQLquery();

                string cekquery = "SELECT jumlah_barang FROM tbl_detiltransaksi WHERE id_barang = "+id+" AND id_transaksi = "+transaksi+";";
                MySqlDataReader rawrecord = a.Select(cekquery);
                if (rawrecord.HasRows)
                {
                    MYSQLquery b = new MYSQLquery();
                    string jumlah = "";
                    while (rawrecord.Read())
                    {
                        jumlah = new JavaScriptSerializer().Serialize(rawrecord["jumlah_barang"]);
                    }
                    string update = "UPDATE tbl_detiltransaksi set jumlah_barang = 1+" + jumlah + " WHERE id_barang = " + id + " AND id_transaksi = " + transaksi + ";";
                    b.Update(update);
                } 
                else
                {
                    MYSQLquery b = new MYSQLquery();
                    string query = "Insert into tbl_detiltransaksi(id_barang,id_transaksi,jumlah_barang,harga_barang) values (" + id + "," + transaksi + ",1," + harga + ");";
                    b.Insert(query);
                }

                selectdetil();

            }
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.OKCancel);

                if (confirmResult == MessageBoxResult.OK)
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    MYSQLquery a = new MYSQLquery();
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    string query = "DELETE FROM tbl_detiltransaksi WHERE id_detil = " + id + ";";
                    a.Delete(query);
                    selectdetil();
                }
                else
                {
                    // If 'No', do something here.
                }

                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to confirm the transaction?", "Confirm!!", MessageBoxButton.OKCancel);

            if (idmember != "" && idkasir != "" && confirmResult == MessageBoxResult.OK)
            {
                string harga = tb_total.Text;
                string query = "UPDATE tbl_transaksi SET id_member = " + idmember + " , harga_transaksi = "+harga+",validasi = 1,potongan_harga = "+potharga+",bonus = '"+bonus+"' WHERE id_transaksi = "+transaksi+";";
                MYSQLquery a = new MYSQLquery();
                a.Update(query);
                MessageBox.Show("Success!");
                idmember = "";
                tb_total.Text = "0";
                transaksi = "";
                tb_mem.Text = "DEFAULT";
                dataGridView1.DataSource = null;
                datagridbarang.DataSource = null;
                btn_print.Enabled = false;
                btn_insert.Enabled = false;
                btn_cek.Enabled = false;
            }
            else
            {
                MessageBox.Show("Error info : "+idmember+"_"+idkasir+"_");
            }
        }

        private void checkmember()
        {
            MYSQLquery a = new MYSQLquery();
            string member = tb_mem.Text;
            MySqlDataReader rawrecord = a.Select("SELECT id_member FROM m_member WHERE nohp_member = '"+member+"' AND status_member = 1 ");
            
            if (rawrecord.HasRows)
            {
                while (rawrecord.Read())
                {
                    idmember = new JavaScriptSerializer().Serialize(rawrecord["id_member"]);
                   
                }
                btn_print.Enabled = true;
                MessageBox.Show("Success, ID Member : " + idmember);
            } else
            {
                MessageBox.Show("Member Invalid");
                idmember = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkmember();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            popupbonus a = new popupbonus();
            DialogResult abc = a.ShowDialog();
            if ( abc == DialogResult.OK)
            {
                /* Banana Code */
                potharga = a.potongan;
                bonus = a.bonus;
                MessageBox.Show("Potongan Harga : "+potharga+" , Bonus : "+bonus);
            } else
            {
                MessageBox.Show("Bonus TIDAK ditambahkan");
            }
        }
    }
}
