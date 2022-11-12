
namespace KM
{
    partial class Order
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
            this.lbl_customername = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbi_quantity = new System.Windows.Forms.Label();
            this.item_comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cb_customer_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_customername
            // 
            this.lbl_customername.AutoSize = true;
            this.lbl_customername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customername.Location = new System.Drawing.Point(80, 44);
            this.lbl_customername.Name = "lbl_customername";
            this.lbl_customername.Size = new System.Drawing.Size(154, 25);
            this.lbl_customername.TabIndex = 0;
            this.lbl_customername.Text = "Customer Name";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(84, 149);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(49, 25);
            this.lbl_item.TabIndex = 1;
            this.lbl_item.Text = "Item";
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(25, 278);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.Size = new System.Drawing.Size(712, 362);
            this.dgvOrder.TabIndex = 4;
            this.dgvOrder.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOrder_RowHeaderMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(830, 91);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(311, 47);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(830, 22);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(311, 47);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(830, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(311, 47);
            this.button3.TabIndex = 7;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date";
            // 
            // lbi_quantity
            // 
            this.lbi_quantity.AutoSize = true;
            this.lbi_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbi_quantity.Location = new System.Drawing.Point(84, 201);
            this.lbi_quantity.Name = "lbi_quantity";
            this.lbi_quantity.Size = new System.Drawing.Size(85, 25);
            this.lbi_quantity.TabIndex = 10;
            this.lbi_quantity.Text = "Quantity";
            // 
            // item_comboBox1
            // 
            this.item_comboBox1.FormattingEnabled = true;
            this.item_comboBox1.Items.AddRange(new object[] {
            "Bag 5\" x 5\" black",
            "Bag 6\" x 6\" black",
            "Bag 10\" x 12\" black",
            "Bag 12\" x 14\" black",
            "Bag 14\" x 14\" black",
            "Bag 16\" x 16\" black"});
            this.item_comboBox1.Location = new System.Drawing.Point(249, 153);
            this.item_comboBox1.Name = "item_comboBox1";
            this.item_comboBox1.Size = new System.Drawing.Size(200, 24);
            this.item_comboBox1.TabIndex = 11;
            this.item_comboBox1.SelectedIndexChanged += new System.EventHandler(this.item_comboBox1_SelectedIndexChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(459, 236);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(250, 25);
            this.lbl_search.TabIndex = 12;
            this.lbl_search.Text = "Search By Customer Name";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(737, 240);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(200, 22);
            this.textBox_search.TabIndex = 13;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(249, 206);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 22);
            this.numericUpDown1.TabIndex = 14;
            // 
            // cb_customer_name
            // 
            this.cb_customer_name.FormattingEnabled = true;
            this.cb_customer_name.Items.AddRange(new object[] {
            "Lahiru kalutotage",
            "UI Sandamali",
            "Gayathri vidarshana",
            "Anjaani wilmalasooriya",
            "Suneetha m",
            "Krishani anuththara",
            "rukshila wettamuni"});
            this.cb_customer_name.Location = new System.Drawing.Point(249, 44);
            this.cb_customer_name.Name = "cb_customer_name";
            this.cb_customer_name.Size = new System.Drawing.Size(200, 24);
            this.cb_customer_name.TabIndex = 15;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.cb_customer_name);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.item_comboBox1);
            this.Controls.Add(this.lbi_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_customername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_customername;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbi_quantity;
        private System.Windows.Forms.ComboBox item_comboBox1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cb_customer_name;
    }
}