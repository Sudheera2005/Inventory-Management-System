using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stocks
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click_1(object sender, EventArgs e)
        {
            StockController.Save(this.Title.Text, this.qtyLabel.Text, this.costLabel.Text);
            this.Close();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            StockController.Delete(this.Title.Text);
            this.Close();
        }
    }
}
