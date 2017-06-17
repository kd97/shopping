using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
    public partial class ProductList : Form
    {
        private static String url = Class1.productlist;
        public ProductList()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            JObject jo = Class1.get(url);

            String goodsStr = jo["goodsList"].ToString();
            Array goodsList = goodsStr.Split('&');
           
            List<Goods> goodsDataList = new List<Goods>();
            foreach (String goods in goodsList)
            {
                String[] goodsInfo = goods.Split('$');
                if (goods == "")
                    break;
                goodsDataList.Add(new Goods() {
                    编号 = goodsInfo[0],
                    商品名 = goodsInfo[1],
                    数量 = goodsInfo[2],
                    价格 = goodsInfo[3],
                    进价 = goodsInfo[4],
                    种类 = goodsInfo[5]
                });
                
                
            }

            dataGridView1.DataSource = goodsDataList;



        }
    }

    class Goods
    {
        public string 编号 { get; set; }
        public string 商品名 { get; set; }
        public string 数量 { get; set; }
        public string 价格 { get; set; }
        public string 进价 { get; set; }
        public string 种类 { get; set; }
    }
}
