namespace FaisalSport
{
    partial class FrmAddEditCustmor
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
            this.TxFirstName = new System.Windows.Forms.TextBox();
            this.TxLastName = new System.Windows.Forms.TextBox();
            this.TxPjone = new System.Windows.Forms.TextBox();
            this.TxCountryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbAddEditClient = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSaveClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxFirstName
            // 
            this.TxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFirstName.Location = new System.Drawing.Point(256, 153);
            this.TxFirstName.Name = "TxFirstName";
            this.TxFirstName.Size = new System.Drawing.Size(204, 30);
            this.TxFirstName.TabIndex = 0;
            this.TxFirstName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxFirstName.MouseEnter += new System.EventHandler(this.TxFirstName_MouseEnter);
            // 
            // TxLastName
            // 
            this.TxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLastName.Location = new System.Drawing.Point(256, 209);
            this.TxLastName.Name = "TxLastName";
            this.TxLastName.Size = new System.Drawing.Size(204, 30);
            this.TxLastName.TabIndex = 1;
            this.TxLastName.Text = "مسموح ان يكون فارغ";
            this.TxLastName.MouseEnter += new System.EventHandler(this.TxLastName_MouseEnter);
            // 
            // TxPjone
            // 
            this.TxPjone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPjone.Location = new System.Drawing.Point(256, 264);
            this.TxPjone.Name = "TxPjone";
            this.TxPjone.Size = new System.Drawing.Size(204, 30);
            this.TxPjone.TabIndex = 2;
            this.TxPjone.Text = "مسموح ان يكون فارغ";
            this.TxPjone.MouseEnter += new System.EventHandler(this.TxPjone_MouseEnter);
            // 
            // TxCountryName
            // 
            this.TxCountryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxCountryName.Location = new System.Drawing.Point(256, 315);
            this.TxCountryName.Name = "TxCountryName";
            this.TxCountryName.Size = new System.Drawing.Size(204, 30);
            this.TxCountryName.TabIndex = 3;
            this.TxCountryName.Text = "مسموح ان يكون فارغ";
            this.TxCountryName.MouseEnter += new System.EventHandler(this.TxCountryName_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(619, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ادخل الاسم الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(619, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "ادخل الاسم الاخير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "ادخل رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "ادخل اسم البلد";
            // 
            // LbAddEditClient
            // 
            this.LbAddEditClient.AutoSize = true;
            this.LbAddEditClient.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddEditClient.Location = new System.Drawing.Point(247, 21);
            this.LbAddEditClient.Name = "LbAddEditClient";
            this.LbAddEditClient.Size = new System.Drawing.Size(287, 52);
            this.LbAddEditClient.TabIndex = 8;
            this.LbAddEditClient.Text = "اضافه عميل جديد";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BtnSaveClient
            // 
            this.BtnSaveClient.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveClient.Location = new System.Drawing.Point(290, 390);
            this.BtnSaveClient.Name = "BtnSaveClient";
            this.BtnSaveClient.Size = new System.Drawing.Size(150, 34);
            this.BtnSaveClient.TabIndex = 9;
            this.BtnSaveClient.Text = "Save";
            this.BtnSaveClient.UseVisualStyleBackColor = false;
            this.BtnSaveClient.Click += new System.EventHandler(this.BtnSaveClient_Click);
            // 
            // FrmAddEditCustmor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(804, 509);
            this.Controls.Add(this.BtnSaveClient);
            this.Controls.Add(this.LbAddEditClient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxCountryName);
            this.Controls.Add(this.TxPjone);
            this.Controls.Add(this.TxLastName);
            this.Controls.Add(this.TxFirstName);
            this.Name = "FrmAddEditCustmor";
            this.Text = "FrmAddNewcustmor";
            this.Load += new System.EventHandler(this.FrmAddEditCustmor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxFirstName;
        private System.Windows.Forms.TextBox TxLastName;
        private System.Windows.Forms.TextBox TxPjone;
        private System.Windows.Forms.TextBox TxCountryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbAddEditClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button BtnSaveClient;
    }
}