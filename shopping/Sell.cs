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
    
    public partial class Sell : Form
    {
        private static String url = Class1.sell;
        public Sell()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String number = textBox2.Text;
            String postName="goodsID=" + id + "&num=" + number;
            
            //MessageBox.Show(postName);
            JObject jo = Class1.post(url, postName);
            string message = jo["message"].ToString();
            string success = jo["is_success"].ToString();
            label3.Text=message;
            if (success == "True")
                this.DialogResult = DialogResult.OK;
        }
    }
}
