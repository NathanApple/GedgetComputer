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
    public partial class AdminHalamanBarang : Form
    {

        private string curcelid = "";
        public AdminHalamanBarang()
        {
            InitializeComponent();
            selectquery();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Nama Barang";
            dataGridView2.Columns[2].HeaderText = "Harga Barang";
            dataGridView2.Columns[3].HeaderText = "Status Barang";
        }

        private void selectquery()
        {
            if(tb_search.Text != "")
            {
                search();
                return;
            }
            MYSQLquery a = new MYSQLquery();
            string query = "";
            if (cb_showall.Checked)
            {
                query = "SELECT id_barang,nama_barang,harga_barang,IF(status_barang,'TRUE','X') AS statusbarang FROM m_barang";
            } 
            else
            {
                query = "SELECT id_barang,nama_barang,harga_barang,IF(status_barang,'TRUE','X') AS statusbarang FROM m_barang WHERE status_barang='1'";
            }

            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_barang"] + "", record["nama_barang"] + "", record["harga_barang"] + "", record["statusbarang"] + "" });
            }

            dataGridView2.DataSource = a.ConvertListToDataTable(list);
            dataGridView2.Refresh();
        }



        private void btn_insert_Click(object sender, EventArgs e)
        {
            MYSQLquery a = new MYSQLquery();
            string nama = tb_nama.Text;
            string harga = tb_harga.Text;
            int status = Convert.ToInt32(cb_status.Checked);

            string query = "INSERT INTO m_barang(nama_barang,harga_barang,status_barang) VALUES ('" + nama + "'," + harga + ","+status+");";
            a.Insert(query);
            MessageBox.Show("Success");
            tb_nama.Text = "";
            tb_harga.Text = "";

            selectquery();
            reset();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (curcelid != "")
            {
                MYSQLquery a = new MYSQLquery();
                string nama = tb_nama.Text;
                string harga = tb_harga.Text;
                int status = Convert.ToInt32(cb_status.Checked);

                string query = "UPDATE m_barang set nama_barang='" + nama + "',harga_barang=" + harga + ",status_barang="+status+" WHERE id_barang = " + curcelid + ";";

                a.Update(query);

                selectquery();
            } 

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            tb_nama.Text = "";
            tb_harga.Text = "";
            curcelid = "";
            cb_status.Checked = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0)
            {

                string id = dataGridView2.SelectedCells[0].Value.ToString();
                MYSQLquery a = new MYSQLquery();
                string query = "UPDATE m_barang set status_barang = 0 WHERE id_barang = " + id + ";";
                a.Update(query);
                selectquery();
                reset();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            curcelid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_nama.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_harga.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();

            string status = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (status == "TRUE")
            {
                cb_status.Checked = true;
            }
            else
            {
                cb_status.Checked = false;
            }
        }

        private void cb_showall_CheckedChanged(object sender, EventArgs e)
        {
            selectquery();
        }

        private void cb_showall_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string search = tb_search.Text;
            MYSQLquery a = new MYSQLquery();
            string query = "";
            if (cb_showall.Checked)
            {
                query = "SELECT * FROM `m_barang` WHERE nama_barang LIKE '%" + search + "%' or id_barang LIKE '%" + search + "%'";
            }
            else
            {
                query = "SELECT * FROM `m_barang` WHERE status_barang = 1 AND (nama_barang LIKE '%" + search + "%' or id_barang LIKE '%" + search + "%')";
            }


            MySqlDataReader rawrecord = a.Select(query);
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
