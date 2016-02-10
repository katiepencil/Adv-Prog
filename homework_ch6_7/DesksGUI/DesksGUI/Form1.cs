using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesksGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int basePrice;
            int numDrawers = Convert.ToInt32(txtNumber.Text);
            string typeWood;
            
            switch (txtWood.Text)
            {
                case "p":
                    basePrice = 100;
                    typeWood = "Pine";
                    break;
                case "o":
                    basePrice = 140;
                    typeWood = "Oak";
                    break;
                default:
                    basePrice = 100;
                    typeWood = "Mahogany or other";
                    break;
            }
            int myCost = (basePrice + (numDrawers * 30));

            lblResults.Text = String.Format("You have ordered a desk with {0} drawers of {1}.", numDrawers.ToString(), typeWood);
            lblCost.Text = String.Format("Your desk will cost {0}.", myCost.ToString("c"));

        }

        
    }
}
