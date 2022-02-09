namespace BilgeAdam.HMBGR
{
    partial class frmOrderManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderManagement));
            this.btnComplateOrder = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderNote = new System.Windows.Forms.TextBox();
            this.grbFreeExtras = new System.Windows.Forms.GroupBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbCookedOnions = new System.Windows.Forms.CheckBox();
            this.grbExtras = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chbBacon = new System.Windows.Forms.CheckBox();
            this.grbBread = new System.Windows.Forms.GroupBox();
            this.rdbWheatBread = new System.Windows.Forms.RadioButton();
            this.rdbWhiteBread = new System.Windows.Forms.RadioButton();
            this.grbMeat = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb200 = new System.Windows.Forms.RadioButton();
            this.rdb170 = new System.Windows.Forms.RadioButton();
            this.rdb150 = new System.Windows.Forms.RadioButton();
            this.rdb100 = new System.Windows.Forms.RadioButton();
            this.lstGettingReady = new System.Windows.Forms.ListBox();
            this.lstReady = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbFreeExtras.SuspendLayout();
            this.grbExtras.SuspendLayout();
            this.grbBread.SuspendLayout();
            this.grbMeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComplateOrder
            // 
            this.btnComplateOrder.BackColor = System.Drawing.Color.Brown;
            this.btnComplateOrder.Location = new System.Drawing.Point(244, 344);
            this.btnComplateOrder.Name = "btnComplateOrder";
            this.btnComplateOrder.Size = new System.Drawing.Size(123, 65);
            this.btnComplateOrder.TabIndex = 4;
            this.btnComplateOrder.Text = "Siparişi Tamamla";
            this.btnComplateOrder.UseVisualStyleBackColor = false;
            this.btnComplateOrder.Click += new System.EventHandler(this.btnComplateOrder_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Chocolate;
            this.btnCalculate.Location = new System.Drawing.Point(11, 386);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(72, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(89, 386);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.Size = new System.Drawing.Size(132, 23);
            this.txtTotalPayment.TabIndex = 13;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 352);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(205, 23);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Müşteri Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sipariş Notu";
            // 
            // txtOrderNote
            // 
            this.txtOrderNote.Location = new System.Drawing.Point(12, 245);
            this.txtOrderNote.Multiline = true;
            this.txtOrderNote.Name = "txtOrderNote";
            this.txtOrderNote.Size = new System.Drawing.Size(257, 86);
            this.txtOrderNote.TabIndex = 1;
            // 
            // grbFreeExtras
            // 
            this.grbFreeExtras.Controls.Add(this.chbMushrooms);
            this.grbFreeExtras.Controls.Add(this.chbOnion);
            this.grbFreeExtras.Controls.Add(this.chbCookedOnions);
            this.grbFreeExtras.Location = new System.Drawing.Point(223, 12);
            this.grbFreeExtras.Name = "grbFreeExtras";
            this.grbFreeExtras.Size = new System.Drawing.Size(144, 107);
            this.grbFreeExtras.TabIndex = 6;
            this.grbFreeExtras.TabStop = false;
            this.grbFreeExtras.Text = "ÜCRETSİZ EKSTRALAR";
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Location = new System.Drawing.Point(15, 72);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(64, 19);
            this.chbMushrooms.TabIndex = 0;
            this.chbMushrooms.Tag = "Mushrooms";
            this.chbMushrooms.Text = "Mantar";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Location = new System.Drawing.Point(15, 47);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(80, 19);
            this.chbOnion.TabIndex = 0;
            this.chbOnion.Tag = "Onion";
            this.chbOnion.Text = "Çiğ Soğan";
            this.chbOnion.UseVisualStyleBackColor = true;
            // 
            // chbCookedOnions
            // 
            this.chbCookedOnions.AutoSize = true;
            this.chbCookedOnions.Location = new System.Drawing.Point(15, 22);
            this.chbCookedOnions.Name = "chbCookedOnions";
            this.chbCookedOnions.Size = new System.Drawing.Size(96, 19);
            this.chbCookedOnions.TabIndex = 0;
            this.chbCookedOnions.Tag = "CookedOnion";
            this.chbCookedOnions.Text = "Pişmiş Soğan";
            this.chbCookedOnions.UseVisualStyleBackColor = true;
            // 
            // grbExtras
            // 
            this.grbExtras.Controls.Add(this.checkBox1);
            this.grbExtras.Controls.Add(this.chbBacon);
            this.grbExtras.Location = new System.Drawing.Point(223, 125);
            this.grbExtras.Name = "grbExtras";
            this.grbExtras.Size = new System.Drawing.Size(144, 101);
            this.grbExtras.TabIndex = 7;
            this.grbExtras.TabStop = false;
            this.grbExtras.Text = "EKSTRALAR";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "Cheese";
            this.checkBox1.Text = "Peynir( 7TL)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chbBacon
            // 
            this.chbBacon.AutoSize = true;
            this.chbBacon.Location = new System.Drawing.Point(6, 48);
            this.chbBacon.Name = "chbBacon";
            this.chbBacon.Size = new System.Drawing.Size(107, 19);
            this.chbBacon.TabIndex = 0;
            this.chbBacon.Tag = "Bacon";
            this.chbBacon.Text = "Pastırma (12TL)";
            this.chbBacon.UseVisualStyleBackColor = true;
            // 
            // grbBread
            // 
            this.grbBread.Controls.Add(this.rdbWheatBread);
            this.grbBread.Controls.Add(this.rdbWhiteBread);
            this.grbBread.Location = new System.Drawing.Point(12, 125);
            this.grbBread.Name = "grbBread";
            this.grbBread.Size = new System.Drawing.Size(195, 101);
            this.grbBread.TabIndex = 8;
            this.grbBread.TabStop = false;
            this.grbBread.Text = "EKMEK";
            // 
            // rdbWheatBread
            // 
            this.rdbWheatBread.AutoSize = true;
            this.rdbWheatBread.Location = new System.Drawing.Point(18, 60);
            this.rdbWheatBread.Name = "rdbWheatBread";
            this.rdbWheatBread.Size = new System.Drawing.Size(163, 19);
            this.rdbWheatBread.TabIndex = 0;
            this.rdbWheatBread.TabStop = true;
            this.rdbWheatBread.Tag = "Wheat";
            this.rdbWheatBread.Text = "Tam Buğday Ekmek (12TL)";
            this.rdbWheatBread.UseVisualStyleBackColor = true;
            // 
            // rdbWhiteBread
            // 
            this.rdbWhiteBread.AutoSize = true;
            this.rdbWhiteBread.Checked = true;
            this.rdbWhiteBread.Location = new System.Drawing.Point(18, 22);
            this.rdbWhiteBread.Name = "rdbWhiteBread";
            this.rdbWhiteBread.Size = new System.Drawing.Size(128, 19);
            this.rdbWhiteBread.TabIndex = 0;
            this.rdbWhiteBread.TabStop = true;
            this.rdbWhiteBread.Tag = "White";
            this.rdbWhiteBread.Text = "Beyaz Ekmek (10TL)";
            this.rdbWhiteBread.UseVisualStyleBackColor = true;
            // 
            // grbMeat
            // 
            this.grbMeat.Controls.Add(this.radioButton1);
            this.grbMeat.Controls.Add(this.rdb200);
            this.grbMeat.Controls.Add(this.rdb170);
            this.grbMeat.Controls.Add(this.rdb150);
            this.grbMeat.Controls.Add(this.rdb100);
            this.grbMeat.Location = new System.Drawing.Point(12, 12);
            this.grbMeat.Name = "grbMeat";
            this.grbMeat.Size = new System.Drawing.Size(195, 107);
            this.grbMeat.TabIndex = 9;
            this.grbMeat.TabStop = false;
            this.grbMeat.Text = "ET";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(101, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "_200";
            this.radioButton1.Text = "200gr (32TL)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdb200
            // 
            this.rdb200.AutoSize = true;
            this.rdb200.Location = new System.Drawing.Point(101, 52);
            this.rdb200.Name = "rdb200";
            this.rdb200.Size = new System.Drawing.Size(89, 19);
            this.rdb200.TabIndex = 0;
            this.rdb200.Tag = "_250";
            this.rdb200.Text = "250gr (40TL)";
            this.rdb200.UseVisualStyleBackColor = true;
            // 
            // rdb170
            // 
            this.rdb170.AutoSize = true;
            this.rdb170.Location = new System.Drawing.Point(4, 77);
            this.rdb170.Name = "rdb170";
            this.rdb170.Size = new System.Drawing.Size(89, 19);
            this.rdb170.TabIndex = 0;
            this.rdb170.Tag = "_170";
            this.rdb170.Text = "170gr (30TL)";
            this.rdb170.UseVisualStyleBackColor = true;
            // 
            // rdb150
            // 
            this.rdb150.AutoSize = true;
            this.rdb150.Location = new System.Drawing.Point(4, 52);
            this.rdb150.Name = "rdb150";
            this.rdb150.Size = new System.Drawing.Size(89, 19);
            this.rdb150.TabIndex = 0;
            this.rdb150.Tag = "_150";
            this.rdb150.Text = "150gr (27TL)";
            this.rdb150.UseVisualStyleBackColor = true;
            // 
            // rdb100
            // 
            this.rdb100.AutoSize = true;
            this.rdb100.Location = new System.Drawing.Point(6, 27);
            this.rdb100.Name = "rdb100";
            this.rdb100.Size = new System.Drawing.Size(89, 19);
            this.rdb100.TabIndex = 0;
            this.rdb100.Tag = "_100";
            this.rdb100.Text = "100gr (20TL)";
            this.rdb100.UseVisualStyleBackColor = true;
            // 
            // lstGettingReady
            // 
            this.lstGettingReady.FormattingEnabled = true;
            this.lstGettingReady.ItemHeight = 15;
            this.lstGettingReady.Location = new System.Drawing.Point(373, 27);
            this.lstGettingReady.Name = "lstGettingReady";
            this.lstGettingReady.Size = new System.Drawing.Size(199, 199);
            this.lstGettingReady.TabIndex = 17;
            // 
            // lstReady
            // 
            this.lstReady.FormattingEnabled = true;
            this.lstReady.ItemHeight = 15;
            this.lstReady.Location = new System.Drawing.Point(587, 27);
            this.lstReady.Name = "lstReady";
            this.lstReady.Size = new System.Drawing.Size(175, 199);
            this.lstReady.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(587, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "HAZIR!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(373, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hazırlanıyor";
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.DarkGreen;
            this.btnDelivery.Location = new System.Drawing.Point(524, 260);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(127, 35);
            this.btnDelivery.TabIndex = 5;
            this.btnDelivery.Text = "Teslim Et";
            this.btnDelivery.UseVisualStyleBackColor = false;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(657, 260);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(104, 35);
            this.txtBalance.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(657, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Toplam Kazanç";
            // 
            // frmOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 425);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstReady);
            this.Controls.Add(this.lstGettingReady);
            this.Controls.Add(this.btnComplateOrder);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalPayment);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrderNote);
            this.Controls.Add(this.grbFreeExtras);
            this.Controls.Add(this.grbExtras);
            this.Controls.Add(this.grbBread);
            this.Controls.Add(this.grbMeat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderManagement";
            this.Text = "Sipariş Yönetim Paneli";
            this.grbFreeExtras.ResumeLayout(false);
            this.grbFreeExtras.PerformLayout();
            this.grbExtras.ResumeLayout(false);
            this.grbExtras.PerformLayout();
            this.grbBread.ResumeLayout(false);
            this.grbBread.PerformLayout();
            this.grbMeat.ResumeLayout(false);
            this.grbMeat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnComplateOrder;
        private Button btnCalculate;
        private TextBox txtTotalPayment;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private TextBox txtOrderNote;
        private GroupBox grbFreeExtras;
        private CheckBox chbMushrooms;
        private CheckBox chbOnion;
        private CheckBox chbCookedOnions;
        private GroupBox grbExtras;
        private CheckBox checkBox1;
        private CheckBox chbBacon;
        private GroupBox grbBread;
        private RadioButton rdbWheatBread;
        private RadioButton rdbWhiteBread;
        private GroupBox grbMeat;
        private RadioButton rdb200;
        private RadioButton rdb170;
        private RadioButton rdb150;
        private RadioButton rdb100;
        private RadioButton radioButton1;
        private ListBox lstGettingReady;
        private ListBox lstReady;
        private Label label3;
        private Label label4;
        private Button btnDelivery;
        private TextBox txtBalance;
        private Label label5;
    }
}