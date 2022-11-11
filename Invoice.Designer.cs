
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice));
            this.btn_saveinvocie = new System.Windows.Forms.Button();
            this.btn_printinvoice = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.comboBox_customername = new System.Windows.Forms.ComboBox();
            this.textBox_invoiceid = new System.Windows.Forms.TextBox();
            this.lblInvoiceNumber = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.textBox_unitprice = new System.Windows.Forms.TextBox();
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
            this.btn_sendinvoice = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbUnitPrice = new System.Windows.Forms.TextBox();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbCustomerName = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dgv_Invoice = new System.Windows.Forms.DataGridView();
            this.tbInvoiceNumber = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_saveinvocie
            // 
            this.btn_saveinvocie.Location = new System.Drawing.Point(782, 487);
            this.btn_saveinvocie.Name = "btn_saveinvocie";
            this.btn_saveinvocie.Size = new System.Drawing.Size(292, 45);
            this.btn_saveinvocie.TabIndex = 1;
            this.btn_saveinvocie.Text = "Save as PDF";
            this.btn_saveinvocie.UseVisualStyleBackColor = true;
            this.btn_saveinvocie.Click += new System.EventHandler(this.btn_saveinvocie_Click);
            // 
            // btn_printinvoice
            // 
            this.btn_printinvoice.Location = new System.Drawing.Point(782, 404);
            this.btn_printinvoice.Name = "btn_printinvoice";
            this.btn_printinvoice.Size = new System.Drawing.Size(292, 45);
            this.btn_printinvoice.TabIndex = 2;
            this.btn_printinvoice.Text = "Print";
            this.btn_printinvoice.UseVisualStyleBackColor = true;
            this.btn_printinvoice.Click += new System.EventHandler(this.btn_printinvoice_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 760);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.nud_Quantity);
            this.tabPage1.Controls.Add(this.comboBox_customername);
            this.tabPage1.Controls.Add(this.textBox_invoiceid);
            this.tabPage1.Controls.Add(this.lblInvoiceNumber);
            this.tabPage1.Controls.Add(this.textBox_total);
            this.tabPage1.Controls.Add(this.textBox_unitprice);
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
            this.tabPage1.Size = new System.Drawing.Size(1132, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Invoice";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(210, 465);
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(296, 30);
            this.nud_Quantity.TabIndex = 25;
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nud_Quantity_KeyPress);
            // 
            // comboBox_customername
            // 
            this.comboBox_customername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_customername.FormattingEnabled = true;
            this.comboBox_customername.Items.AddRange(new object[] {
            "Lahiru kalutotage",
            "UI Sandamali",
            "Gayathri vidarshana",
            "Anjaani wilmalasooriya"});
            this.comboBox_customername.Location = new System.Drawing.Point(210, 120);
            this.comboBox_customername.Name = "comboBox_customername";
            this.comboBox_customername.Size = new System.Drawing.Size(296, 33);
            this.comboBox_customername.TabIndex = 24;
            // 
            // textBox_invoiceid
            // 
            this.textBox_invoiceid.Enabled = false;
            this.textBox_invoiceid.Location = new System.Drawing.Point(210, 65);
            this.textBox_invoiceid.Name = "textBox_invoiceid";
            this.textBox_invoiceid.ReadOnly = true;
            this.textBox_invoiceid.Size = new System.Drawing.Size(296, 30);
            this.textBox_invoiceid.TabIndex = 23;
            this.textBox_invoiceid.Visible = false;
            // 
            // lblInvoiceNumber
            // 
            this.lblInvoiceNumber.AutoSize = true;
            this.lblInvoiceNumber.Location = new System.Drawing.Point(78, 70);
            this.lblInvoiceNumber.Name = "lblInvoiceNumber";
            this.lblInvoiceNumber.Size = new System.Drawing.Size(104, 25);
            this.lblInvoiceNumber.TabIndex = 22;
            this.lblInvoiceNumber.Text = "Invoice No";
            // 
            // textBox_total
            // 
            this.textBox_total.Enabled = false;
            this.textBox_total.Location = new System.Drawing.Point(210, 563);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(296, 30);
            this.textBox_total.TabIndex = 21;
            this.textBox_total.TextChanged += new System.EventHandler(this.textBox_total_TextChanged);
            // 
            // textBox_unitprice
            // 
            this.textBox_unitprice.Location = new System.Drawing.Point(210, 512);
            this.textBox_unitprice.Name = "textBox_unitprice";
            this.textBox_unitprice.Size = new System.Drawing.Size(296, 30);
            this.textBox_unitprice.TabIndex = 20;
            this.textBox_unitprice.TextChanged += new System.EventHandler(this.textBox_unitprice_TextChanged);
            this.textBox_unitprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_unitprice_KeyPress);
            this.textBox_unitprice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_unitprice_KeyUp);
            // 
            // comboBox_item
            // 
            this.comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Items.AddRange(new object[] {
            "Printer",
            "Monitor"});
            this.comboBox_item.Location = new System.Drawing.Point(210, 343);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(296, 33);
            this.comboBox_item.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 568);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 517);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Unit Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(97, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Item";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(210, 290);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(296, 30);
            this.textBox_email.TabIndex = 13;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(210, 178);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(296, 30);
            this.textBox_phonenumber.TabIndex = 12;
            this.textBox_phonenumber.TextChanged += new System.EventHandler(this.textBox_phonenumber_TextChanged);
            this.textBox_phonenumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_phonenumber_KeyDown);
            this.textBox_phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phonenumber_KeyPress);
            this.textBox_phonenumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_phonenumber_KeyUp);
            // 
            // comboBox_district
            // 
            this.comboBox_district.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_district.FormattingEnabled = true;
            this.comboBox_district.Items.AddRange(new object[] {
            "Colombo",
            "Gampaha",
            "Kalutara",
            "Kandy",
            "Matale",
            "Nuwara Eliya ",
            "Galle",
            "Matara",
            "Hambantota",
            "Jaffna",
            "Kilinochchi",
            "Mannar",
            "Vavuniya",
            "Mullaitivu",
            "Batticaloa",
            "Ampara",
            "Trincomalee",
            "Kurunegala",
            "Puttalam",
            "Anuradhapura",
            "Polonnaruwa",
            "Badulla",
            "Moneragala",
            "Ratnapura",
            "Kegalle"});
            this.comboBox_district.Location = new System.Drawing.Point(210, 404);
            this.comboBox_district.Name = "comboBox_district";
            this.comboBox_district.Size = new System.Drawing.Size(296, 33);
            this.comboBox_district.TabIndex = 11;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(210, 234);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(296, 30);
            this.textBox_address.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "District";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 64);
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
            // btn_sendinvoice
            // 
            this.btn_sendinvoice.Location = new System.Drawing.Point(782, 566);
            this.btn_sendinvoice.Name = "btn_sendinvoice";
            this.btn_sendinvoice.Size = new System.Drawing.Size(292, 45);
            this.btn_sendinvoice.TabIndex = 0;
            this.btn_sendinvoice.Text = "Send ";
            this.btn_sendinvoice.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReset);
            this.tabPage2.Controls.Add(this.btnCalculate);
            this.tabPage2.Controls.Add(this.nudQuantity);
            this.tabPage2.Controls.Add(this.tbTotal);
            this.tabPage2.Controls.Add(this.tbUnitPrice);
            this.tabPage2.Controls.Add(this.cbItem);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.cbDistrict);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.cbCustomerName);
            this.tabPage2.Controls.Add(this.tbEmail);
            this.tabPage2.Controls.Add(this.tbPhone);
            this.tabPage2.Controls.Add(this.tbAddress);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.dgv_Invoice);
            this.tabPage2.Controls.Add(this.tbInvoiceNumber);
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.btn_search);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modify Invoice";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(953, 47);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 36);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "↩️   RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(950, 617);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 38);
            this.btnCalculate.TabIndex = 45;
            this.btnCalculate.Text = "🧮 CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(632, 527);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(296, 30);
            this.nudQuantity.TabIndex = 44;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(632, 625);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(296, 30);
            this.tbTotal.TabIndex = 43;
            // 
            // tbUnitPrice
            // 
            this.tbUnitPrice.Location = new System.Drawing.Point(632, 574);
            this.tbUnitPrice.Name = "tbUnitPrice";
            this.tbUnitPrice.Size = new System.Drawing.Size(296, 30);
            this.tbUnitPrice.TabIndex = 42;
            // 
            // cbItem
            // 
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Items.AddRange(new object[] {
            "Printer",
            "Monitor"});
            this.cbItem.Location = new System.Drawing.Point(632, 405);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(296, 33);
            this.cbItem.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(558, 630);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 25);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(519, 579);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 25);
            this.label20.TabIndex = 39;
            this.label20.Text = "Unit Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(529, 525);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 25);
            this.label21.TabIndex = 38;
            this.label21.Text = "Quantity";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(565, 413);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 25);
            this.label22.TabIndex = 37;
            this.label22.Text = "Item";
            // 
            // cbDistrict
            // 
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Items.AddRange(new object[] {
            "Colombo",
            "Gampaha",
            "Kalutara",
            "Kandy",
            "Matale",
            "Nuwara Eliya ",
            "Galle",
            "Matara",
            "Hambantota",
            "Jaffna",
            "Kilinochchi",
            "Mannar",
            "Vavuniya",
            "Mullaitivu",
            "Batticaloa",
            "Ampara",
            "Trincomalee",
            "Kurunegala",
            "Puttalam",
            "Anuradhapura",
            "Polonnaruwa",
            "Badulla",
            "Moneragala",
            "Ratnapura",
            "Kegalle"});
            this.cbDistrict.Location = new System.Drawing.Point(632, 466);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(296, 33);
            this.cbDistrict.TabIndex = 36;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(544, 474);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(70, 25);
            this.label23.TabIndex = 35;
            this.label23.Text = "District";
            // 
            // cbCustomerName
            // 
            this.cbCustomerName.FormattingEnabled = true;
            this.cbCustomerName.Items.AddRange(new object[] {
            "Lahiru kalutotage",
            "UI Sandamali",
            "Gayathri vidarshana",
            "Anjaani wilmalasooriya"});
            this.cbCustomerName.Location = new System.Drawing.Point(192, 405);
            this.cbCustomerName.Name = "cbCustomerName";
            this.cbCustomerName.Size = new System.Drawing.Size(296, 33);
            this.cbCustomerName.TabIndex = 34;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(192, 575);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(296, 30);
            this.tbEmail.TabIndex = 31;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(192, 463);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(296, 30);
            this.tbPhone.TabIndex = 30;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(192, 519);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(296, 30);
            this.tbAddress.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 580);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 25);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 468);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Phone Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(94, 524);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 25);
            this.label17.TabIndex = 26;
            this.label17.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 413);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(154, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Customer Name";
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoice.Location = new System.Drawing.Point(44, 113);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.ReadOnly = true;
            this.dgv_Invoice.RowHeadersWidth = 51;
            this.dgv_Invoice.RowTemplate.Height = 24;
            this.dgv_Invoice.Size = new System.Drawing.Size(1061, 258);
            this.dgv_Invoice.TabIndex = 6;
            this.dgv_Invoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Invoice_CellClick);
            // 
            // tbInvoiceNumber
            // 
            this.tbInvoiceNumber.Location = new System.Drawing.Point(163, 53);
            this.tbInvoiceNumber.Name = "tbInvoiceNumber";
            this.tbInvoiceNumber.Size = new System.Drawing.Size(164, 30);
            this.tbInvoiceNumber.TabIndex = 5;
            this.tbInvoiceNumber.TextChanged += new System.EventHandler(this.tbInvoiceNumber_TextChanged);
            this.tbInvoiceNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbInvoiceNumber_KeyUp);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(660, 680);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(116, 36);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(804, 680);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(152, 36);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "❌ DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(360, 50);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(172, 36);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "🔍  Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_invoiceid;
        private System.Windows.Forms.Label lblInvoiceNumber;
        private System.Windows.Forms.TextBox tbInvoiceNumber;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_customername;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_Invoice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbUnitPrice;
        private System.Windows.Forms.ComboBox cbItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbCustomerName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnReset;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}