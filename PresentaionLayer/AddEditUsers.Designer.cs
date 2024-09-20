namespace FaisalSport
{
    partial class AddEditUsers
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
            this.TxFirstName = new System.Windows.Forms.TextBox();
            this.TxLastName = new System.Windows.Forms.TextBox();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkProducts = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkLogOut = new System.Windows.Forms.CheckBox();
            this.chkLogsIn = new System.Windows.Forms.CheckBox();
            this.ChkUsers = new System.Windows.Forms.CheckBox();
            this.ChkSales = new System.Windows.Forms.CheckBox();
            this.ChkEmployees = new System.Windows.Forms.CheckBox();
            this.chkClients = new System.Windows.Forms.CheckBox();
            this.LbFrmAddress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxFirstName
            // 
            this.TxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFirstName.Location = new System.Drawing.Point(276, 80);
            this.TxFirstName.Name = "TxFirstName";
            this.TxFirstName.Size = new System.Drawing.Size(213, 28);
            this.TxFirstName.TabIndex = 0;
            this.TxFirstName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxFirstName.TextChanged += new System.EventHandler(this.TxFirstName_TextChanged);
            this.TxFirstName.MouseEnter += new System.EventHandler(this.TxFirstName_MouseEnter);
            // 
            // TxLastName
            // 
            this.TxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLastName.Location = new System.Drawing.Point(276, 151);
            this.TxLastName.Name = "TxLastName";
            this.TxLastName.Size = new System.Drawing.Size(213, 28);
            this.TxLastName.TabIndex = 2;
            this.TxLastName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxLastName.MouseEnter += new System.EventHandler(this.TxLastName_MouseEnter);
            // 
            // TxEmail
            // 
            this.TxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxEmail.Location = new System.Drawing.Point(276, 218);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(213, 28);
            this.TxEmail.TabIndex = 3;
            this.TxEmail.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxEmail.MouseEnter += new System.EventHandler(this.TxEmail_MouseEnter);
            // 
            // TxPassword
            // 
            this.TxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxPassword.Location = new System.Drawing.Point(276, 284);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.Size = new System.Drawing.Size(213, 28);
            this.TxPassword.TabIndex = 4;
            this.TxPassword.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxPassword.MouseEnter += new System.EventHandler(this.TxPassword_MouseEnter);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(306, 444);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(161, 37);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "حفظ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(670, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "الاسم الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "الاسم الاخير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(620, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "البريد الالكتروني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "كلمه السر";
            // 
            // ChkProducts
            // 
            this.ChkProducts.AutoSize = true;
            this.ChkProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkProducts.Location = new System.Drawing.Point(181, 38);
            this.ChkProducts.Name = "ChkProducts";
            this.ChkProducts.Size = new System.Drawing.Size(90, 29);
            this.ChkProducts.TabIndex = 11;
            this.ChkProducts.Tag = "1";
            this.ChkProducts.Text = "المنتجات";
            this.ChkProducts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkLogOut);
            this.groupBox1.Controls.Add(this.chkLogsIn);
            this.groupBox1.Controls.Add(this.ChkUsers);
            this.groupBox1.Controls.Add(this.ChkSales);
            this.groupBox1.Controls.Add(this.ChkEmployees);
            this.groupBox1.Controls.Add(this.chkClients);
            this.groupBox1.Controls.Add(this.ChkProducts);
            this.groupBox1.Location = new System.Drawing.Point(564, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 173);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الصلاحيات";
            // 
            // ChkLogOut
            // 
            this.ChkLogOut.AutoSize = true;
            this.ChkLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkLogOut.Location = new System.Drawing.Point(74, 141);
            this.ChkLogOut.Name = "ChkLogOut";
            this.ChkLogOut.Size = new System.Drawing.Size(145, 29);
            this.ChkLogOut.TabIndex = 17;
            this.ChkLogOut.Tag = "64";
            this.ChkLogOut.Text = "تسجيلات الخروج";
            this.ChkLogOut.UseVisualStyleBackColor = true;
            // 
            // chkLogsIn
            // 
            this.chkLogsIn.AutoSize = true;
            this.chkLogsIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogsIn.Location = new System.Drawing.Point(10, 38);
            this.chkLogsIn.Name = "chkLogsIn";
            this.chkLogsIn.Size = new System.Drawing.Size(141, 29);
            this.chkLogsIn.TabIndex = 16;
            this.chkLogsIn.Tag = "32";
            this.chkLogsIn.Text = "تسجيلات الدخول";
            this.chkLogsIn.UseVisualStyleBackColor = true;
            // 
            // ChkUsers
            // 
            this.ChkUsers.AutoSize = true;
            this.ChkUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkUsers.Location = new System.Drawing.Point(10, 108);
            this.ChkUsers.Name = "ChkUsers";
            this.ChkUsers.Size = new System.Drawing.Size(108, 29);
            this.ChkUsers.TabIndex = 15;
            this.ChkUsers.Tag = "16";
            this.ChkUsers.Text = "المستخدمين";
            this.ChkUsers.UseVisualStyleBackColor = true;
            // 
            // ChkSales
            // 
            this.ChkSales.AutoSize = true;
            this.ChkSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSales.Location = new System.Drawing.Point(10, 73);
            this.ChkSales.Name = "ChkSales";
            this.ChkSales.Size = new System.Drawing.Size(87, 29);
            this.ChkSales.TabIndex = 14;
            this.ChkSales.Tag = "4";
            this.ChkSales.Text = "المبيعات";
            this.ChkSales.UseVisualStyleBackColor = true;
            // 
            // ChkEmployees
            // 
            this.ChkEmployees.AutoSize = true;
            this.ChkEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkEmployees.Location = new System.Drawing.Point(181, 106);
            this.ChkEmployees.Name = "ChkEmployees";
            this.ChkEmployees.Size = new System.Drawing.Size(91, 29);
            this.ChkEmployees.TabIndex = 13;
            this.ChkEmployees.Tag = "8";
            this.ChkEmployees.Text = "الموظفين";
            this.ChkEmployees.UseVisualStyleBackColor = true;
            // 
            // chkClients
            // 
            this.chkClients.AutoSize = true;
            this.chkClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClients.Location = new System.Drawing.Point(181, 71);
            this.chkClients.Name = "chkClients";
            this.chkClients.Size = new System.Drawing.Size(78, 29);
            this.chkClients.TabIndex = 12;
            this.chkClients.Tag = "2";
            this.chkClients.Text = "العملاء";
            this.chkClients.UseVisualStyleBackColor = true;
            // 
            // LbFrmAddress
            // 
            this.LbFrmAddress.AutoSize = true;
            this.LbFrmAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFrmAddress.Location = new System.Drawing.Point(286, 9);
            this.LbFrmAddress.Name = "LbFrmAddress";
            this.LbFrmAddress.Size = new System.Drawing.Size(200, 32);
            this.LbFrmAddress.TabIndex = 13;
            this.LbFrmAddress.Text = "تسجيل مستخدم جديد";
            // 
            // AddEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(866, 565);
            this.Controls.Add(this.LbFrmAddress);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxEmail);
            this.Controls.Add(this.TxLastName);
            this.Controls.Add(this.TxFirstName);
            this.Name = "AddEditUsers";
            this.Text = "AddNewUSer";
            this.Load += new System.EventHandler(this.AddNewUSer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxFirstName;
        private System.Windows.Forms.TextBox TxLastName;
        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChkEmployees;
        private System.Windows.Forms.CheckBox chkClients;
        private System.Windows.Forms.CheckBox ChkUsers;
        private System.Windows.Forms.CheckBox ChkSales;
        private System.Windows.Forms.CheckBox ChkLogOut;
        private System.Windows.Forms.CheckBox chkLogsIn;
        private System.Windows.Forms.Label LbFrmAddress;
    }
}