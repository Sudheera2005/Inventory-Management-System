namespace Stocks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStockBtn_Click(object sender, EventArgs e)
        {
            StockController.Edit(this.NameLabel.Text);
        }
    }
}
