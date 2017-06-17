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
    public partial class GoStore : Form
    {
        private static String url = Class1.goStore;
        public GoStore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String number = textBox2.Text;
            String postName = "goodsID=" + id + "&num=" + number;

            JObject jo = Class1.post(url, postName);
            string message = jo["message"].ToString();
            label3.Text = message;
            string success = jo["is_success"].ToString();
            if (success == "True")
                this.DialogResult = DialogResult.OK;
        }
    }
}
