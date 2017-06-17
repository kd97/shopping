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
    public partial class Add : Form
    {
        private static String url = Class1.add;
        public DialogResult OK { get; internal set; }

        public Add()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String amount =textBox2.Text;
            String price = textBox3.Text;
            String purchasePrice = textBox4.Text;
            String kind = textBox5.Text;
            String postName = "name=" + name + "&amount=" + amount+ "&price=" +price+ "&purchasePrice=" +purchasePrice+ "&kind="+kind;
            
            JObject jo = Class1.post(url, postName);
            string message = jo["message"].ToString();
            string success = jo["is_success"].ToString();
            label7.Text = message;
            if (success == "True")
                this.DialogResult = DialogResult.OK;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
