namespace FaisalSport
{
    partial class FrmAddNewEmployee
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
            this.LbAddEditEmployee = new System.Windows.Forms.Label();
            this.TxLastName = new System.Windows.Forms.TextBox();
            this.DtpDAteOfBirth = new System.Windows.Forms.DateTimePicker();
            this.CbCountries = new System.Windows.Forms.ComboBox();
            this.CbDepartments = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.ChkDtpStatue = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxFirstName = new System.Windows.Forms.TextBox();
            this.TxSalary = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbAddEditEmployee
            // 
            this.LbAddEditEmployee.AutoSize = true;
            this.LbAddEditEmployee.Font = new System.Drawing.Font("Microsoft Uighur", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbAddEditEmployee.Location = new System.Drawing.Point(388, 30);
            this.LbAddEditEmployee.Name = "LbAddEditEmployee";
            this.LbAddEditEmployee.Size = new System.Drawing.Size(92, 48);
            this.LbAddEditEmployee.TabIndex = 0;
            this.LbAddEditEmployee.Text = "label1";
            // 
            // TxLastName
            // 
            this.TxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxLastName.Location = new System.Drawing.Point(259, 180);
            this.TxLastName.Name = "TxLastName";
            this.TxLastName.Size = new System.Drawing.Size(331, 30);
            this.TxLastName.TabIndex = 2;
            this.TxLastName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxLastName.MouseEnter += new System.EventHandler(this.TxLastName_MouseEnter);
            // 
            // DtpDAteOfBirth
            // 
            this.DtpDAteOfBirth.Cursor = System.Windows.Forms.Cursors.Default;
            this.DtpDAteOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDAteOfBirth.Location = new System.Drawing.Point(259, 240);
            this.DtpDAteOfBirth.Name = "DtpDAteOfBirth";
            this.DtpDAteOfBirth.Size = new System.Drawing.Size(331, 30);
            this.DtpDAteOfBirth.TabIndex = 3;
            this.DtpDAteOfBirth.Value = new System.DateTime(2024, 5, 1, 0, 0, 0, 0);
            // 
            // CbCountries
            // 
            this.CbCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCountries.FormattingEnabled = true;
            this.CbCountries.Location = new System.Drawing.Point(259, 298);
            this.CbCountries.Name = "CbCountries";
            this.CbCountries.Size = new System.Drawing.Size(331, 33);
            this.CbCountries.TabIndex = 4;
            this.CbCountries.Text = "لا يسمح ان يكون الحقل فارغ";
            this.CbCountries.MouseEnter += new System.EventHandler(this.CbCountries_MouseEnter);
            // 
            // CbDepartments
            // 
            this.CbDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbDepartments.FormattingEnabled = true;
            this.CbDepartments.Location = new System.Drawing.Point(259, 360);
            this.CbDepartments.Name = "CbDepartments";
            this.CbDepartments.Size = new System.Drawing.Size(331, 33);
            this.CbDepartments.TabIndex = 5;
            this.CbDepartments.Text = "لا يسمح ان يكون الحقل فارغ";
            this.CbDepartments.MouseEnter += new System.EventHandler(this.CbDepartments_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(761, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "الاسم الاول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(761, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "الاسم الاخير";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(761, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "تاريخ الميلاد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(816, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "البلد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "التخصص";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(360, 472);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ChkDtpStatue
            // 
            this.ChkDtpStatue.AutoSize = true;
            this.ChkDtpStatue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkDtpStatue.Location = new System.Drawing.Point(194, 247);
            this.ChkDtpStatue.Name = "ChkDtpStatue";
            this.ChkDtpStatue.Size = new System.Drawing.Size(59, 24);
            this.ChkDtpStatue.TabIndex = 12;
            this.ChkDtpStatue.Text = "تفعيل";
            this.ChkDtpStatue.UseVisualStyleBackColor = true;
            this.ChkDtpStatue.CheckedChanged += new System.EventHandler(this.ChkDtpStatue_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TxFirstName
            // 
            this.TxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxFirstName.Location = new System.Drawing.Point(259, 127);
            this.TxFirstName.Name = "TxFirstName";
            this.TxFirstName.Size = new System.Drawing.Size(331, 30);
            this.TxFirstName.TabIndex = 1;
            this.TxFirstName.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxFirstName.TextChanged += new System.EventHandler(this.TxFirstName_TextChanged);
            this.TxFirstName.MouseEnter += new System.EventHandler(this.TxFirstName_MouseEnter);
            // 
            // TxSalary
            // 
            this.TxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSalary.Location = new System.Drawing.Point(259, 417);
            this.TxSalary.Name = "TxSalary";
            this.TxSalary.Size = new System.Drawing.Size(331, 30);
            this.TxSalary.TabIndex = 6;
            this.TxSalary.Text = "لا يسمح ان يكون الحقل فارغ";
            this.TxSalary.TextChanged += new System.EventHandler(this.TxSalary_TextChanged);
            this.TxSalary.MouseEnter += new System.EventHandler(this.TxSalary_MouseEnter);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(803, 422);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 25);
            this.label.TabIndex = 15;
            this.label.Text = "الراتب";
            // 
            // FrmAddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TxSalary);
            this.Controls.Add(this.TxFirstName);
            this.Controls.Add(this.ChkDtpStatue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbDepartments);
            this.Controls.Add(this.CbCountries);
            this.Controls.Add(this.DtpDAteOfBirth);
            this.Controls.Add(this.TxLastName);
            this.Controls.Add(this.LbAddEditEmployee);
            this.Name = "FrmAddNewEmployee";
            this.Text = "FrmAddNewEmployee";
            this.Load += new System.EventHandler(this.FrmAddNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbAddEditEmployee;
        private System.Windows.Forms.TextBox TxLastName;
        private System.Windows.Forms.DateTimePicker DtpDAteOfBirth;
        private System.Windows.Forms.ComboBox CbCountries;
        private System.Windows.Forms.ComboBox CbDepartments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox ChkDtpStatue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox TxFirstName;
        private System.Windows.Forms.TextBox TxSalary;
        private System.Windows.Forms.Label label;
    }
}