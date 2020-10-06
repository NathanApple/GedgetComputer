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
    public partial class HalamanBarang : Form
    {
        public HalamanBarang()
        {
            InitializeComponent();
            selectquery();
        }

        private string curcelid = "";

        private void selectquery()
        {
            if(tb_search.Text != "")
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

                dataGridView2.DataSource = a.ConvertListToDataTable(list);
                tb_search.Text = "";
                dataGridView2.Refresh();
                dataGridView2.Refresh();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MYSQLquery a = new MYSQLquery();
            string nama = tb_nama.Text;
            string harga = tb_harga.Text;

            string query = "INSERT INTO m_barang(nama_barang,harga_barang) VALUES ('" + nama + "'," + harga + ");";
            a.Insert(query);
            MessageBox.Show("Success");
            tb_nama.Text = "";
            tb_harga.Text = "";

            selectquery();


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {

                string id = dataGridView2.SelectedCells[0].Value.ToString();
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                MYSQLquery a = new MYSQLquery();
                string query = "UPDATE m_barang set status_barang = 0 WHERE id_barang = "+id+";";

                a.Update(query);

            }
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            curcelid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_nama.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_harga.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (curcelid != "")
            {
                MYSQLquery a = new MYSQLquery();
                string nama = tb_nama.Text;
                string harga = tb_harga.Text;

                string query = "UPDATE m_barang set nama_barang='" + nama + "',harga_barang=" + harga + " WHERE id_barang = " + curcelid + ";";
                a.Update(query);

                tb_nama.Text = "";
                tb_harga.Text = "";
                curcelid = "";
                selectquery();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_nama.Text = "";
            tb_harga.Text = "";
            curcelid = "";
            tb_search.Text = "";
            selectquery();
        }

        private void tb_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            search();
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

            dataGridView2.DataSource = a.ConvertListToDataTable(list);
            dataGridView2.Refresh();
        }


    }

}
