﻿
namespace StockMaintenanceSystem
{
    partial class Inquire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inquire));
            this.lblSorgulaEkipmanKodu = new System.Windows.Forms.Label();
            this.txtSorgulaEkipmanKod = new System.Windows.Forms.TextBox();
            this.txtSorgulaSerino = new System.Windows.Forms.TextBox();
            this.btnSorgulaSorgula = new System.Windows.Forms.Button();
            this.lblSorgulaSerino = new System.Windows.Forms.Label();
            this.btnSorgulaTemizle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSorgulaAnasayfayadon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSorgulaEkipmanKodu
            // 
            this.lblSorgulaEkipmanKodu.AutoSize = true;
            this.lblSorgulaEkipmanKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorgulaEkipmanKodu.Location = new System.Drawing.Point(34, 33);
            this.lblSorgulaEkipmanKodu.Name = "lblSorgulaEkipmanKodu";
            this.lblSorgulaEkipmanKodu.Size = new System.Drawing.Size(116, 20);
            this.lblSorgulaEkipmanKodu.TabIndex = 0;
            this.lblSorgulaEkipmanKodu.Text = "Ekipman Kodu:";
            // 
            // txtSorgulaEkipmanKod
            // 
            this.txtSorgulaEkipmanKod.Location = new System.Drawing.Point(174, 32);
            this.txtSorgulaEkipmanKod.Name = "txtSorgulaEkipmanKod";
            this.txtSorgulaEkipmanKod.Size = new System.Drawing.Size(100, 20);
            this.txtSorgulaEkipmanKod.TabIndex = 1;
            // 
            // txtSorgulaSerino
            // 
            this.txtSorgulaSerino.Location = new System.Drawing.Point(174, 76);
            this.txtSorgulaSerino.Name = "txtSorgulaSerino";
            this.txtSorgulaSerino.Size = new System.Drawing.Size(100, 20);
            this.txtSorgulaSerino.TabIndex = 2;
            // 
            // btnSorgulaSorgula
            // 
            this.btnSorgulaSorgula.Location = new System.Drawing.Point(339, 30);
            this.btnSorgulaSorgula.Name = "btnSorgulaSorgula";
            this.btnSorgulaSorgula.Size = new System.Drawing.Size(90, 23);
            this.btnSorgulaSorgula.TabIndex = 3;
            this.btnSorgulaSorgula.Text = "Sorgula";
            this.btnSorgulaSorgula.UseVisualStyleBackColor = true;
            // 
            // lblSorgulaSerino
            // 
            this.lblSorgulaSerino.AutoSize = true;
            this.lblSorgulaSerino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorgulaSerino.Location = new System.Drawing.Point(34, 76);
            this.lblSorgulaSerino.Name = "lblSorgulaSerino";
            this.lblSorgulaSerino.Size = new System.Drawing.Size(112, 20);
            this.lblSorgulaSerino.TabIndex = 4;
            this.lblSorgulaSerino.Text = "Seri Numarası:";
            // 
            // btnSorgulaTemizle
            // 
            this.btnSorgulaTemizle.Location = new System.Drawing.Point(339, 74);
            this.btnSorgulaTemizle.Name = "btnSorgulaTemizle";
            this.btnSorgulaTemizle.Size = new System.Drawing.Size(90, 23);
            this.btnSorgulaTemizle.TabIndex = 5;
            this.btnSorgulaTemizle.Text = "Temizle";
            this.btnSorgulaTemizle.UseVisualStyleBackColor = true;
            this.btnSorgulaTemizle.Click += new System.EventHandler(this.btnSorgulaTemizle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 273);
            this.dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btnSorgulaAnasayfayadon
            // 
            this.btnSorgulaAnasayfayadon.Location = new System.Drawing.Point(703, 440);
            this.btnSorgulaAnasayfayadon.Name = "btnSorgulaAnasayfayadon";
            this.btnSorgulaAnasayfayadon.Size = new System.Drawing.Size(63, 23);
            this.btnSorgulaAnasayfayadon.TabIndex = 47;
            this.btnSorgulaAnasayfayadon.Text = ">>Geri";
            this.btnSorgulaAnasayfayadon.UseVisualStyleBackColor = true;
            this.btnSorgulaAnasayfayadon.Click += new System.EventHandler(this.btnSorgulaAnasayfayadon_Click);
            // 
            // Inquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(798, 475);
            this.Controls.Add(this.btnSorgulaAnasayfayadon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSorgulaTemizle);
            this.Controls.Add(this.lblSorgulaSerino);
            this.Controls.Add(this.btnSorgulaSorgula);
            this.Controls.Add(this.txtSorgulaSerino);
            this.Controls.Add(this.txtSorgulaEkipmanKod);
            this.Controls.Add(this.lblSorgulaEkipmanKodu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Inquire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inquire";
            this.Load += new System.EventHandler(this.Inquire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSorgulaEkipmanKodu;
        private System.Windows.Forms.TextBox txtSorgulaEkipmanKod;
        private System.Windows.Forms.TextBox txtSorgulaSerino;
        private System.Windows.Forms.Button btnSorgulaSorgula;
        private System.Windows.Forms.Label lblSorgulaSerino;
        private System.Windows.Forms.Button btnSorgulaTemizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSorgulaAnasayfayadon;
    }
}