using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_assignment.Class;

namespace Group_assignment
{
    public partial class item : Form
    {
        Controller controller;
        public item()
        {
            InitializeComponent();
            controller = new Controller(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addItem addItem = new addItem();
            addItem.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            editid editid = new editid();
            editid.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remove remove = new remove();
            remove.Show();
        }

        private void item_Load(object sender, EventArgs e)
        {

        }
    }
}
