
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(603, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Document Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(680, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jupiter Packing Suppliers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_invoice
            // 
            this.btn_invoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice.Location = new System.Drawing.Point(317, 176);
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.Size = new System.Drawing.Size(419, 225);
            this.btn_invoice.TabIndex = 2;
            this.btn_invoice.Text = "INVOICE";
            this.btn_invoice.UseVisualStyleBackColor = false;
            this.btn_invoice.Click += new System.EventHandler(this.btn_invoice_Click);
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order.Location = new System.Drawing.Point(860, 176);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(419, 225);
            this.btn_order.TabIndex = 3;
            this.btn_order.Text = "ORDER";
            this.btn_order.UseVisualStyleBackColor = false;
            // 
            // btn_purchasing
            // 
            this.btn_purchasing.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_purchasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_purchasing.Location = new System.Drawing.Point(317, 490);
            this.btn_purchasing.Name = "btn_purchasing";
            this.btn_purchasing.Size = new System.Drawing.Size(419, 225);
            this.btn_purchasing.TabIndex = 4;
            this.btn_purchasing.Text = "PURCHASING";
            this.btn_purchasing.UseVisualStyleBackColor = false;
            this.btn_purchasing.Click += new System.EventHandler(this.btn_purchasing_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Location = new System.Drawing.Point(860, 490);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(419, 225);
            this.btn_stock.TabIndex = 5;
            this.btn_stock.Text = "EMPLOYEE ATTENDANCE";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.btn_purchasing);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.btn_invoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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