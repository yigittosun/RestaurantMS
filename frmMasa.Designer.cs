﻿namespace Yigit_Cafe
{
    partial class frmMasa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasa));
            this.btnUrunler = new System.Windows.Forms.Button();
            this.lstUrunler = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lstSepet = new System.Windows.Forms.ListView();
            this.grpSepet = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.grpUrun = new System.Windows.Forms.GroupBox();
            this.btnHesapOde = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtParaUstu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVerilenMiktar = new System.Windows.Forms.TextBox();
            this.comboOdemeTuru = new System.Windows.Forms.ComboBox();
            this.grpSepet.SuspendLayout();
            this.grpUrun.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.BurlyWood;
            this.btnUrunler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunler.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUrunler.Location = new System.Drawing.Point(12, 144);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(23, 247);
            this.btnUrunler.TabIndex = 0;
            this.btnUrunler.Text = "ITEMS   PURCHASED";
            this.btnUrunler.UseVisualStyleBackColor = false;
            // 
            // lstUrunler
            // 
            this.lstUrunler.BackColor = System.Drawing.Color.BurlyWood;
            this.lstUrunler.LargeImageList = this.imageList1;
            this.lstUrunler.Location = new System.Drawing.Point(6, 14);
            this.lstUrunler.MultiSelect = false;
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(272, 511);
            this.lstUrunler.TabIndex = 1;
            this.lstUrunler.UseCompatibleStateImageBehavior = false;
            this.lstUrunler.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstUrunler_ItemSelectionChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(48, 48);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lstSepet
            // 
            this.lstSepet.BackColor = System.Drawing.Color.BurlyWood;
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSepet.LargeImageList = this.imageList1;
            this.lstSepet.Location = new System.Drawing.Point(3, 16);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(236, 506);
            this.lstSepet.TabIndex = 4;
            this.lstSepet.UseCompatibleStateImageBehavior = false;
            this.lstSepet.DoubleClick += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // grpSepet
            // 
            this.grpSepet.BackColor = System.Drawing.Color.BurlyWood;
            this.grpSepet.Controls.Add(this.lstSepet);
            this.grpSepet.Location = new System.Drawing.Point(390, 15);
            this.grpSepet.Name = "grpSepet";
            this.grpSepet.Size = new System.Drawing.Size(242, 525);
            this.grpSepet.TabIndex = 6;
            this.grpSepet.TabStop = false;
            this.grpSepet.Text = "Shopping Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Amount:";
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.White;
            this.txtToplam.Enabled = false;
            this.txtToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(143, 34);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(73, 23);
            this.txtToplam.TabIndex = 5;
            this.txtToplam.Text = "0,0";
            this.txtToplam.TextChanged += new System.EventHandler(this.txtToplam_TextChanged);
            // 
            // grpUrun
            // 
            this.grpUrun.BackColor = System.Drawing.Color.BurlyWood;
            this.grpUrun.Controls.Add(this.lstUrunler);
            this.grpUrun.Location = new System.Drawing.Point(46, 9);
            this.grpUrun.Name = "grpUrun";
            this.grpUrun.Size = new System.Drawing.Size(290, 531);
            this.grpUrun.TabIndex = 7;
            this.grpUrun.TabStop = false;
            // 
            // btnHesapOde
            // 
            this.btnHesapOde.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapOde.Image = ((System.Drawing.Image)(resources.GetObject("btnHesapOde.Image")));
            this.btnHesapOde.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHesapOde.Location = new System.Drawing.Point(70, 232);
            this.btnHesapOde.Name = "btnHesapOde";
            this.btnHesapOde.Size = new System.Drawing.Size(146, 40);
            this.btnHesapOde.TabIndex = 8;
            this.btnHesapOde.Text = "PAY ACCOUNT!";
            this.btnHesapOde.UseVisualStyleBackColor = true;
            this.btnHesapOde.Click += new System.EventHandler(this.btnHesapOde_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Payment Type:";
            this.label3.Visible = false;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.Black;
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.Location = new System.Drawing.Point(342, 213);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(40, 40);
            this.btnUrunEkle.TabIndex = 11;
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Black;
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.Location = new System.Drawing.Point(342, 278);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(40, 40);
            this.btnUrunSil.TabIndex = 11;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.lstSepet_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtParaUstu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtVerilenMiktar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtToplam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnHesapOde);
            this.groupBox1.Controls.Add(this.comboOdemeTuru);
            this.groupBox1.Location = new System.Drawing.Point(648, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 525);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Change:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(222, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "₺";
            // 
            // txtParaUstu
            // 
            this.txtParaUstu.BackColor = System.Drawing.Color.Red;
            this.txtParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParaUstu.ForeColor = System.Drawing.Color.White;
            this.txtParaUstu.Location = new System.Drawing.Point(143, 94);
            this.txtParaUstu.Name = "txtParaUstu";
            this.txtParaUstu.ReadOnly = true;
            this.txtParaUstu.Size = new System.Drawing.Size(73, 23);
            this.txtParaUstu.TabIndex = 14;
            this.txtParaUstu.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount Given:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(222, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "₺";
            // 
            // txtVerilenMiktar
            // 
            this.txtVerilenMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVerilenMiktar.Location = new System.Drawing.Point(143, 65);
            this.txtVerilenMiktar.Name = "txtVerilenMiktar";
            this.txtVerilenMiktar.Size = new System.Drawing.Size(73, 23);
            this.txtVerilenMiktar.TabIndex = 11;
            this.txtVerilenMiktar.Text = "0";
            this.txtVerilenMiktar.TextChanged += new System.EventHandler(this.txtVerilenMiktar_TextChanged);
            this.txtVerilenMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVerilenMiktar_KeyPress);
            // 
            // comboOdemeTuru
            // 
            this.comboOdemeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdemeTuru.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboOdemeTuru.FormattingEnabled = true;
            this.comboOdemeTuru.Location = new System.Drawing.Point(132, 129);
            this.comboOdemeTuru.Name = "comboOdemeTuru";
            this.comboOdemeTuru.Size = new System.Drawing.Size(127, 24);
            this.comboOdemeTuru.TabIndex = 9;
            this.comboOdemeTuru.Visible = false;
            this.comboOdemeTuru.SelectedIndexChanged += new System.EventHandler(this.comboOdemeTuru_SelectedIndexChanged);
            // 
            // frmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.grpUrun);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.grpSepet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Informatıion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMasa_FormClosing);
            this.Load += new System.EventHandler(this.frmMasa_Load);
            this.grpSepet.ResumeLayout(false);
            this.grpUrun.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.ListView lstUrunler;
        private System.Windows.Forms.ListView lstSepet;
        private System.Windows.Forms.GroupBox grpSepet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapOde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtParaUstu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVerilenMiktar;
        private System.Windows.Forms.ComboBox comboOdemeTuru;
    }
}