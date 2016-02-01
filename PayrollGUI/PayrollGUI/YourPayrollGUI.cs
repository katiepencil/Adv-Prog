using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class YourPayrollGUI : Form
    {
        public YourPayrollGUI()
        {
            InitializeComponent();
        }

        
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string name = txtBox_name.Text;
            int ssNum = Convert.ToInt32(txtBox_SSnum.Text);
            double payRate = Convert.ToDouble(txtBox_hourlyPay.Text);
            double hoursWorked = Convert.ToDouble(txtBox_numHoursWorked.Text);

            double grossPay, fedTaxRate = 0.15, stateTaxRate = 0.05, netPay, fedTax, stateTax;

            grossPay = payRate * hoursWorked;
            fedTax = grossPay * fedTaxRate;
            stateTax = grossPay * stateTaxRate;
            netPay = grossPay - fedTax - stateTax;
            
            label7.Text = "Thank you. You entered... \n\nName: " + name + 
                "\nSocial Security number: " + ssNum.ToString() +
                "\nHourly pay rate: " + payRate.ToString("c") + 
                "\nHours worked this pay period: " + hoursWorked.ToString();

            label6.Text = "Your gross pay: " + grossPay.ToString("c") +
                "\nFederal withholding tax: " + fedTax.ToString("c") +
                "\nState withholding tax: " + stateTax.ToString("c") +
                "\nYour net pay this pay period: " + netPay.ToString("c");
        }
    }
}
