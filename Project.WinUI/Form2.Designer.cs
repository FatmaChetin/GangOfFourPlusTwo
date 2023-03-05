namespace Project.WinUI
{
    partial class Form2
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Pasif = new System.Windows.Forms.Button();
            this.lbl_OrderDetails = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrcud_Adet = new System.Windows.Forms.NumericUpDown();
            this.rdo_Field = new System.Windows.Forms.RadioButton();
            this.rdo_Stand = new System.Windows.Forms.RadioButton();
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.lst_Siparis = new System.Windows.Forms.ListBox();
            this.btn_Price = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.trb_Field = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_EkstraProduct = new System.Windows.Forms.GroupBox();
            this.ckb_Catering = new System.Windows.Forms.CheckBox();
            this.ckb_InvitationCard = new System.Windows.Forms.CheckBox();
            this.ckb_Transportation = new System.Windows.Forms.CheckBox();
            this.ckb_StorageArea = new System.Windows.Forms.CheckBox();
            this.ckb_Assembly = new System.Windows.Forms.CheckBox();
            this.ckb_FairHostel = new System.Windows.Forms.CheckBox();
            this.ckb_Waiter = new System.Windows.Forms.CheckBox();
            this.lst_Problem = new System.Windows.Forms.ListBox();
            this.lblm2 = new System.Windows.Forms.Label();
            this.cmbStand = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Field)).BeginInit();
            this.grp_EkstraProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(312, 256);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(178, 35);
            this.btn_Add.TabIndex = 84;
            this.btn_Add.Text = "Sipariş Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(660, 540);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(112, 35);
            this.btn_LogOut.TabIndex = 83;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(345, 586);
            this.btn_Aktif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(212, 35);
            this.btn_Aktif.TabIndex = 82;
            this.btn_Aktif.Text = "Organizasyon Aktif Etme";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            // 
            // btn_Pasif
            // 
            this.btn_Pasif.Location = new System.Drawing.Point(15, 586);
            this.btn_Pasif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Pasif.Name = "btn_Pasif";
            this.btn_Pasif.Size = new System.Drawing.Size(189, 35);
            this.btn_Pasif.TabIndex = 81;
            this.btn_Pasif.Text = "Organizasyon İptali";
            this.btn_Pasif.UseVisualStyleBackColor = true;
            // 
            // lbl_OrderDetails
            // 
            this.lbl_OrderDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_OrderDetails.Location = new System.Drawing.Point(13, 482);
            this.lbl_OrderDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderDetails.Name = "lbl_OrderDetails";
            this.lbl_OrderDetails.Size = new System.Drawing.Size(600, 68);
            this.lbl_OrderDetails.TabIndex = 80;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(13, 453);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(153, 25);
            this.lbl.TabIndex = 79;
            this.lbl.Text = "Sipariş Detaylari";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(13, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 78;
            this.label8.Text = "Sipariş";
            // 
            // nmrcud_Adet
            // 
            this.nmrcud_Adet.Location = new System.Drawing.Point(22, 94);
            this.nmrcud_Adet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmrcud_Adet.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrcud_Adet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrcud_Adet.Name = "nmrcud_Adet";
            this.nmrcud_Adet.Size = new System.Drawing.Size(262, 26);
            this.nmrcud_Adet.TabIndex = 77;
            this.nmrcud_Adet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdo_Field
            // 
            this.rdo_Field.AutoSize = true;
            this.rdo_Field.Location = new System.Drawing.Point(22, 134);
            this.rdo_Field.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_Field.Name = "rdo_Field";
            this.rdo_Field.Size = new System.Drawing.Size(66, 24);
            this.rdo_Field.TabIndex = 76;
            this.rdo_Field.TabStop = true;
            this.rdo_Field.Text = "Alan";
            this.rdo_Field.UseVisualStyleBackColor = true;
            this.rdo_Field.CheckedChanged += new System.EventHandler(this.rdo_Field_CheckedChanged);
            // 
            // rdo_Stand
            // 
            this.rdo_Stand.AutoSize = true;
            this.rdo_Stand.Location = new System.Drawing.Point(22, 57);
            this.rdo_Stand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_Stand.Name = "rdo_Stand";
            this.rdo_Stand.Size = new System.Drawing.Size(77, 24);
            this.rdo_Stand.TabIndex = 75;
            this.rdo_Stand.TabStop = true;
            this.rdo_Stand.Text = "Stand";
            this.rdo_Stand.UseVisualStyleBackColor = true;
            this.rdo_Stand.CheckedChanged += new System.EventHandler(this.rdo_Stand_CheckedChanged);
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Orders.Location = new System.Drawing.Point(16, 378);
            this.lbl_Orders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(600, 51);
            this.lbl_Orders.TabIndex = 74;
            // 
            // lst_Siparis
            // 
            this.lst_Siparis.FormattingEnabled = true;
            this.lst_Siparis.ItemHeight = 20;
            this.lst_Siparis.Location = new System.Drawing.Point(630, 14);
            this.lst_Siparis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Siparis.Name = "lst_Siparis";
            this.lst_Siparis.Size = new System.Drawing.Size(178, 384);
            this.lst_Siparis.TabIndex = 73;
            // 
            // btn_Price
            // 
            this.btn_Price.Location = new System.Drawing.Point(627, 409);
            this.btn_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(180, 57);
            this.btn_Price.TabIndex = 72;
            this.btn_Price.Text = "Fiyati Hesapla";
            this.btn_Price.UseVisualStyleBackColor = true;
            // 
            // lbl_Price
            // 
            this.lbl_Price.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Price.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Price.Location = new System.Drawing.Point(640, 472);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(150, 34);
            this.lbl_Price.TabIndex = 71;
            // 
            // trb_Field
            // 
            this.trb_Field.Location = new System.Drawing.Point(23, 232);
            this.trb_Field.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trb_Field.Maximum = 200;
            this.trb_Field.Name = "trb_Field";
            this.trb_Field.Size = new System.Drawing.Size(270, 69);
            this.trb_Field.TabIndex = 70;
            this.trb_Field.Scroll += new System.EventHandler(this.trb_Field_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 25);
            this.label5.TabIndex = 69;
            this.label5.Text = "Şirket Hizmetleri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "İstenilen Alan m^2 Cinsinden";
            // 
            // grp_EkstraProduct
            // 
            this.grp_EkstraProduct.Controls.Add(this.ckb_Catering);
            this.grp_EkstraProduct.Controls.Add(this.ckb_InvitationCard);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Transportation);
            this.grp_EkstraProduct.Controls.Add(this.ckb_StorageArea);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Assembly);
            this.grp_EkstraProduct.Controls.Add(this.ckb_FairHostel);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Waiter);
            this.grp_EkstraProduct.Location = new System.Drawing.Point(312, 68);
            this.grp_EkstraProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_EkstraProduct.Name = "grp_EkstraProduct";
            this.grp_EkstraProduct.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grp_EkstraProduct.Size = new System.Drawing.Size(306, 180);
            this.grp_EkstraProduct.TabIndex = 67;
            this.grp_EkstraProduct.TabStop = false;
            this.grp_EkstraProduct.Text = "Ek Hizmetler";
            // 
            // ckb_Catering
            // 
            this.ckb_Catering.AutoSize = true;
            this.ckb_Catering.Location = new System.Drawing.Point(16, 102);
            this.ckb_Catering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_Catering.Name = "ckb_Catering";
            this.ckb_Catering.Size = new System.Drawing.Size(95, 24);
            this.ckb_Catering.TabIndex = 7;
            this.ckb_Catering.Text = "Catering";
            this.ckb_Catering.UseVisualStyleBackColor = true;
            // 
            // ckb_InvitationCard
            // 
            this.ckb_InvitationCard.AutoSize = true;
            this.ckb_InvitationCard.Location = new System.Drawing.Point(159, 102);
            this.ckb_InvitationCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_InvitationCard.Name = "ckb_InvitationCard";
            this.ckb_InvitationCard.Size = new System.Drawing.Size(132, 24);
            this.ckb_InvitationCard.TabIndex = 8;
            this.ckb_InvitationCard.Text = "Davetiye Karti";
            this.ckb_InvitationCard.UseVisualStyleBackColor = true;
            // 
            // ckb_Transportation
            // 
            this.ckb_Transportation.AutoSize = true;
            this.ckb_Transportation.Location = new System.Drawing.Point(160, 66);
            this.ckb_Transportation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_Transportation.Name = "ckb_Transportation";
            this.ckb_Transportation.Size = new System.Drawing.Size(85, 24);
            this.ckb_Transportation.TabIndex = 8;
            this.ckb_Transportation.Text = "Nakliye";
            this.ckb_Transportation.UseVisualStyleBackColor = true;
            // 
            // ckb_StorageArea
            // 
            this.ckb_StorageArea.AutoSize = true;
            this.ckb_StorageArea.Location = new System.Drawing.Point(16, 66);
            this.ckb_StorageArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_StorageArea.Name = "ckb_StorageArea";
            this.ckb_StorageArea.Size = new System.Drawing.Size(147, 24);
            this.ckb_StorageArea.TabIndex = 2;
            this.ckb_StorageArea.Text = "Depolama Alanı";
            this.ckb_StorageArea.UseVisualStyleBackColor = true;
            // 
            // ckb_Assembly
            // 
            this.ckb_Assembly.AutoSize = true;
            this.ckb_Assembly.Location = new System.Drawing.Point(160, 31);
            this.ckb_Assembly.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_Assembly.Name = "ckb_Assembly";
            this.ckb_Assembly.Size = new System.Drawing.Size(83, 24);
            this.ckb_Assembly.TabIndex = 3;
            this.ckb_Assembly.Text = "Montaj";
            this.ckb_Assembly.UseVisualStyleBackColor = true;
            // 
            // ckb_FairHostel
            // 
            this.ckb_FairHostel.AutoSize = true;
            this.ckb_FairHostel.Location = new System.Drawing.Point(16, 31);
            this.ckb_FairHostel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_FairHostel.Name = "ckb_FairHostel";
            this.ckb_FairHostel.Size = new System.Drawing.Size(86, 24);
            this.ckb_FairHostel.TabIndex = 5;
            this.ckb_FairHostel.Text = "Hostes";
            this.ckb_FairHostel.UseVisualStyleBackColor = true;
            // 
            // ckb_Waiter
            // 
            this.ckb_Waiter.AutoSize = true;
            this.ckb_Waiter.Location = new System.Drawing.Point(16, 137);
            this.ckb_Waiter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckb_Waiter.Name = "ckb_Waiter";
            this.ckb_Waiter.Size = new System.Drawing.Size(135, 24);
            this.ckb_Waiter.TabIndex = 4;
            this.ckb_Waiter.Text = "Yemek Servisi";
            this.ckb_Waiter.UseVisualStyleBackColor = true;
            // 
            // lst_Problem
            // 
            this.lst_Problem.FormattingEnabled = true;
            this.lst_Problem.ItemHeight = 20;
            this.lst_Problem.Location = new System.Drawing.Point(816, 14);
            this.lst_Problem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lst_Problem.Name = "lst_Problem";
            this.lst_Problem.Size = new System.Drawing.Size(226, 344);
            this.lst_Problem.TabIndex = 80;
            this.lst_Problem.Click += new System.EventHandler(this.lst_Problems_Click);
            // 
            // lblm2
            // 
            this.lblm2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblm2.Location = new System.Drawing.Point(227, 187);
            this.lblm2.Name = "lblm2";
            this.lblm2.Size = new System.Drawing.Size(57, 31);
            this.lblm2.TabIndex = 85;
            // 
            // cmbStand
            // 
            this.cmbStand.FormattingEnabled = true;
            this.cmbStand.Location = new System.Drawing.Point(163, 56);
            this.cmbStand.Name = "cmbStand";
            this.cmbStand.Size = new System.Drawing.Size(121, 28);
            this.cmbStand.TabIndex = 86;
            this.cmbStand.SelectedIndexChanged += new System.EventHandler(this.cmbStand_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "KM";
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(312, 340);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(178, 35);
            this.btn_Sil.TabIndex = 88;
            this.btn_Sil.Text = "Sipariş Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(312, 299);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(178, 35);
            this.btnGuncelle.TabIndex = 88;
            this.btnGuncelle.Text = "Sipariş Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 716);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbStand);
            this.Controls.Add(this.lblm2);
            this.Controls.Add(this.lst_Problem);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.btn_Pasif);
            this.Controls.Add(this.lbl_OrderDetails);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrcud_Adet);
            this.Controls.Add(this.rdo_Field);
            this.Controls.Add(this.rdo_Stand);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lst_Siparis);
            this.Controls.Add(this.btn_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.trb_Field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grp_EkstraProduct);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Field)).EndInit();
            this.grp_EkstraProduct.ResumeLayout(false);
            this.grp_EkstraProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Pasif;
        private System.Windows.Forms.Label lbl_OrderDetails;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrcud_Adet;
        private System.Windows.Forms.RadioButton rdo_Field;
        private System.Windows.Forms.RadioButton rdo_Stand;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListBox lst_Siparis;
        private System.Windows.Forms.Button btn_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TrackBar trb_Field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp_EkstraProduct;
        private System.Windows.Forms.CheckBox ckb_Catering;
        private System.Windows.Forms.CheckBox ckb_InvitationCard;
        private System.Windows.Forms.CheckBox ckb_Transportation;
        private System.Windows.Forms.CheckBox ckb_StorageArea;
        private System.Windows.Forms.CheckBox ckb_Assembly;
        private System.Windows.Forms.CheckBox ckb_FairHostel;
        private System.Windows.Forms.CheckBox ckb_Waiter;
        private System.Windows.Forms.ListBox lst_Problem;
        private System.Windows.Forms.Label lblm2;
        private System.Windows.Forms.ComboBox cmbStand;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}