
namespace KM
{
    partial class Invoice
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
            this.btn_sendinvoice = new System.Windows.Forms.Button();
            this.btn_saveinvocie = new System.Windows.Forms.Button();
            this.btn_printinvoice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox_customername = new System.Windows.Forms.ComboBox();
            this.textBox_invoiceid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_unitprice = new System.Windows.Forms.TextBox();
            this.textBox_quantity = new System.Windows.Forms.TextBox();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.comboBox_district = new System.Windows.Forms.ComboBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_invoicenb = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_createnewcustomer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sendinvoice
            // 
            this.btn_sendinvoice.Location = new System.Drawing.Point(782, 606);
            this.btn_sendinvoice.Name = "btn_sendinvoice";
            this.btn_sendinvoice.Size = new System.Drawing.Size(292, 45);
            this.btn_sendinvoice.TabIndex = 0;
            this.btn_sendinvoice.Text = "Send ";
            this.btn_sendinvoice.UseVisualStyleBackColor = true;
            // 
            // btn_saveinvocie
            // 
            this.btn_saveinvocie.Location = new System.Drawing.Point(782, 527);
            this.btn_saveinvocie.Name = "btn_saveinvocie";
            this.btn_saveinvocie.Size = new System.Drawing.Size(292, 45);
            this.btn_saveinvocie.TabIndex = 1;
            this.btn_saveinvocie.Text = "Save as PDF";
            this.btn_saveinvocie.UseVisualStyleBackColor = true;
            // 
            // btn_printinvoice
            // 
            this.btn_printinvoice.Location = new System.Drawing.Point(782, 444);
            this.btn_printinvoice.Name = "btn_printinvoice";
            this.btn_printinvoice.Size = new System.Drawing.Size(292, 45);
            this.btn_printinvoice.TabIndex = 2;
            this.btn_printinvoice.Text = "Print";
            this.btn_printinvoice.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 727);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox_customername);
            this.tabPage1.Controls.Add(this.textBox_invoiceid);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBox_total);
            this.tabPage1.Controls.Add(this.textBox_unitprice);
            this.tabPage1.Controls.Add(this.textBox_quantity);
            this.tabPage1.Controls.Add(this.comboBox_item);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.textBox_email);
            this.tabPage1.Controls.Add(this.textBox_phonenumber);
            this.tabPage1.Controls.Add(this.comboBox_district);
            this.tabPage1.Controls.Add(this.textBox_address);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_printinvoice);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_saveinvocie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_sendinvoice);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 689);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Invoice";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBox_customername
            // 
            this.comboBox_customername.FormattingEnabled = true;
            this.comboBox_customername.Location = new System.Drawing.Point(210, 160);
            this.comboBox_customername.Name = "comboBox_customername";
            this.comboBox_customername.Size = new System.Drawing.Size(296, 33);
            this.comboBox_customername.TabIndex = 24;
            // 
            // textBox_invoiceid
            // 
            this.textBox_invoiceid.Location = new System.Drawing.Point(210, 105);
            this.textBox_invoiceid.Name = "textBox_invoiceid";
            this.textBox_invoiceid.Size = new System.Drawing.Size(296, 30);
            this.textBox_invoiceid.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 110);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 25);
            this.label15.TabIndex = 22;
            this.label15.Text = "Invoice No";
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(210, 627);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(296, 30);
            this.textBox_total.TabIndex = 21;
            // 
            // textBox_unitprice
            // 
            this.textBox_unitprice.Location = new System.Drawing.Point(210, 576);
            this.textBox_unitprice.Name = "textBox_unitprice";
            this.textBox_unitprice.Size = new System.Drawing.Size(296, 30);
            this.textBox_unitprice.TabIndex = 20;
            // 
            // textBox_quantity
            // 
            this.textBox_quantity.Location = new System.Drawing.Point(210, 522);
            this.textBox_quantity.Name = "textBox_quantity";
            this.textBox_quantity.Size = new System.Drawing.Size(296, 30);
            this.textBox_quantity.TabIndex = 19;
            // 
            // comboBox_item
            // 
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Location = new System.Drawing.Point(210, 383);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(296, 33);
            this.comboBox_item.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 581);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Item";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(210, 330);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(296, 30);
            this.textBox_email.TabIndex = 13;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(210, 218);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(296, 30);
            this.textBox_phonenumber.TabIndex = 12;
            // 
            // comboBox_district
            // 
            this.comboBox_district.FormattingEnabled = true;
            this.comboBox_district.Location = new System.Drawing.Point(210, 451);
            this.comboBox_district.Name = "comboBox_district";
            this.comboBox_district.Size = new System.Drawing.Size(296, 33);
            this.comboBox_district.TabIndex = 11;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(210, 274);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(296, 30);
            this.textBox_address.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "District";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 200);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jupiter Packing Suppliers\r\nAlubogahawatta\r\nParagasthota\r\nHorana\r\n\r\nTel-0777715233" +
    "\r\n\r\nEmail - jupiterpacking7@gmail.com";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_invoicenb);
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_invoicenb
            // 
            this.textBox_invoicenb.Location = new System.Drawing.Point(132, 53);
            this.textBox_invoicenb.Name = "textBox_invoicenb";
            this.textBox_invoicenb.Size = new System.Drawing.Size(164, 30);
            this.textBox_invoicenb.TabIndex = 5;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(645, 172);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(116, 44);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(645, 248);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(645, 98);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(116, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 0;
            this.label13.Text = "Invoice No";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_createnewcustomer);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 630);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Customer Dashboard";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_createnewcustomer
            // 
            this.btn_createnewcustomer.Location = new System.Drawing.Point(15, 33);
            this.btn_createnewcustomer.Name = "btn_createnewcustomer";
            this.btn_createnewcustomer.Size = new System.Drawing.Size(171, 59);
            this.btn_createnewcustomer.TabIndex = 0;
            this.btn_createnewcustomer.Text = "Create New Customer";
            this.btn_createnewcustomer.UseVisualStyleBackColor = true;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sendinvoice;
        private System.Windows.Forms.Button btn_saveinvocie;
        private System.Windows.Forms.Button btn_printinvoice;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox_district;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.TextBox textBox_unitprice;
        private System.Windows.Forms.TextBox textBox_quantity;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_invoiceid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_invoicenb;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_customername;
        private System.Windows.Forms.Button btn_createnewcustomer;
    }
}