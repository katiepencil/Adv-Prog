using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderReceiptGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text, address = textBox2.Text, city = textBox3.Text, state = textBox4.Text;
            int zip = Convert.ToInt32(textBox5.Text), blenderNum = Convert.ToInt32(textBox6.Text);
            double amountDuePreTax, taxRate = 0.07, salesTaxDue, netDue, blenderPrice = 39.95;

            amountDuePreTax = blenderNum * blenderPrice;
            salesTaxDue = amountDuePreTax * taxRate;
            netDue = amountDuePreTax + salesTaxDue;

            label8.Text = "You entered...\n" +
                name + "\n" + address + "\n" + city + ", " + state + "  " + zip.ToString();

            label9.Text = "You ordered " + blenderNum.ToString() + " blenders." +
                "\nAmount due before tax = " + amountDuePreTax.ToString("c") +
                "\nSales tax = " + salesTaxDue.ToString("c") +
                "\nThe total due = " + netDue.ToString("c") +
                "\n\nThank you for your order!";

        }
    }
}
