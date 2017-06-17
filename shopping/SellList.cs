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
    public partial class SellList : Form
    {
        public SellList()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            JObject jo = Class1.get(Class1.recordsPath);
            String total = jo["total"].ToString();
            totalLabel.Text = "总额：" + total;
            String recordsStr = jo["records"].ToString();
            Array recordsList = recordsStr.Split('&');

            List<Records> recordsDataList = new List<Records>();
            foreach (String records in recordsList)
            {
                String[] recordsInfo = records.Split('$');
                if (records == "")
                    break;
                recordsDataList.Add(new Records()
                {
                    时间 = recordsInfo[0],
                    操作人 = recordsInfo[1],
                    操作 = recordsInfo[2],
                    商品名称 = recordsInfo[3],
                    数量 = recordsInfo[4],
                    总额 = recordsInfo[5],
                    增减 = recordsInfo[6]=="True"?"+":"-",

                });


            }

            dataGridView1.DataSource = recordsDataList;
        }
    }
    class Records
    {
        public string 时间 { get; set; }
        public string 操作人 { get; set; }
        public string 操作 { get; set; }
        public string 商品名称 { get; set; }
        public string 数量 { get; set; }
        public string 总额 { get; set; }
        public string 增减 { get; set; }
    }
}
