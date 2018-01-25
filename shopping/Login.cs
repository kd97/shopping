using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
{
    public partial class Form1 : Form
    {
        private static String url = Class1.login;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String password = textBox2.Text;
            String postName = "username="+name+"&password="+password;

            JObject jo = Class1.post(url,postName);
            string message = jo["message"].ToString();
            label3.Text = message;
            string tmp = jo["is_success"].ToString();
            //MessageBox.Show(tmp);
            if (tmp == "True")
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show(message);
        }
    }
}
