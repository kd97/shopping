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
    public partial class Remove : Form
    {
        private static String url = Class1.remove;
        public Remove()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            
            String postName = "goodsID=" + id;

            JObject jo = Class1.post(url, postName);
            string message = jo["message"].ToString();
            string success = jo["is_success"].ToString();
            label2.Text = message;
            if (success == "True")
                this.DialogResult = DialogResult.OK;
        }
    }
}
