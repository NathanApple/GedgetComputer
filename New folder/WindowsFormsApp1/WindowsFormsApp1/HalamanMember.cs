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
    public partial class HalamanMember : Form
    {
        string curcelid = "";

        public HalamanMember()
        {
            InitializeComponent();
            selectquery();
            dataGridView2.Columns[0].HeaderText = "ID";
            dataGridView2.Columns[1].HeaderText = "Nama Member";
            dataGridView2.Columns[2].HeaderText = "Nomor HP";
            dataGridView2.Columns[3].HeaderText = "Email Member";
            dataGridView2.Columns[4].HeaderText = "Rank Member";
            dataGridView2.Columns[5].HeaderText = "Status Member";
        }

        private void selectquery()
        {
            if (tb_search.Text != "")
            {
                search();
                return;
            }
            MYSQLquery a = new MYSQLquery();
            string query = "";
            if (cb_showall.Checked)
            {
                query = "SELECT id_member,nama_member,nohp_member,email_member, IF(rank_member=0,'DEFAULT',IF(rank_member = 1,'Bronze',IF(rank_member = 2, 'Silver',IF(rank_member = 3,'Gold','Platinum')))) AS rank_member, IF(status_member,'Aktif','Tidak Aktif') AS status_member FROM m_member";
            }
            else
            {
                query = "SELECT id_member,nama_member,nohp_member,email_member, IF(rank_member=0,'DEFAULT',IF(rank_member = 1,'Bronze',IF(rank_member = 2, 'Silver',IF(rank_member = 3,'Gold','Platinum')))) AS rank_member, IF(status_member,'Aktif','Tidak Aktif') AS status_member FROM m_member WHERE status_member=1";
            }


            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_member"] + "", record["nama_member"] + "", record["nohp_member"] + "", record["email_member"] + "", record["rank_member"] + "", record["status_member"] + "" });
            }

            dataGridView2.DataSource = a.ConvertListToDataTable(list);
            dataGridView2.Refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            MYSQLquery a = new MYSQLquery();
            string nama = tb_nama.Text;
            string nohp = tb_nohp.Text;
            string email = tb_email.Text;

            string query = "INSERT INTO m_member(nama_member,nohp_member,email_member) VALUES ('" + nama + "','" + nohp + "','" + email+ "');";
            a.Insert(query);
            MessageBox.Show("Success");

            selectquery();
            reset();
        }

        private void reset()
        {
            tb_nama.Text = "";
            tb_nohp.Text = "";
            tb_email.Text = "";
            curcelid = "";
            tb_search.Text = "";
            
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            curcelid = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_nama.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_nohp.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_email.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (curcelid != "")
            {
                MYSQLquery a = new MYSQLquery();
                string nama = tb_nama.Text;
                string nohp = tb_nohp.Text;
                string email = tb_email.Text;

                string query = "UPDATE m_member set nama_member='" + nama + "',nohp_member='" + nohp + "',email_member='" + email + "' WHERE id_member = " + curcelid + ";";

                a.Update(query);

                selectquery();
                reset();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView2.SelectedRows.Count > 0 && curcelid != "")
            {

                string id = dataGridView2.SelectedCells[0].Value.ToString();
                dataGridView2.Rows[this.dataGridView2.SelectedRows[0].Index].Cells[5].Value = "Tidak Aktif";
                MYSQLquery a = new MYSQLquery();
                string query = "UPDATE m_member set status_member = 0 WHERE id_member= " + id + ";";

                a.Update(query);
                reset();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cb_showall_CheckedChanged(object sender, EventArgs e)
        {
            selectquery();
        }

        private void search()
        {
            string search = tb_search.Text;
            MYSQLquery a = new MYSQLquery();
            string query = "";
            if (cb_showall.Checked)
            {
                query = "SELECT id_member,nama_member,nohp_member,email_member, IF(rank_member = 0,'DEFAULT',IF(rank_member = 1,'Bronze',IF(rank_member = 2, 'Silver',IF(rank_member = 3,'Gold','Platinum')))) AS rank_member, IF(status_member,'Aktif','Tidak Aktif') AS status_member FROM m_member WHERE nama_member LIKE '%" + search + "%' or id_member LIKE '%" + search + "%' or email_member LIKE '%" + search + "%' or nohp_member LIKE '%" + search + "%'";
            }
            else
            {
                query = "SELECT id_member,nama_member,nohp_member,email_member, IF(rank_member = 0,'DEFAULT',IF(rank_member = 1,'Bronze',IF(rank_member = 2, 'Silver',IF(rank_member = 3,'Gold','Platinum')))) AS rank_member, IF(status_member,'Aktif','Tidak Aktif') AS status_member FROM m_member WHERE status_member = 1 AND (nama_member LIKE '%" + search + "%' or id_member LIKE '%" + search + "%' or email_member LIKE '%" + search + "%' or nohp_member LIKE '%" + search + "%')";
            }


            MySqlDataReader record = a.Select(query);
            List<string[]> list = new List<string[]>();

            while (record.Read())
            {
                list.Add(new string[] { record["id_member"] + "", record["nama_member"] + "", record["nohp_member"] + "", record["email_member"] + "", record["rank_member"] + "", record["status_member"] + "" });
            }

            dataGridView2.DataSource = a.ConvertListToDataTable(list);
            dataGridView2.Refresh();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
