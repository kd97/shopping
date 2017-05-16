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
    public partial class Form1 : Form
    {
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
            if (textBox1.Text == "")
                this.label4.Text = "用户名不能为空";
            else if (textBox2.Text == "")
                this.label4.Text = "密码不能为空";
            else if (!textBox1.Text.Equals("123"))
                this.label4.Text = "用户名不存在";
            else if (!textBox2.Text.Equals("123"))
                this.label4.Text = "密码错误";
            else if(textBox2.Text == "123"&&textBox1.Text=="123")
                this.DialogResult = DialogResult.OK;  
        }
    }
}
