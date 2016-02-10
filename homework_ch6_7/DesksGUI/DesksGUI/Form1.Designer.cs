namespace DesksGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtWood = new System.Windows.Forms.TextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(69, 112);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 22);
            this.txtNumber.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(69, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(136, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Number of drawers?";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(316, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(384, 17);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Type of wood? (\'p\' for pine, \'m\' for mahogany, or \'o\' for oak)";
            // 
            // txtWood
            // 
            this.txtWood.Location = new System.Drawing.Point(356, 111);
            this.txtWood.Name = "txtWood";
            this.txtWood.Size = new System.Drawing.Size(100, 22);
            this.txtWood.TabIndex = 3;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(129, 211);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(299, 57);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "Click here to place your order.";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(161, 308);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(83, 17);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "results here";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(161, 358);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(109, 17);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "cost will go here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 487);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.txtWood);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtWood;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCost;
    }
}

