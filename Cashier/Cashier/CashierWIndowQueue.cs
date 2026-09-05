using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cashier
{
    public partial class CashierWIndowQueue : Form
    {
        private System.Windows.Forms.Timer timer;

        public CashierWIndowQueue()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1 * 1000; // 1 sec
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
    }
}

