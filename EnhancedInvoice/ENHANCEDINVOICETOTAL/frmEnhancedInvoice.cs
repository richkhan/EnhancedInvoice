using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENHANCEDINVOICETOTAL
{
    public partial class frmEnhancedInvoice : Form
    {
        /****************************************************************************
         <project firstname="Richard" lastname="Khan" projname="ENHANCEDINVOICETOTAL"/>
         ****************************************************************************/
        /// <summary>
        /// This program takes an input of Subtotal and calculates the Discount Amount 
        /// using the Discount Percent. Then output the total. This program also keeps 
        /// track of how many invoices were entered, the total number of invoices, the 
        /// average total of the invoices, Largest Invoice amount, and Smallest Invoice Amount. 
        /// </summary>

        public frmEnhancedInvoice()
        {
            InitializeComponent();
        }

        decimal numberOfInvoices = 0m;
        decimal totalNumberOfInvoices = 0m;
        decimal invoiceAverage = 0m;
       
        decimal max = 0m, min = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
         
            // get the subtotal amount form EnterSubtotal text box
            decimal enteredSubtotal = Convert.ToDecimal(txtEnterSubtotal.Text);


            decimal discountPercent = .25m;
            
            // calculate and assign the values for the 
            // dicountAmount and invoiceTotal variable

            decimal discountAmount = Math.Round(enteredSubtotal * discountPercent,2);
            decimal invoiceTotal = enteredSubtotal - discountAmount;



            numberOfInvoices++;
            
            totalNumberOfInvoices += invoiceTotal;
            invoiceAverage = totalNumberOfInvoices / numberOfInvoices;

            if(numberOfInvoices == 1)
            {
                max = invoiceTotal;
                min = invoiceTotal;
                txtLargestInvoice.Text = invoiceTotal.ToString("c");
                txtSmallestInvoice.Text = invoiceTotal.ToString("c");
            }
            else if(numberOfInvoices > 1)
            {
                if (invoiceTotal < min)
                {
                    min = invoiceTotal;
                }
                if (invoiceTotal > max)
                {
                    max = invoiceTotal;
                }
                txtLargestInvoice.Text = max.ToString("c");
                txtSmallestInvoice.Text = min.ToString("c");
            }

            //format the values and display them in their text boxes

            txtSubtotal.Text = enteredSubtotal.ToString("c");
            txtNumberOfInvoices.Text = numberOfInvoices.ToString();
            txtTotalOfInvoices.Text = totalNumberOfInvoices.ToString("c");
            txtInvoiceAverage.Text = invoiceAverage.ToString("c");
            txtDiscountPercent.Text = discountPercent.ToString("p1");                              // percent format                      // with 1 decimal place
            txtDiscountAmount.Text = discountAmount.ToString("c");  // currency format
            txtTotal.Text = invoiceTotal.ToString("c");

            txtEnterSubtotal.Text = "";

            
            // move the focus to the Subtotal text box
            txtEnterSubtotal.Focus();
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            frmAboutMe f = new frmAboutMe();
            this.Hide(); //Hide Main form
            f.ShowDialog();
            this.Show(); //show main form
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnClearTotals_Click(object sender, EventArgs e)
        {
            numberOfInvoices = 0m;
            totalNumberOfInvoices = 0m;
            invoiceAverage = 0m;

            txtLargestInvoice.Text = "";
            txtSmallestInvoice.Text = "";

            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";

            txtEnterSubtotal.Focus();
        }
    }
}
