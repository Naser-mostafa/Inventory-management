namespace FaisalSport
{
    partial class AddNewAdnEditProduct
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
            this.LbAddAndEdit = new System.Windows.Forms.Label();
            this.TxProductName = new System.Windows.Forms.TextBox();
            this.TxQuantity = new System.Windows.Forms.TextBox();
            this.TxBuimgPrice = new System.Windows.Forms.TextBox();
            this.txSellingPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbProductColor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbProductSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdutPicture = new System.Windows.Forms.PictureBox();
            this.LbAddProductPicture = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnSaveNewProduct = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LbRemoveProductPicturer = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAddAndEdit
            // 
            this.LbAddAndEdit.AutoSize = true;
            this.LbAddAndEdit.Font = new System.Drawing.Font("Yu Gothic UI", 24F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddAndEdit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LbAddAndEdit.Location = new System.Drawing.Point(368, 27);
            this.LbAddAndEdit.Name = "LbAddAndEdit";
            this.LbAddAndEdit.Size = new System.Drawing.Size(277, 54);
            this.LbAddAndEdit.TabIndex = 0;
            this.LbAddAndEdit.Text = "اضافه منتج جديد";
            // 
            // TxProductName
            // 
            this.TxProductName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxProductName.Location = new System.Drawing.Point(342, 142);
            this.TxProductName.Name = "TxProductName";
            this.TxProductName.Size = new System.Drawing.Size(313, 38);
            this.TxProductName.TabIndex = 1;
            this.TxProductName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxProductName.TextChanged += new System.EventHandler(this.TxProductName_TextChanged);
            this.TxProductName.MouseEnter += new System.EventHandler(this.TxProductName_MouseEnter);
            // 
            // TxQuantity
            // 
            this.TxQuantity.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxQuantity.Location = new System.Drawing.Point(342, 201);
            this.TxQuantity.Name = "TxQuantity";
            this.TxQuantity.Size = new System.Drawing.Size(313, 38);
            this.TxQuantity.TabIndex = 2;
            this.TxQuantity.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxQuantity.MouseEnter += new System.EventHandler(this.TxQuantity_MouseEnter);
            // 
            // TxBuimgPrice
            // 
            this.TxBuimgPrice.BackColor = System.Drawing.SystemColors.GrayText;
            this.TxBuimgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBuimgPrice.Location = new System.Drawing.Point(342, 258);
            this.TxBuimgPrice.Name = "TxBuimgPrice";
            this.TxBuimgPrice.Size = new System.Drawing.Size(313, 38);
            this.TxBuimgPrice.TabIndex = 3;
            this.TxBuimgPrice.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxBuimgPrice.MouseEnter += new System.EventHandler(this.TxBuimgPrice_MouseEnter);
            // 
            // txSellingPrice
            // 
            this.txSellingPrice.BackColor = System.Drawing.SystemColors.GrayText;
            this.txSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSellingPrice.Location = new System.Drawing.Point(342, 316);
            this.txSellingPrice.Name = "txSellingPrice";
            this.txSellingPrice.Size = new System.Drawing.Size(313, 38);
            this.txSellingPrice.TabIndex = 4;
            this.txSellingPrice.Text = "لا يسمح ان يكون الحقل فارغ";
            this.txSellingPrice.MouseEnter += new System.EventHandler(this.txSellingPrice_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "ادخل اسم المنتج";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "ادخل الكميه";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "ادخل سعر شرائك للقطعه الواحده";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "ادخل سعر بيعك للقطعه الواحده";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CbProductColor
            // 
            this.CbProductColor.BackColor = System.Drawing.SystemColors.GrayText;
            this.CbProductColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProductColor.FormattingEnabled = true;
            this.CbProductColor.Location = new System.Drawing.Point(342, 377);
            this.CbProductColor.Name = "CbProductColor";
            this.CbProductColor.Size = new System.Drawing.Size(313, 39);
            this.CbProductColor.TabIndex = 13;
            this.CbProductColor.Text = "لا يسمح ان يكون الحقل فارغ";
            this.CbProductColor.MouseEnter += new System.EventHandler(this.CbProductColor_MouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(928, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "اختر اللون ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CbProductSize
            // 
            this.CbProductSize.BackColor = System.Drawing.SystemColors.GrayText;
            this.CbProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbProductSize.FormattingEnabled = true;
            this.CbProductSize.Location = new System.Drawing.Point(342, 436);
            this.CbProductSize.Name = "CbProductSize";
            this.CbProductSize.Size = new System.Drawing.Size(313, 39);
            this.CbProductSize.TabIndex = 15;
            this.CbProductSize.Text = "لا يسمح ان يكون الحقل فارغ";
            this.CbProductSize.MouseEnter += new System.EventHandler(this.CbProductSize_MouseEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(919, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "اختر المقاس";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProdutPicture
            // 
            this.ProdutPicture.Location = new System.Drawing.Point(12, 142);
            this.ProdutPicture.Name = "ProdutPicture";
            this.ProdutPicture.Size = new System.Drawing.Size(312, 384);
            this.ProdutPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProdutPicture.TabIndex = 17;
            this.ProdutPicture.TabStop = false;
            // 
            // LbAddProductPicture
            // 
            this.LbAddProductPicture.AutoSize = true;
            this.LbAddProductPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddProductPicture.Location = new System.Drawing.Point(12, 98);
            this.LbAddProductPicture.Name = "LbAddProductPicture";
            this.LbAddProductPicture.Size = new System.Drawing.Size(137, 25);
            this.LbAddProductPicture.TabIndex = 18;
            this.LbAddProductPicture.TabStop = true;
            this.LbAddProductPicture.Text = "أضف صوره المنتج";
            this.LbAddProductPicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectProductPicture_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnSaveNewProduct
            // 
            this.BtnSaveNewProduct.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnSaveNewProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveNewProduct.Location = new System.Drawing.Point(401, 567);
            this.BtnSaveNewProduct.Name = "BtnSaveNewProduct";
            this.BtnSaveNewProduct.Size = new System.Drawing.Size(192, 48);
            this.BtnSaveNewProduct.TabIndex = 19;
            this.BtnSaveNewProduct.Text = "حفظ";
            this.BtnSaveNewProduct.UseVisualStyleBackColor = false;
            this.BtnSaveNewProduct.Click += new System.EventHandler(this.BtnSaveNewProduct_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LbRemoveProductPicturer
            // 
            this.LbRemoveProductPicturer.AutoSize = true;
            this.LbRemoveProductPicturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRemoveProductPicturer.Location = new System.Drawing.Point(209, 98);
            this.LbRemoveProductPicturer.Name = "LbRemoveProductPicturer";
            this.LbRemoveProductPicturer.Size = new System.Drawing.Size(100, 25);
            this.LbRemoveProductPicturer.TabIndex = 20;
            this.LbRemoveProductPicturer.TabStop = true;
            this.LbRemoveProductPicturer.Text = "حذف الصوره";
            this.LbRemoveProductPicturer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbRemoveProductPicturer_LinkClicked);
            // 
            // AddNewAdnEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1051, 637);
            this.Controls.Add(this.LbRemoveProductPicturer);
            this.Controls.Add(this.BtnSaveNewProduct);
            this.Controls.Add(this.LbAddProductPicture);
            this.Controls.Add(this.ProdutPicture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CbProductSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CbProductColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txSellingPrice);
            this.Controls.Add(this.TxBuimgPrice);
            this.Controls.Add(this.TxQuantity);
            this.Controls.Add(this.TxProductName);
            this.Controls.Add(this.LbAddAndEdit);
            this.Name = "AddNewAdnEditProduct";
            this.Text = "AddNewAdnEditProduct";
            this.Load += new System.EventHandler(this.AddNewAdnEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAddAndEdit;
        private System.Windows.Forms.TextBox TxProductName;
        private System.Windows.Forms.TextBox TxQuantity;
        private System.Windows.Forms.TextBox TxBuimgPrice;
        private System.Windows.Forms.TextBox txSellingPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbProductColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbProductSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox ProdutPicture;
        private System.Windows.Forms.LinkLabel LbAddProductPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnSaveNewProduct;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.LinkLabel LbRemoveProductPicturer;
    }
}