namespace Cashier
{
    public partial class QueuingFrom : Form
    {
        private CashierClass cashier;

        public QueuingFrom()
        {
            InitializeComponent();
            cashier = new CashierClass();

            CashierWIndowQueue cashierWindow = new CashierWIndowQueue();
            cashierWindow.Show();

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
