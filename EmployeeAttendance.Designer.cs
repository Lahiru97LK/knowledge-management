
namespace KM
{
    partial class EmployeeAttendance
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.txtbEmployeeId = new System.Windows.Forms.TextBox();
            this.txtbEmployeeName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtbTotalWorkingHours = new System.Windows.Forms.TextBox();
            this.dgvEmployeeAttendance = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Start time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(177, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Off time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total working hours";
            // 
            // btnMark
            // 
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Location = new System.Drawing.Point(871, 272);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(96, 48);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "MARK";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // txtbEmployeeId
            // 
            this.txtbEmployeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmployeeId.Location = new System.Drawing.Point(314, 57);
            this.txtbEmployeeId.Name = "txtbEmployeeId";
            this.txtbEmployeeId.Size = new System.Drawing.Size(392, 30);
            this.txtbEmployeeId.TabIndex = 7;
            this.txtbEmployeeId.TextChanged += new System.EventHandler(this.txtbEmployeeId_TextChanged);
            this.txtbEmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbEmployeeId_KeyPress);
            this.txtbEmployeeId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbEmployeeId_KeyUp);
            // 
            // txtbEmployeeName
            // 
            this.txtbEmployeeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbEmployeeName.Enabled = false;
            this.txtbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbEmployeeName.Location = new System.Drawing.Point(314, 102);
            this.txtbEmployeeName.Name = "txtbEmployeeName";
            this.txtbEmployeeName.Size = new System.Drawing.Size(392, 30);
            this.txtbEmployeeName.TabIndex = 8;
            this.txtbEmployeeName.TextChanged += new System.EventHandler(this.txtbEmployeeName_TextChanged);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "";
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(314, 148);
            this.dateTimePickerDate.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(392, 30);
            this.dateTimePickerDate.TabIndex = 9;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(314, 193);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(157, 30);
            this.dtpStartTime.TabIndex = 10;
            this.dtpStartTime.Value = new System.DateTime(2022, 10, 30, 8, 0, 0, 0);
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "hh:mm tt";
            this.dtpEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(314, 239);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowUpDown = true;
            this.dtpEndTime.Size = new System.Drawing.Size(157, 30);
            this.dtpEndTime.TabIndex = 11;
            this.dtpEndTime.Value = new System.DateTime(2022, 10, 30, 17, 0, 0, 0);
            this.dtpEndTime.DropDown += new System.EventHandler(this.dtpEndTime_DropDown);
            this.dtpEndTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpEndTime_KeyPress);
            this.dtpEndTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpEndTime_KeyUp);
            // 
            // txtbTotalWorkingHours
            // 
            this.txtbTotalWorkingHours.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtbTotalWorkingHours.Enabled = false;
            this.txtbTotalWorkingHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalWorkingHours.Location = new System.Drawing.Point(314, 284);
            this.txtbTotalWorkingHours.Name = "txtbTotalWorkingHours";
            this.txtbTotalWorkingHours.Size = new System.Drawing.Size(157, 30);
            this.txtbTotalWorkingHours.TabIndex = 12;
            // 
            // dgvEmployeeAttendance
            // 
            this.dgvEmployeeAttendance.AllowUserToAddRows = false;
            this.dgvEmployeeAttendance.AllowUserToDeleteRows = false;
            this.dgvEmployeeAttendance.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEmployeeAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeAttendance.Location = new System.Drawing.Point(314, 353);
            this.dgvEmployeeAttendance.Name = "dgvEmployeeAttendance";
            this.dgvEmployeeAttendance.ReadOnly = true;
            this.dgvEmployeeAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvEmployeeAttendance.RowHeadersVisible = false;
            this.dgvEmployeeAttendance.RowHeadersWidth = 51;
            this.dgvEmployeeAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmployeeAttendance.RowTemplate.Height = 24;
            this.dgvEmployeeAttendance.Size = new System.Drawing.Size(772, 374);
            this.dgvEmployeeAttendance.TabIndex = 13;
            this.dgvEmployeeAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployeeAttendance_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(973, 272);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(113, 48);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(492, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 32);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(780, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 48);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(780, 54);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 33);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(780, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 33);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EmployeeAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 756);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvEmployeeAttendance);
            this.Controls.Add(this.txtbTotalWorkingHours);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.txtbEmployeeName);
            this.Controls.Add(this.txtbEmployeeId);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeAttendance";
            this.Text = "EmployeeAttendance";
            this.Load += new System.EventHandler(this.EmployeeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.TextBox txtbEmployeeId;
        private System.Windows.Forms.TextBox txtbEmployeeName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.TextBox txtbTotalWorkingHours;
        private System.Windows.Forms.DataGridView dgvEmployeeAttendance;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
    }
}