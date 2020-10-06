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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new HalamanBarang().ShowDialog();            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminHalamanBarang().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new HalamanMember().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new HalamanKasir().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new HalamanGudang().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new HalamanUtamaKasir().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new HalamanHistori().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new HistoriBarang().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new HalamanReport().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new FormLogin().ShowDialog();
        }
    }
}
