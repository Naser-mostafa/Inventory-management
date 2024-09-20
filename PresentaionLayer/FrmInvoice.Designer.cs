namespace FaisalSport
{
    partial class FrmInvoice
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
            this.DgvInvoice = new System.Windows.Forms.DataGridView();
            this.btnSavePhoto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.LbInvoiceNumber = new System.Windows.Forms.Label();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.LbSalesManger = new System.Windows.Forms.Label();
            this.LbEmail = new System.Windows.Forms.Label();
            this.LbInvoiceTo = new System.Windows.Forms.Label();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.LbEditINvoice = new System.Windows.Forms.Label();
            this.TxDueDate = new System.Windows.Forms.TextBox();
            this.LbDate = new System.Windows.Forms.Label();
            this.LbPaymentStatue = new System.Windows.Forms.Label();
            this.LbBankAcoount = new System.Windows.Forms.Label();
            this.LbBAnkName = new System.Windows.Forms.Label();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvInvoice
            // 
            this.DgvInvoice.AllowUserToAddRows = false;
            this.DgvInvoice.AllowUserToDeleteRows = false;
            this.DgvInvoice.AllowUserToOrderColumns = true;
            this.DgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvInvoice.Location = new System.Drawing.Point(-2, 248);
            this.DgvInvoice.Name = "DgvInvoice";
            this.DgvInvoice.ReadOnly = true;
            this.DgvInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DgvInvoice.RowHeadersWidth = 51;
            this.DgvInvoice.RowTemplate.Height = 24;
            this.DgvInvoice.Size = new System.Drawing.Size(1061, 530);
            this.DgvInvoice.TabIndex = 14;
            // 
            // btnSavePhoto
            // 
            this.btnSavePhoto.Location = new System.Drawing.Point(915, 0);
            this.btnSavePhoto.Name = "btnSavePhoto";
            this.btnSavePhoto.Size = new System.Drawing.Size(132, 23);
            this.btnSavePhoto.TabIndex = 40;
            this.btnSavePhoto.Text = "Save Pdf File";
            this.btnSavePhoto.UseVisualStyleBackColor = true;
            this.btnSavePhoto.Click += new System.EventHandler(this.btnSavePhoto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogoPicture);
            this.groupBox1.Controls.Add(this.lbCountry);
            this.groupBox1.Controls.Add(this.LbInvoiceNumber);
            this.groupBox1.Controls.Add(this.linkLabel6);
            this.groupBox1.Controls.Add(this.LbSalesManger);
            this.groupBox1.Controls.Add(this.LbEmail);
            this.groupBox1.Controls.Add(this.LbInvoiceTo);
            this.groupBox1.Controls.Add(this.linkLabel5);
            this.groupBox1.Controls.Add(this.linkLabel4);
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.LbEditINvoice);
            this.groupBox1.Controls.Add(this.TxDueDate);
            this.groupBox1.Controls.Add(this.LbDate);
            this.groupBox1.Controls.Add(this.LbPaymentStatue);
            this.groupBox1.Controls.Add(this.LbBankAcoount);
            this.groupBox1.Controls.Add(this.LbBAnkName);
            this.groupBox1.Controls.Add(this.linkLabel11);
            this.groupBox1.Controls.Add(this.linkLabel10);
            this.groupBox1.Controls.Add(this.linkLabel9);
            this.groupBox1.Controls.Add(this.linkLabel8);
            this.groupBox1.Controls.Add(this.linkLabel7);
            this.groupBox1.Controls.Add(this.btnSavePhoto);
            this.groupBox1.Location = new System.Drawing.Point(-2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 210);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(534, 60);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(45, 20);
            this.lbCountry.TabIndex = 72;
            this.lbCountry.Text = ".........";
            // 
            // LbInvoiceNumber
            // 
            this.LbInvoiceNumber.AutoSize = true;
            this.LbInvoiceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInvoiceNumber.Location = new System.Drawing.Point(534, 22);
            this.LbInvoiceNumber.Name = "LbInvoiceNumber";
            this.LbInvoiceNumber.Size = new System.Drawing.Size(45, 20);
            this.LbInvoiceNumber.TabIndex = 71;
            this.LbInvoiceNumber.Text = ".........";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(738, 22);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(65, 16);
            this.linkLabel6.TabIndex = 70;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "رقم الفاتوره";
            // 
            // LbSalesManger
            // 
            this.LbSalesManger.AutoSize = true;
            this.LbSalesManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSalesManger.Location = new System.Drawing.Point(534, 91);
            this.LbSalesManger.Name = "LbSalesManger";
            this.LbSalesManger.Size = new System.Drawing.Size(45, 20);
            this.LbSalesManger.TabIndex = 69;
            this.LbSalesManger.Text = ".........";
            // 
            // LbEmail
            // 
            this.LbEmail.AutoSize = true;
            this.LbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmail.Location = new System.Drawing.Point(534, 131);
            this.LbEmail.Name = "LbEmail";
            this.LbEmail.Size = new System.Drawing.Size(45, 20);
            this.LbEmail.TabIndex = 68;
            this.LbEmail.Text = ".........";
            // 
            // LbInvoiceTo
            // 
            this.LbInvoiceTo.AutoSize = true;
            this.LbInvoiceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbInvoiceTo.Location = new System.Drawing.Point(534, 179);
            this.LbInvoiceTo.Name = "LbInvoiceTo";
            this.LbInvoiceTo.Size = new System.Drawing.Size(45, 20);
            this.LbInvoiceTo.TabIndex = 67;
            this.LbInvoiceTo.Text = ".........";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.Location = new System.Drawing.Point(738, 179);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(65, 20);
            this.linkLabel5.TabIndex = 66;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "فاتوره الي";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.Location = new System.Drawing.Point(702, 131);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(101, 20);
            this.linkLabel4.TabIndex = 65;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "البريد الالكتروني";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.Location = new System.Drawing.Point(694, 91);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(109, 20);
            this.linkLabel3.TabIndex = 64;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "رقم مدير المبيعات";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(763, 60);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(40, 20);
            this.linkLabel2.TabIndex = 63;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "الدوله";
            // 
            // LbEditINvoice
            // 
            this.LbEditINvoice.AutoSize = true;
            this.LbEditINvoice.Location = new System.Drawing.Point(14, 26);
            this.LbEditINvoice.Name = "LbEditINvoice";
            this.LbEditINvoice.Size = new System.Drawing.Size(33, 16);
            this.LbEditINvoice.TabIndex = 62;
            this.LbEditINvoice.Text = "تعديل";
            this.LbEditINvoice.Click += new System.EventHandler(this.LbEditINvoice_Click);
            // 
            // TxDueDate
            // 
            this.TxDueDate.Location = new System.Drawing.Point(118, 73);
            this.TxDueDate.MaxLength = 50;
            this.TxDueDate.Name = "TxDueDate";
            this.TxDueDate.Size = new System.Drawing.Size(173, 22);
            this.TxDueDate.TabIndex = 61;
            // 
            // LbDate
            // 
            this.LbDate.AutoSize = true;
            this.LbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDate.Location = new System.Drawing.Point(163, 30);
            this.LbDate.Name = "LbDate";
            this.LbDate.Size = new System.Drawing.Size(45, 20);
            this.LbDate.TabIndex = 60;
            this.LbDate.Text = ".........";
            // 
            // LbPaymentStatue
            // 
            this.LbPaymentStatue.AutoSize = true;
            this.LbPaymentStatue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPaymentStatue.Location = new System.Drawing.Point(163, 110);
            this.LbPaymentStatue.Name = "LbPaymentStatue";
            this.LbPaymentStatue.Size = new System.Drawing.Size(45, 20);
            this.LbPaymentStatue.TabIndex = 59;
            this.LbPaymentStatue.Text = ".........";
            // 
            // LbBankAcoount
            // 
            this.LbBankAcoount.AutoSize = true;
            this.LbBankAcoount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBankAcoount.Location = new System.Drawing.Point(163, 150);
            this.LbBankAcoount.Name = "LbBankAcoount";
            this.LbBankAcoount.Size = new System.Drawing.Size(45, 20);
            this.LbBankAcoount.TabIndex = 58;
            this.LbBankAcoount.Text = ".........";
            // 
            // LbBAnkName
            // 
            this.LbBAnkName.AutoSize = true;
            this.LbBAnkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbBAnkName.Location = new System.Drawing.Point(163, 179);
            this.LbBAnkName.Name = "LbBAnkName";
            this.LbBAnkName.Size = new System.Drawing.Size(45, 20);
            this.LbBAnkName.TabIndex = 57;
            this.LbBAnkName.Text = ".........";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(384, 183);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(49, 16);
            this.linkLabel11.TabIndex = 56;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "اسم البنك";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(334, 150);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(99, 16);
            this.linkLabel10.TabIndex = 55;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "رقم الحساب البنكي";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(377, 113);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(56, 16);
            this.linkLabel9.TabIndex = 54;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "حاله الدفع";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(342, 73);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(91, 16);
            this.linkLabel8.TabIndex = 53;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "تاريخ_الاستحقاق";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(392, 34);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(41, 16);
            this.linkLabel7.TabIndex = 52;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "التاريخ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(11, 223);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 22);
            this.linkLabel1.TabIndex = 73;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "developer whatsApp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = " 01284092990";
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoPicture.Image = global::FaisalSport.Properties.Resources._11zon_cropped;
            this.LogoPicture.Location = new System.Drawing.Point(832, 44);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(186, 161);
            this.LogoPicture.TabIndex = 98;
            this.LogoPicture.TabStop = false;
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1059, 946);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvInvoice);
            this.Name = "FrmInvoice";
            this.Text = "FrmInvoice";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvInvoice;
        private System.Windows.Forms.Button btnSavePhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Label LbInvoiceNumber;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label LbSalesManger;
        private System.Windows.Forms.Label LbEmail;
        private System.Windows.Forms.Label LbInvoiceTo;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label LbEditINvoice;
        private System.Windows.Forms.TextBox TxDueDate;
        private System.Windows.Forms.Label LbDate;
        private System.Windows.Forms.Label LbPaymentStatue;
        private System.Windows.Forms.Label LbBankAcoount;
        private System.Windows.Forms.Label LbBAnkName;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox LogoPicture;
    }
}