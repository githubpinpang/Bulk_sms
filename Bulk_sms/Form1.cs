using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Bulk_sms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Test+message+text
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient w = new WebClient();
                Stream s = w.OpenRead(string.Format("https://platform.clickatell.com/messages/http/send?apiKey=xI3dqDS5QeG4n5lM4HXXPA==&to={0}&content={1}",

                                                    textBox1.Text, textBox2.Text));
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                MessageBox.Show(result, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
