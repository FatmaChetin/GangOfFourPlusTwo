namespace Project.WinUI
{
    partial class Form3
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
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_Aktif = new System.Windows.Forms.Button();
            this.btn_Pasif = new System.Windows.Forms.Button();
            this.lbl_OrderDetails = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrcud_Piece = new System.Windows.Forms.NumericUpDown();
            this.rdo_Field = new System.Windows.Forms.RadioButton();
            this.rdo_Stand = new System.Windows.Forms.RadioButton();
            this.lbl_Orders = new System.Windows.Forms.Label();
            this.lst_Customer = new System.Windows.Forms.ListBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Price = new System.Windows.Forms.Button();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.trb_Field = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grp_EkstraProduct = new System.Windows.Forms.GroupBox();
            this.chk_InvitationCard = new System.Windows.Forms.CheckBox();
            this.ckb_Catering = new System.Windows.Forms.CheckBox();
            this.ckb_Transportation = new System.Windows.Forms.CheckBox();
            this.ckb_StorageArea = new System.Windows.Forms.CheckBox();
            this.ckb_Assembly = new System.Windows.Forms.CheckBox();
            this.ckb_FairHostel = new System.Windows.Forms.CheckBox();
            this.ckb_Waiter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud_Piece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Field)).BeginInit();
            this.grp_EkstraProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(441, 355);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(75, 23);
            this.btn_LogOut.TabIndex = 78;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_Aktif
            // 
            this.btn_Aktif.Location = new System.Drawing.Point(233, 355);
            this.btn_Aktif.Name = "btn_Aktif";
            this.btn_Aktif.Size = new System.Drawing.Size(141, 23);
            this.btn_Aktif.TabIndex = 76;
            this.btn_Aktif.Text = "Organizasyon Active";
            this.btn_Aktif.UseVisualStyleBackColor = true;
            // 
            // btn_Pasif
            // 
            this.btn_Pasif.Location = new System.Drawing.Point(12, 355);
            this.btn_Pasif.Name = "btn_Pasif";
            this.btn_Pasif.Size = new System.Drawing.Size(126, 23);
            this.btn_Pasif.TabIndex = 77;
            this.btn_Pasif.Text = "Event Cancellation";
            this.btn_Pasif.UseVisualStyleBackColor = true;
            // 
            // lbl_OrderDetails
            // 
            this.lbl_OrderDetails.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_OrderDetails.Location = new System.Drawing.Point(12, 288);
            this.lbl_OrderDetails.Name = "lbl_OrderDetails";
            this.lbl_OrderDetails.Size = new System.Drawing.Size(395, 44);
            this.lbl_OrderDetails.TabIndex = 75;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl.Location = new System.Drawing.Point(12, 269);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(86, 16);
            this.lbl.TabIndex = 74;
            this.lbl.Text = "Order Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Last Order";
            // 
            // nmrcud_Piece
            // 
            this.nmrcud_Piece.Location = new System.Drawing.Point(15, 60);
            this.nmrcud_Piece.Name = "nmrcud_Piece";
            this.nmrcud_Piece.Size = new System.Drawing.Size(175, 20);
            this.nmrcud_Piece.TabIndex = 72;
            // 
            // rdo_Field
            // 
            this.rdo_Field.AutoSize = true;
            this.rdo_Field.Location = new System.Drawing.Point(15, 94);
            this.rdo_Field.Name = "rdo_Field";
            this.rdo_Field.Size = new System.Drawing.Size(47, 17);
            this.rdo_Field.TabIndex = 70;
            this.rdo_Field.TabStop = true;
            this.rdo_Field.Text = "Field";
            this.rdo_Field.UseVisualStyleBackColor = true;
            // 
            // rdo_Stand
            // 
            this.rdo_Stand.AutoSize = true;
            this.rdo_Stand.Location = new System.Drawing.Point(15, 36);
            this.rdo_Stand.Name = "rdo_Stand";
            this.rdo_Stand.Size = new System.Drawing.Size(53, 17);
            this.rdo_Stand.TabIndex = 71;
            this.rdo_Stand.TabStop = true;
            this.rdo_Stand.Text = "Stand";
            this.rdo_Stand.UseVisualStyleBackColor = true;
            // 
            // lbl_Orders
            // 
            this.lbl_Orders.BackColor = System.Drawing.Color.DarkCyan;
            this.lbl_Orders.Location = new System.Drawing.Point(12, 201);
            this.lbl_Orders.Name = "lbl_Orders";
            this.lbl_Orders.Size = new System.Drawing.Size(395, 33);
            this.lbl_Orders.TabIndex = 69;
            // 
            // lst_Customer
            // 
            this.lst_Customer.FormattingEnabled = true;
            this.lst_Customer.Location = new System.Drawing.Point(418, 12);
            this.lst_Customer.Name = "lst_Customer";
            this.lst_Customer.Size = new System.Drawing.Size(120, 251);
            this.lst_Customer.TabIndex = 68;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(287, 166);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 23);
            this.btn_Add.TabIndex = 67;
            this.btn_Add.Text = "Add Price";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Price
            // 
            this.btn_Price.Location = new System.Drawing.Point(418, 268);
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(120, 37);
            this.btn_Price.TabIndex = 66;
            this.btn_Price.Text = "Calculat The Price";
            this.btn_Price.UseVisualStyleBackColor = true;
            // 
            // lbl_Price
            // 
            this.lbl_Price.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Price.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Price.Location = new System.Drawing.Point(428, 310);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(100, 22);
            this.lbl_Price.TabIndex = 65;
            // 
            // trb_Field
            // 
            this.trb_Field.Location = new System.Drawing.Point(10, 141);
            this.trb_Field.Maximum = 200;
            this.trb_Field.Name = "trb_Field";
            this.trb_Field.Size = new System.Drawing.Size(180, 45);
            this.trb_Field.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Company Services";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "AreaTrack (m^2)";
            // 
            // grp_EkstraProduct
            // 
            this.grp_EkstraProduct.Controls.Add(this.chk_InvitationCard);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Catering);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Transportation);
            this.grp_EkstraProduct.Controls.Add(this.ckb_StorageArea);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Assembly);
            this.grp_EkstraProduct.Controls.Add(this.ckb_FairHostel);
            this.grp_EkstraProduct.Controls.Add(this.ckb_Waiter);
            this.grp_EkstraProduct.Location = new System.Drawing.Point(203, 43);
            this.grp_EkstraProduct.Name = "grp_EkstraProduct";
            this.grp_EkstraProduct.Size = new System.Drawing.Size(204, 117);
            this.grp_EkstraProduct.TabIndex = 61;
            this.grp_EkstraProduct.TabStop = false;
            this.grp_EkstraProduct.Text = "Additional Services";
            // 
            // chk_InvitationCard
            // 
            this.chk_InvitationCard.AutoSize = true;
            this.chk_InvitationCard.Location = new System.Drawing.Point(105, 66);
            this.chk_InvitationCard.Name = "chk_InvitationCard";
            this.chk_InvitationCard.Size = new System.Drawing.Size(94, 17);
            this.chk_InvitationCard.TabIndex = 9;
            this.chk_InvitationCard.Text = "İnvitation Card";
            this.chk_InvitationCard.UseVisualStyleBackColor = true;
            // 
            // ckb_Catering
            // 
            this.ckb_Catering.AutoSize = true;
            this.ckb_Catering.Location = new System.Drawing.Point(9, 66);
            this.ckb_Catering.Name = "ckb_Catering";
            this.ckb_Catering.Size = new System.Drawing.Size(65, 17);
            this.ckb_Catering.TabIndex = 7;
            this.ckb_Catering.Text = "Catering";
            this.ckb_Catering.UseVisualStyleBackColor = true;
            // 
            // ckb_Transportation
            // 
            this.ckb_Transportation.AutoSize = true;
            this.ckb_Transportation.Location = new System.Drawing.Point(105, 43);
            this.ckb_Transportation.Name = "ckb_Transportation";
            this.ckb_Transportation.Size = new System.Drawing.Size(62, 17);
            this.ckb_Transportation.TabIndex = 8;
            this.ckb_Transportation.Text = "Logistic";
            this.ckb_Transportation.UseVisualStyleBackColor = true;
            // 
            // ckb_StorageArea
            // 
            this.ckb_StorageArea.AutoSize = true;
            this.ckb_StorageArea.Location = new System.Drawing.Point(9, 43);
            this.ckb_StorageArea.Name = "ckb_StorageArea";
            this.ckb_StorageArea.Size = new System.Drawing.Size(88, 17);
            this.ckb_StorageArea.TabIndex = 2;
            this.ckb_StorageArea.Text = "Storage Area";
            this.ckb_StorageArea.UseVisualStyleBackColor = true;
            // 
            // ckb_Assembly
            // 
            this.ckb_Assembly.AutoSize = true;
            this.ckb_Assembly.Location = new System.Drawing.Point(105, 20);
            this.ckb_Assembly.Name = "ckb_Assembly";
            this.ckb_Assembly.Size = new System.Drawing.Size(70, 17);
            this.ckb_Assembly.TabIndex = 3;
            this.ckb_Assembly.Text = "Assembly";
            this.ckb_Assembly.UseVisualStyleBackColor = true;
            // 
            // ckb_FairHostel
            // 
            this.ckb_FairHostel.AutoSize = true;
            this.ckb_FairHostel.Location = new System.Drawing.Point(9, 20);
            this.ckb_FairHostel.Name = "ckb_FairHostel";
            this.ckb_FairHostel.Size = new System.Drawing.Size(76, 17);
            this.ckb_FairHostel.TabIndex = 5;
            this.ckb_FairHostel.Text = "Fair Hostel";
            this.ckb_FairHostel.UseVisualStyleBackColor = true;
            // 
            // ckb_Waiter
            // 
            this.ckb_Waiter.AutoSize = true;
            this.ckb_Waiter.Location = new System.Drawing.Point(9, 89);
            this.ckb_Waiter.Name = "ckb_Waiter";
            this.ckb_Waiter.Size = new System.Drawing.Size(126, 17);
            this.ckb_Waiter.TabIndex = 4;
            this.ckb_Waiter.Text = "Food Servise Worker";
            this.ckb_Waiter.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 391);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Aktif);
            this.Controls.Add(this.btn_Pasif);
            this.Controls.Add(this.lbl_OrderDetails);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nmrcud_Piece);
            this.Controls.Add(this.rdo_Field);
            this.Controls.Add(this.rdo_Stand);
            this.Controls.Add(this.lbl_Orders);
            this.Controls.Add(this.lst_Customer);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Price);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.trb_Field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grp_EkstraProduct);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.nmrcud_Piece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Field)).EndInit();
            this.grp_EkstraProduct.ResumeLayout(false);
            this.grp_EkstraProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_Aktif;
        private System.Windows.Forms.Button btn_Pasif;
        private System.Windows.Forms.Label lbl_OrderDetails;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrcud_Piece;
        private System.Windows.Forms.RadioButton rdo_Field;
        private System.Windows.Forms.RadioButton rdo_Stand;
        private System.Windows.Forms.Label lbl_Orders;
        private System.Windows.Forms.ListBox lst_Customer;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Price;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TrackBar trb_Field;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grp_EkstraProduct;
        private System.Windows.Forms.CheckBox chk_InvitationCard;
        private System.Windows.Forms.CheckBox ckb_Catering;
        private System.Windows.Forms.CheckBox ckb_Transportation;
        private System.Windows.Forms.CheckBox ckb_StorageArea;
        private System.Windows.Forms.CheckBox ckb_Assembly;
        private System.Windows.Forms.CheckBox ckb_FairHostel;
        private System.Windows.Forms.CheckBox ckb_Waiter;
    }
}