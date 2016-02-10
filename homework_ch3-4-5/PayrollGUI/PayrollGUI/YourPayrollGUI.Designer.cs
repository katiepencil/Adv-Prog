namespace PayrollGUI
{
    partial class YourPayrollGUI
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
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.txtBox_SSnum = new System.Windows.Forms.TextBox();
            this.txtBox_hourlyPay = new System.Windows.Forms.TextBox();
            this.txtBox_numHoursWorked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(167, 41);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(232, 22);
            this.txtBox_name.TabIndex = 0;
            // 
            // txtBox_SSnum
            // 
            this.txtBox_SSnum.Location = new System.Drawing.Point(167, 73);
            this.txtBox_SSnum.Name = "txtBox_SSnum";
            this.txtBox_SSnum.Size = new System.Drawing.Size(175, 22);
            this.txtBox_SSnum.TabIndex = 1;
            // 
            // txtBox_hourlyPay
            // 
            this.txtBox_hourlyPay.Location = new System.Drawing.Point(167, 106);
            this.txtBox_hourlyPay.Name = "txtBox_hourlyPay";
            this.txtBox_hourlyPay.Size = new System.Drawing.Size(100, 22);
            this.txtBox_hourlyPay.TabIndex = 2;
            // 
            // txtBox_numHoursWorked
            // 
            this.txtBox_numHoursWorked.Location = new System.Drawing.Point(220, 137);
            this.txtBox_numHoursWorked.Name = "txtBox_numHoursWorked";
            this.txtBox_numHoursWorked.Size = new System.Drawing.Size(100, 22);
            this.txtBox_numHoursWorked.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter your payroll information...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "SS number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hourly pay rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hours worked this period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 22);
            this.label7.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(36, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 162);
            this.button1.TabIndex = 11;
            this.button1.Text = "Click here to see your payroll results for this pay period.";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGreen;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 22);
            this.label6.TabIndex = 12;
            // 
            // YourPayrollGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_numHoursWorked);
            this.Controls.Add(this.txtBox_hourlyPay);
            this.Controls.Add(this.txtBox_SSnum);
            this.Controls.Add(this.txtBox_name);
            this.Name = "YourPayrollGUI";
            this.Text = "This is Your Payroll GUI! Enjoy!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.TextBox txtBox_SSnum;
        private System.Windows.Forms.TextBox txtBox_hourlyPay;
        private System.Windows.Forms.TextBox txtBox_numHoursWorked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}

