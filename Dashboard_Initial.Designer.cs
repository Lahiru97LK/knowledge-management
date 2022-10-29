
namespace KM
{
    partial class Dashboard_Initial
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
            this.btnWebsite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWhatsApp = new System.Windows.Forms.Button();
            this.btnFacebook = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWebsite
            // 
            this.btnWebsite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebsite.Location = new System.Drawing.Point(424, 621);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(196, 81);
            this.btnWebsite.TabIndex = 7;
            this.btnWebsite.Text = "WEBSITE";
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jupiter Packing Suppliers";
            // 
            // btnWhatsApp
            // 
            this.btnWhatsApp.BackgroundImage = global::KM.Properties.Resources.whatsapp;
            this.btnWhatsApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhatsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatsApp.Location = new System.Drawing.Point(678, 621);
            this.btnWhatsApp.Name = "btnWhatsApp";
            this.btnWhatsApp.Size = new System.Drawing.Size(196, 81);
            this.btnWhatsApp.TabIndex = 8;
            this.btnWhatsApp.UseVisualStyleBackColor = true;
            this.btnWhatsApp.Click += new System.EventHandler(this.btnWhatsApp_Click_1);
            // 
            // btnFacebook
            // 
            this.btnFacebook.BackgroundImage = global::KM.Properties.Resources.facebook_logo;
            this.btnFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacebook.Location = new System.Drawing.Point(174, 621);
            this.btnFacebook.Name = "btnFacebook";
            this.btnFacebook.Size = new System.Drawing.Size(196, 81);
            this.btnFacebook.TabIndex = 6;
            this.btnFacebook.UseVisualStyleBackColor = true;
            this.btnFacebook.Click += new System.EventHandler(this.btnFacebook_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KM.Properties.Resources.mainLogoSize;
            this.pictureBox1.Location = new System.Drawing.Point(288, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(519, 445);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard_Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 803);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnWhatsApp);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.btnFacebook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Initial";
            this.Text = "Dashboard_Initial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhatsApp;
        private System.Windows.Forms.Button btnWebsite;
        private System.Windows.Forms.Button btnFacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}