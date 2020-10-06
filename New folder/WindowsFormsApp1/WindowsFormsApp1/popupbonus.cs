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

namespace WindowsFormsApp1
{
    public partial class popupbonus : Form
    {
        private string transaksi = "";
        public string potongan { get; set; }
        public string bonus { get; set; }

        public popupbonus()
        {
            InitializeComponent();
            selectquerybarang();

            transaksi = HalamanKasir.transaksi;
        }

        private void selectdetil()
        {
            string query = @"SELECT id_bonus as id,nama_barang as nama,jumlah FROM tbl_bonus
                    LEFT JOIN m_barang ON m_barang.id_barang = tbl_bonus.id_barang
                    WHERE id_transaksi = "+transaksi+"";
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader rawrecord = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (rawrecord.Read())
            {
                list.Add(new string[] { rawrecord["id"] + "", rawrecord["nama"] + "", rawrecord["jumlah"] + "" });
            }

            dataGridView1.DataSource = a.ConvertListToDataTable(list);
            tb_search.Text = "";
            dataGridView1.Refresh();
            
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


        private void button2_Click(object sender, EventArgs e)
        {
            var confirmResult = System.Windows.MessageBox.Show("SEMUA bonus akan dihapus dan TIDAK disimpan, tetap ingin membatalkan bonus??", "Confirm Delete!!", MessageBoxButton.OKCancel);

            if (confirmResult == MessageBoxResult.OK)
            {
                MYSQLquery a = new MYSQLquery();
                string query = "DELETE FROM tbl_bonus where id_transaksi = "+transaksi+"";
                a.Delete(query);
                selectdetil();
                this.DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                // If 'No', do something here.
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.potongan = tb_potongan.Text;
            this.bonus = tb_bonus.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (this.datagridbarang.SelectedRows.Count > 0)
            {
                string id = datagridbarang.SelectedCells[0].Value.ToString();
                MYSQLquery a = new MYSQLquery();

                string cekquery = "SELECT jumlah FROM tbl_bonus WHERE id_barang = " + id + " AND id_transaksi = " + transaksi + ";";
                MySqlDataReader rawrecord = a.Select(cekquery);
                if (rawrecord.HasRows)
                {
                    MYSQLquery b = new MYSQLquery();
                    string jumlah = "";
                    while (rawrecord.Read())
                    {
                        jumlah = new JavaScriptSerializer().Serialize(rawrecord["jumlah"]);
                    }
                    string update = "UPDATE tbl_bonus set jumlah = 1+" + jumlah + " WHERE id_barang = " + id + " AND id_transaksi = " + transaksi + ";";
                    b.Update(update);
                }
                else
                {
                    MYSQLquery b = new MYSQLquery();
                    string query = "Insert into tbl_bonus(id_barang,id_transaksi,jumlah) values (" + id + "," + transaksi + ",1);";
                    b.Insert(query);
                }

                selectdetil();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                var confirmResult = System.Windows.MessageBox.Show("Are you sure to delete this item ??", "Confirm Delete!!", MessageBoxButton.OKCancel);

                if (confirmResult == MessageBoxResult.OK)
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();
                    MYSQLquery a = new MYSQLquery();
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    string query = "DELETE FROM tbl_bonus WHERE id_bonus = " + id + ";";
                    a.Delete(query);
                    selectdetil();
                }
                else
                {
                    // If 'No', do something here.
                }


            }
        }
    }
}
