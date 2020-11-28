using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            invoiceVatComboBox.SelectedIndex =
                clientComboBox.SelectedIndex =
                currencyComboBox.SelectedIndex =
                exchangeRateComboBox.SelectedIndex = 0;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(invoiceDescriptionTextBox.Text))
            {
                MessageBox.Show("Invalid Invoice description", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (invoiceAmountNumericUpDown.Value < 1)
            {
                MessageBox.Show("Invalid Invoice amount", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(orderNumberTextBox.Text))
            {
                MessageBox.Show("Invalid Order Number", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(salesAgentTextBox.Text))
            {
                MessageBox.Show("Invalid Sales agent", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Data.AssesmentContext db = new Data.AssesmentContext())
            {
                var invoice = new Data.Invoice
                {
                    Client = clientComboBox.Text,
                    Currency = currencyComboBox.Text,
                    DeliveryDate = deliveryDateDateTimePicker.Value,
                    ExchangeRate = double.Parse(exchangeRateComboBox.Text),
                    InvoiceAmount = (double)invoiceAmountNumericUpDown.Value,
                    InvoiceDate = invoiceDateDateTimePicker.Value,
                    InvoiceDescription = invoiceDescriptionTextBox.Text,
                    InvoiceVat = double.Parse(invoiceVatComboBox.Text),
                    OrderNumber = orderNumberTextBox.Text,
                    SalesAgent = salesAgentTextBox.Text,
                    SettleDate = settleDateDateTimePicker.Value
                };

                try
                {
                    db.Invoices.Add(invoice);
                    int affected = db.SaveChanges();
                    if (affected > 0)
                    {
                        MessageBox.Show($"Invoice save successfully, with ID #: {invoice.InvoiceNumber}");
                        Close();
                    }else
                    {
                        MessageBox.Show("Try again, the invoice is not saved", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }catch(Exception ex)
                {
                    string msg = ex.Message;
                    MessageBox.Show($"An error occure while saving the invoice,\n{msg}", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
