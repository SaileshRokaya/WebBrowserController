using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnFrd_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(txtSearch.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }
    }
}
