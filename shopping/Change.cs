using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopping
{
    public partial class Change : Form
    {
        private static String url = Class1.change;
        public Change()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String goodsID = textBox1.Text;
            String name = textBox6.Text;
            String amount = textBox2.Text;
            String price = textBox3.Text;
            String purchasePrice = textBox4.Text;
            String kind = textBox5.Text;
            String postName = "goodsID="+goodsID+"&name=" + name + "&amount=" + amount + "&price=" + price + "&purchasePrice=" + purchasePrice + "&kind=" + kind;
            //MessageBox.Show(postName);
            JObject jo = Class1.post(url, postName);
            string message = jo["message"].ToString();
            string success = jo["is_success"].ToString();
            label8.Text = message;
            if (success == "True")
                this.DialogResult = DialogResult.OK;
        }
    }
}
