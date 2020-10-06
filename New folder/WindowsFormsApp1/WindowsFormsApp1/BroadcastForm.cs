using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace WindowsFormsApp1
{
    public partial class BroadcastForm : Form
    {
        public BroadcastForm()
        {
            InitializeComponent();
        }

        private void broadcast()
        {
            MailMessage message = new MailMessage();
            var smtp = new SmtpClient();
            string header = tb_subject.Text;
            string content = tb_body.Text;

            message.From = new MailAddress("gedgetcomputer@gmail.com");

            string query = @"SELECT email_member FROM m_member
                    WHERE rank_member in (1, 2, 3, 4, 5) AND langganan_email = 1";
            MYSQLquery a = new MYSQLquery();
            MySqlDataReader record = a.Select(query);

            while (record.Read())
            {
                message.Bcc.Add(new MailAddress(record["email_member"] + ""));
            }
            message.Subject = header;
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = content;

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("gedgetcomputer@gmail.com", "gedget0202");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(message);

            MessageBox.Show("Broadcast has been sended");

        }



        private void bcwa()
        {
            string from = "6282122669125";
            string to = tb_subject.Text;
            string msg = tb_body.Text;
            WhatsApp a = new WhatsApp(from,"secret","admin",false,false);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            broadcast();
        }
    }
}
