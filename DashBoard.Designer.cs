
namespace KM
{
    partial class DashBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_invoice = new System.Windows.Forms.Button();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_purchasing = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jupiter Packing Suppliers";
            // 
            // btn_invoice
            // 
            this.btn_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.Location = new System.Drawing.Point(134, 133);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(511, 59);
            this.btn_invoice.TabIndex = 2;
            this.btn_invoice.Text = "INVOICE";
            this.btn_invoice.UseVisualStyleBackColor = true;
            // 
            // btn_order
            // 
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(134, 219);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(511, 55);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "ORDER";
            this.btn_order.UseVisualStyleBackColor = true;
            // 
            // btn_purchasing
            // 
            this.btn_purchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchasing.Location = new System.Drawing.Point(134, 299);
            this.btn_purchasing.Name = "btn_purchasing";
            this.btn_purchasing.Size = new System.Drawing.Size(511, 56);
            this.btn_purchasing.TabIndex = 4;
            this.btn_purchasing.Text = "PURCHASING";
            this.btn_purchasing.UseVisualStyleBackColor = true;
            this.btn_purchasing.Click += new System.EventHandler(this.btn_purchasing_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Location = new System.Drawing.Point(134, 385);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(511, 53);
            this.btn_stock.TabIndex = 5;
            this.btn_stock.Text = "EMPLOYEE ATTENDANCE";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_purchasing);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_invoice;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_purchasing;
        private System.Windows.Forms.Button btn_stock;
    }
}