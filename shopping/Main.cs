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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();

            sell.ShowDialog();
        }

        private void 查询商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductList product = new ProductList();
            
            product.Show();
        }

        private void 库存明细ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StoreList store =new StoreList();
           
            store.Show();
        }

        private void 入库管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoStore gostore = new GoStore();
            gostore.ShowDialog();
          
        }

        private void 添加商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add add=new Add();
            add.ShowDialog();
        }

        private void 修改商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change change = new Change();
            change.ShowDialog();
        }

        private void 删除商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove remove = new Remove();
            remove.ShowDialog();
        }

        private void 销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellList selllist = new SellList();
            
            selllist.Show();
        }
    }
}
