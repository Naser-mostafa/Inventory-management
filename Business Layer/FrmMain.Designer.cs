using System.Drawing;
using System.Windows.Forms;

namespace FaisalSport
{
    partial class FrmMain
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
            this.DgvForAll = new System.Windows.Forms.DataGridView();
            this.contextMenuStripForProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxSearchingForProduct = new System.Windows.Forms.TextBox();
            this.LbSearchingForAll = new System.Windows.Forms.Label();
            this.TxSearchingForCustmor = new System.Windows.Forms.TextBox();
            this.contextMenuStripForClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxSearchingForClients = new System.Windows.Forms.TextBox();
            this.contextMenuStripForEmployee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.دفعالراتبالشهريToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تقديمالاستقالهToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TxSearchingForSingleSales = new System.Windows.Forms.TextBox();
            this.TxSearchingForMultiSales = new System.Windows.Forms.TextBox();
            this.BtnSearchOnSingleSales = new System.Windows.Forms.Button();
            this.btnSearchForMultiSales = new System.Windows.Forms.Button();
            this.contextMenuStripForSingleSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripMultiSales = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripForUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripForLogIn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStripForLogOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.LbFormAddress = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormPricture = new System.Windows.Forms.PictureBox();
            this.المنتجاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالجميعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمنتججديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضفعميلجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهعميلجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الموظفينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضجميعالمبيعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.الموظفينToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالجميعToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهموظفجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضجميعالمستخدمينToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمستخدمجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلاتالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسجيلاتالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.بيعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضفموظفجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.تسديدالمستحقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مرتجعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسديدجزءمنالمستحقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسديدالمستحقToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.مToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسدبدجزءمنالمستحقToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضالتفاصيلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفجميعالسجلاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DgvForAll)).BeginInit();
            this.contextMenuStripForProducts.SuspendLayout();
            this.contextMenuStripForClients.SuspendLayout();
            this.contextMenuStripForEmployee.SuspendLayout();
            this.contextMenuStripForSingleSales.SuspendLayout();
            this.contextMenuStripMultiSales.SuspendLayout();
            this.contextMenuStripForUsers.SuspendLayout();
            this.contextMenuStripForLogIn.SuspendLayout();
            this.contextMenuStripForLogOut.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormPricture)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvForAll
            // 
            this.DgvForAll.AllowUserToAddRows = false;
            this.DgvForAll.AllowUserToDeleteRows = false;
            this.DgvForAll.AllowUserToOrderColumns = true;
            this.DgvForAll.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvForAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvForAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvForAll.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DgvForAll.Location = new System.Drawing.Point(0, 128);
            this.DgvForAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvForAll.Name = "DgvForAll";
            this.DgvForAll.ReadOnly = true;
            this.DgvForAll.RowHeadersWidth = 51;
            this.DgvForAll.RowTemplate.Height = 24;
            this.DgvForAll.Size = new System.Drawing.Size(1824, 862);
            this.DgvForAll.TabIndex = 2;
            this.DgvForAll.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvForAll_CellMouseLeave);
            // 
            // contextMenuStripForProducts
            // 
            this.contextMenuStripForProducts.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بيعToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripForProducts.Name = "contextMenuStrip1";
            this.contextMenuStripForProducts.Size = new System.Drawing.Size(230, 82);
            // 
            // TxSearchingForProduct
            // 
            this.TxSearchingForProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSearchingForProduct.Location = new System.Drawing.Point(1031, 94);
            this.TxSearchingForProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSearchingForProduct.Name = "TxSearchingForProduct";
            this.TxSearchingForProduct.Size = new System.Drawing.Size(220, 30);
            this.TxSearchingForProduct.TabIndex = 3;
            this.TxSearchingForProduct.TextChanged += new System.EventHandler(this.TxSearchingForProduct_TextChanged);
            // 
            // LbSearchingForAll
            // 
            this.LbSearchingForAll.AutoSize = true;
            this.LbSearchingForAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSearchingForAll.Location = new System.Drawing.Point(1037, 61);
            this.LbSearchingForAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbSearchingForAll.Name = "LbSearchingForAll";
            this.LbSearchingForAll.Size = new System.Drawing.Size(202, 31);
            this.LbSearchingForAll.TabIndex = 5;
            this.LbSearchingForAll.Text = "البحث باستخدام الاسم";
            // 
            // TxSearchingForCustmor
            // 
            this.TxSearchingForCustmor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSearchingForCustmor.Location = new System.Drawing.Point(1031, 94);
            this.TxSearchingForCustmor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSearchingForCustmor.Name = "TxSearchingForCustmor";
            this.TxSearchingForCustmor.Size = new System.Drawing.Size(220, 30);
            this.TxSearchingForCustmor.TabIndex = 6;
            this.TxSearchingForCustmor.TextChanged += new System.EventHandler(this.TxSearchingForCustmor_TextChanged);
            // 
            // contextMenuStripForClients
            // 
            this.contextMenuStripForClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuStripForClients.Name = "contextMenuStripForClients";
            this.contextMenuStripForClients.Size = new System.Drawing.Size(228, 56);
            // 
            // TxSearchingForClients
            // 
            this.TxSearchingForClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSearchingForClients.Location = new System.Drawing.Point(1031, 94);
            this.TxSearchingForClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSearchingForClients.Name = "TxSearchingForClients";
            this.TxSearchingForClients.Size = new System.Drawing.Size(220, 30);
            this.TxSearchingForClients.TabIndex = 7;
            this.TxSearchingForClients.TextChanged += new System.EventHandler(this.TxSearchingForEmployees_TextChanged);
            // 
            // contextMenuStripForEmployee
            // 
            this.contextMenuStripForEmployee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضفموظفجديدToolStripMenuItem,
            this.deleteToolStripMenuItem2,
            this.دفعالراتبالشهريToolStripMenuItem,
            this.تقديمالاستقالهToolStripMenuItem1});
            this.contextMenuStripForEmployee.Name = "contextMenuStripForEmployee";
            this.contextMenuStripForEmployee.Size = new System.Drawing.Size(240, 108);
            // 
            // دفعالراتبالشهريToolStripMenuItem
            // 
            this.دفعالراتبالشهريToolStripMenuItem.Name = "دفعالراتبالشهريToolStripMenuItem";
            this.دفعالراتبالشهريToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.دفعالراتبالشهريToolStripMenuItem.Text = "دفع الراتب الشهري";
            this.دفعالراتبالشهريToolStripMenuItem.Click += new System.EventHandler(this.دفعالراتبالشهريToolStripMenuItem_Click);
            // 
            // تقديمالاستقالهToolStripMenuItem1
            // 
            this.تقديمالاستقالهToolStripMenuItem1.Name = "تقديمالاستقالهToolStripMenuItem1";
            this.تقديمالاستقالهToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.تقديمالاستقالهToolStripMenuItem1.Text = "تقديم الاستقاله";
            this.تقديمالاستقالهToolStripMenuItem1.Click += new System.EventHandler(this.تقديمالاستقالهToolStripMenuItem1_Click);
            // 
            // TxSearchingForSingleSales
            // 
            this.TxSearchingForSingleSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSearchingForSingleSales.Location = new System.Drawing.Point(1031, 94);
            this.TxSearchingForSingleSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSearchingForSingleSales.Name = "TxSearchingForSingleSales";
            this.TxSearchingForSingleSales.Size = new System.Drawing.Size(220, 30);
            this.TxSearchingForSingleSales.TabIndex = 8;
            // 
            // TxSearchingForMultiSales
            // 
            this.TxSearchingForMultiSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxSearchingForMultiSales.Location = new System.Drawing.Point(1031, 94);
            this.TxSearchingForMultiSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxSearchingForMultiSales.Name = "TxSearchingForMultiSales";
            this.TxSearchingForMultiSales.Size = new System.Drawing.Size(220, 30);
            this.TxSearchingForMultiSales.TabIndex = 9;
            // 
            // BtnSearchOnSingleSales
            // 
            this.BtnSearchOnSingleSales.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSearchOnSingleSales.Location = new System.Drawing.Point(1257, 101);
            this.BtnSearchOnSingleSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSearchOnSingleSales.Name = "BtnSearchOnSingleSales";
            this.BtnSearchOnSingleSales.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchOnSingleSales.TabIndex = 10;
            this.BtnSearchOnSingleSales.Text = " بحث";
            this.BtnSearchOnSingleSales.UseVisualStyleBackColor = false;
            this.BtnSearchOnSingleSales.Click += new System.EventHandler(this.BtnSearchOnSales_Click);
            // 
            // btnSearchForMultiSales
            // 
            this.btnSearchForMultiSales.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearchForMultiSales.Location = new System.Drawing.Point(1257, 101);
            this.btnSearchForMultiSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchForMultiSales.Name = "btnSearchForMultiSales";
            this.btnSearchForMultiSales.Size = new System.Drawing.Size(75, 23);
            this.btnSearchForMultiSales.TabIndex = 11;
            this.btnSearchForMultiSales.Text = " بحث";
            this.btnSearchForMultiSales.UseVisualStyleBackColor = false;
            this.btnSearchForMultiSales.Click += new System.EventHandler(this.btnSearchForMultiSales_Click);
            // 
            // contextMenuStripForSingleSales
            // 
            this.contextMenuStripForSingleSales.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForSingleSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسديدالمستحقToolStripMenuItem,
            this.مرتجعToolStripMenuItem,
            this.تسديدجزءمنالمستحقToolStripMenuItem});
            this.contextMenuStripForSingleSales.Name = "contextMenuStripForSingleSales";
            this.contextMenuStripForSingleSales.Size = new System.Drawing.Size(229, 82);
            // 
            // contextMenuStripMultiSales
            // 
            this.contextMenuStripMultiSales.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMultiSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تسديدالمستحقToolStripMenuItem1,
            this.مToolStripMenuItem,
            this.تسدبدجزءمنالمستحقToolStripMenuItem,
            this.عرضالتفاصيلToolStripMenuItem});
            this.contextMenuStripMultiSales.Name = "contextMenuStripMultiSales";
            this.contextMenuStripMultiSales.Size = new System.Drawing.Size(229, 108);
            // 
            // contextMenuStripForUsers
            // 
            this.contextMenuStripForUsers.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contextMenuStripForUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تعديلToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStripForUsers.Name = "contextMenuStripForUsers";
            this.contextMenuStripForUsers.Size = new System.Drawing.Size(120, 56);
            // 
            // contextMenuStripForLogIn
            // 
            this.contextMenuStripForLogIn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForLogIn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفجميعالسجلاتToolStripMenuItem});
            this.contextMenuStripForLogIn.Name = "contextMenuStripForLogIn";
            this.contextMenuStripForLogIn.Size = new System.Drawing.Size(245, 30);
            // 
            // contextMenuStripForLogOut
            // 
            this.contextMenuStripForLogOut.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForLogOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem,
            this.toolStripMenuItem4});
            this.contextMenuStripForLogOut.Name = "contextMenuStripForLogOut";
            this.contextMenuStripForLogOut.Size = new System.Drawing.Size(304, 56);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(303, 26);
            this.toolStripMenuItem4.Text = " ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 35);
            this.toolStripMenuItem1.Text = " ";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.المنتجاتToolStripMenuItem,
            this.المبيعاتToolStripMenuItem,
            this.الموظفينToolStripMenuItem,
            this.الموظفينToolStripMenuItem1,
            this.المستخدمينToolStripMenuItem,
            this.تسجيلاتالدخولToolStripMenuItem,
            this.تسجيلاتالخروجToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1924, 39);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(27, 35);
            this.toolStripMenuItem2.Text = " ";
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.BackColor = System.Drawing.Color.Red;
            this.BtnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogOut.Location = new System.Drawing.Point(1347, 1);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(193, 38);
            this.BtnLogOut.TabIndex = 12;
            this.BtnLogOut.Text = "تسجيل الخروج";
            this.BtnLogOut.UseVisualStyleBackColor = false;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // LbFormAddress
            // 
            this.LbFormAddress.AutoSize = true;
            this.LbFormAddress.BackColor = System.Drawing.Color.Red;
            this.LbFormAddress.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbFormAddress.ForeColor = System.Drawing.Color.White;
            this.LbFormAddress.Location = new System.Drawing.Point(392, 83);
            this.LbFormAddress.Name = "LbFormAddress";
            this.LbFormAddress.Size = new System.Drawing.Size(272, 43);
            this.LbFormAddress.TabIndex = 14;
            this.LbFormAddress.Text = "Form Addres";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::FaisalSport.Properties.Resources.desert;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 985);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1812, 164);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::FaisalSport.Properties.Resources.pyramids;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1818, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 1118);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormPricture
            // 
            this.FormPricture.BackgroundImage = global::FaisalSport.Properties.Resources.Products1;
            this.FormPricture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormPricture.InitialImage = global::FaisalSport.Properties.Resources.Products;
            this.FormPricture.Location = new System.Drawing.Point(768, 61);
            this.FormPricture.Name = "FormPricture";
            this.FormPricture.Size = new System.Drawing.Size(111, 69);
            this.FormPricture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormPricture.TabIndex = 15;
            this.FormPricture.TabStop = false;
            // 
            // المنتجاتToolStripMenuItem
            // 
            this.المنتجاتToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.المنتجاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالجميعToolStripMenuItem,
            this.اضافهمنتججديدToolStripMenuItem});
            this.المنتجاتToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.المنتجاتToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Products;
            this.المنتجاتToolStripMenuItem.Name = "المنتجاتToolStripMenuItem";
            this.المنتجاتToolStripMenuItem.Size = new System.Drawing.Size(134, 35);
            this.المنتجاتToolStripMenuItem.Text = " الاصناف";
            // 
            // عرضالجميعToolStripMenuItem
            // 
            this.عرضالجميعToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Products;
            this.عرضالجميعToolStripMenuItem.Name = "عرضالجميعToolStripMenuItem";
            this.عرضالجميعToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.عرضالجميعToolStripMenuItem.Text = "عرض جميع المنتجات";
            this.عرضالجميعToolStripMenuItem.Click += new System.EventHandler(this.عرضالجميعToolStripMenuItem_Click);
            // 
            // اضافهمنتججديدToolStripMenuItem
            // 
            this.اضافهمنتججديدToolStripMenuItem.Name = "اضافهمنتججديدToolStripMenuItem";
            this.اضافهمنتججديدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.اضافهمنتججديدToolStripMenuItem.Size = new System.Drawing.Size(339, 36);
            this.اضافهمنتججديدToolStripMenuItem.Text = "اضافه منتج جديد";
            this.اضافهمنتججديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهمنتججديدToolStripMenuItem_Click);
            // 
            // المبيعاتToolStripMenuItem
            // 
            this.المبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضفعميلجديدToolStripMenuItem,
            this.اضافهعميلجديدToolStripMenuItem});
            this.المبيعاتToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.المبيعاتToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Clients;
            this.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem";
            this.المبيعاتToolStripMenuItem.Size = new System.Drawing.Size(118, 35);
            this.المبيعاتToolStripMenuItem.Text = " العملاء";
            // 
            // اضفعميلجديدToolStripMenuItem
            // 
            this.اضفعميلجديدToolStripMenuItem.Name = "اضفعميلجديدToolStripMenuItem";
            this.اضفعميلجديدToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.اضفعميلجديدToolStripMenuItem.Text = "عرض جميع العملاء";
            this.اضفعميلجديدToolStripMenuItem.Click += new System.EventHandler(this.اضفعميلجديدToolStripMenuItem_Click);
            // 
            // اضافهعميلجديدToolStripMenuItem
            // 
            this.اضافهعميلجديدToolStripMenuItem.Name = "اضافهعميلجديدToolStripMenuItem";
            this.اضافهعميلجديدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.اضافهعميلجديدToolStripMenuItem.Size = new System.Drawing.Size(353, 36);
            this.اضافهعميلجديدToolStripMenuItem.Text = "اضافه عميل  جديد";
            this.اضافهعميلجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهعميلجديدToolStripMenuItem_Click);
            // 
            // الموظفينToolStripMenuItem
            // 
            this.الموظفينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضجميعالمبيعاتToolStripMenuItem,
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem});
            this.الموظفينToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.الموظفينToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Sales;
            this.الموظفينToolStripMenuItem.Name = "الموظفينToolStripMenuItem";
            this.الموظفينToolStripMenuItem.Size = new System.Drawing.Size(131, 35);
            this.الموظفينToolStripMenuItem.Text = "المبيعات";
            // 
            // عرضجميعالمبيعاتToolStripMenuItem
            // 
            this.عرضجميعالمبيعاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem});
            this.عرضجميعالمبيعاتToolStripMenuItem.Name = "عرضجميعالمبيعاتToolStripMenuItem";
            this.عرضجميعالمبيعاتToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.عرضجميعالمبيعاتToolStripMenuItem.Size = new System.Drawing.Size(453, 36);
            this.عرضجميعالمبيعاتToolStripMenuItem.Text = "عرض جميع الفواتير الفرديه";
            this.عرضجميعالمبيعاتToolStripMenuItem.Click += new System.EventHandler(this.عرضجميعالمبيعاتToolStripMenuItem_Click);
            // 
            // عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem
            // 
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem.Name = "عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem";
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem.Size = new System.Drawing.Size(428, 36);
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem.Text = "عرض الفواتير التي عليها مستحقات";
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem.Click += new System.EventHandler(this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem_Click);
            // 
            // عرضجميعالفواتيرالمدمجهToolStripMenuItem
            // 
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1});
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.Name = "عرضجميعالفواتيرالمدمجهToolStripMenuItem";
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.Size = new System.Drawing.Size(453, 36);
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.Text = "عرض جميع الفواتير المدمجه";
            this.عرضجميعالفواتيرالمدمجهToolStripMenuItem.Click += new System.EventHandler(this.عرضجميعالفواتيرالمدمجهToolStripMenuItem_Click);
            // 
            // عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1
            // 
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1.Name = "عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1";
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1.Size = new System.Drawing.Size(428, 36);
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1.Text = "عرض الفواتير التي عليها مستحقات";
            this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1.Click += new System.EventHandler(this.عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1_Click);
            // 
            // الموظفينToolStripMenuItem1
            // 
            this.الموظفينToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالجميعToolStripMenuItem1,
            this.اضافهموظفجديدToolStripMenuItem});
            this.الموظفينToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.الموظفينToolStripMenuItem1.Image = global::FaisalSport.Properties.Resources.موظفين;
            this.الموظفينToolStripMenuItem1.Name = "الموظفينToolStripMenuItem1";
            this.الموظفينToolStripMenuItem1.Size = new System.Drawing.Size(141, 35);
            this.الموظفينToolStripMenuItem1.Text = "الموظفين";
            // 
            // عرضالجميعToolStripMenuItem1
            // 
            this.عرضالجميعToolStripMenuItem1.Name = "عرضالجميعToolStripMenuItem1";
            this.عرضالجميعToolStripMenuItem1.Size = new System.Drawing.Size(363, 36);
            this.عرضالجميعToolStripMenuItem1.Text = "عرض جميع الموظفين";
            this.عرضالجميعToolStripMenuItem1.Click += new System.EventHandler(this.عرضالجميعToolStripMenuItem1_Click);
            // 
            // اضافهموظفجديدToolStripMenuItem
            // 
            this.اضافهموظفجديدToolStripMenuItem.Name = "اضافهموظفجديدToolStripMenuItem";
            this.اضافهموظفجديدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.اضافهموظفجديدToolStripMenuItem.Size = new System.Drawing.Size(363, 36);
            this.اضافهموظفجديدToolStripMenuItem.Text = "اضافه موظف جديد";
            this.اضافهموظفجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهموظفجديدToolStripMenuItem_Click);
            // 
            // المستخدمينToolStripMenuItem
            // 
            this.المستخدمينToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضجميعالمستخدمينToolStripMenuItem,
            this.اضافهمستخدمجديدToolStripMenuItem});
            this.المستخدمينToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.المستخدمينToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Person1;
            this.المستخدمينToolStripMenuItem.Name = "المستخدمينToolStripMenuItem";
            this.المستخدمينToolStripMenuItem.Size = new System.Drawing.Size(163, 35);
            this.المستخدمينToolStripMenuItem.Text = "المستخدمين";
            // 
            // عرضجميعالمستخدمينToolStripMenuItem
            // 
            this.عرضجميعالمستخدمينToolStripMenuItem.Name = "عرضجميعالمستخدمينToolStripMenuItem";
            this.عرضجميعالمستخدمينToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.عرضجميعالمستخدمينToolStripMenuItem.Text = "عرض جميع المستخدمين";
            this.عرضجميعالمستخدمينToolStripMenuItem.Click += new System.EventHandler(this.عرضجميعالمستخدمينToolStripMenuItem_Click);
            // 
            // اضافهمستخدمجديدToolStripMenuItem
            // 
            this.اضافهمستخدمجديدToolStripMenuItem.Name = "اضافهمستخدمجديدToolStripMenuItem";
            this.اضافهمستخدمجديدToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.اضافهمستخدمجديدToolStripMenuItem.Size = new System.Drawing.Size(378, 36);
            this.اضافهمستخدمجديدToolStripMenuItem.Text = "اضافه مستخدم جديد";
            this.اضافهمستخدمجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهمستخدمجديدToolStripMenuItem_Click);
            // 
            // تسجيلاتالدخولToolStripMenuItem
            // 
            this.تسجيلاتالدخولToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem});
            this.تسجيلاتالدخولToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.تسجيلاتالدخولToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Login;
            this.تسجيلاتالدخولToolStripMenuItem.Name = "تسجيلاتالدخولToolStripMenuItem";
            this.تسجيلاتالدخولToolStripMenuItem.Size = new System.Drawing.Size(209, 35);
            this.تسجيلاتالدخولToolStripMenuItem.Text = " تسجيلات الدخول";
            this.تسجيلاتالدخولToolStripMenuItem.Click += new System.EventHandler(this.تسجيلاتالدخولToolStripMenuItem_Click);
            // 
            // عرضوقتتسجيلاتالدخولToolStripMenuItem
            // 
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem.Name = "عرضوقتتسجيلاتالدخولToolStripMenuItem";
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem.Size = new System.Drawing.Size(438, 36);
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem.Text = "عرض وقت تسجيلات الدخول";
            this.عرضوقتتسجيلاتالدخولToolStripMenuItem.Click += new System.EventHandler(this.عرضوقتتسجيلاتالدخولToolStripMenuItem_Click);
            // 
            // تسجيلاتالخروجToolStripMenuItem
            // 
            this.تسجيلاتالخروجToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem});
            this.تسجيلاتالخروجToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.تسجيلاتالخروجToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.LogOut;
            this.تسجيلاتالخروجToolStripMenuItem.Name = "تسجيلاتالخروجToolStripMenuItem";
            this.تسجيلاتالخروجToolStripMenuItem.Size = new System.Drawing.Size(199, 35);
            this.تسجيلاتالخروجToolStripMenuItem.Text = "تسجيلات الخروج";
            // 
            // عرضوقتتسجيلاتالخروجToolStripMenuItem
            // 
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem.Name = "عرضوقتتسجيلاتالخروجToolStripMenuItem";
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem.Size = new System.Drawing.Size(445, 36);
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem.Text = "عرض وقت تسجيلات الخروج";
            this.عرضوقتتسجيلاتالخروجToolStripMenuItem.Click += new System.EventHandler(this.عرضوقتتسجيلاتالخروجToolStripMenuItem_Click);
            // 
            // بيعToolStripMenuItem
            // 
            this.بيعToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Sales;
            this.بيعToolStripMenuItem.Name = "بيعToolStripMenuItem";
            this.بيعToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.بيعToolStripMenuItem.Text = "بيع";
            this.بيعToolStripMenuItem.Click += new System.EventHandler(this.بيعToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.editToolStripMenuItem.Text = "تعديل معلومات الصنف";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.deleteToolStripMenuItem.Text = "حذف الصنف";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.BackgroundImage = global::FaisalSport.Properties.Resources.Edit;
            this.editToolStripMenuItem1.Image = global::FaisalSport.Properties.Resources.Edit;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.editToolStripMenuItem1.Text = "تعديل معلومات العميل";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.deleteToolStripMenuItem1.Text = "حذف معلومات العميل";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // اضفموظفجديدToolStripMenuItem
            // 
            this.اضفموظفجديدToolStripMenuItem.BackgroundImage = global::FaisalSport.Properties.Resources.Edit;
            this.اضفموظفجديدToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Edit;
            this.اضفموظفجديدToolStripMenuItem.Name = "اضفموظفجديدToolStripMenuItem";
            this.اضفموظفجديدToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.اضفموظفجديدToolStripMenuItem.Text = "تعديل معلومات الموظف";
            this.اضفموظفجديدToolStripMenuItem.Click += new System.EventHandler(this.اضفموظفجديدToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(239, 26);
            this.deleteToolStripMenuItem2.Text = "حذف الموظف";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // تسديدالمستحقToolStripMenuItem
            // 
            this.تسديدالمستحقToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Sales;
            this.تسديدالمستحقToolStripMenuItem.Name = "تسديدالمستحقToolStripMenuItem";
            this.تسديدالمستحقToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.تسديدالمستحقToolStripMenuItem.Text = "تسديد المستحق";
            this.تسديدالمستحقToolStripMenuItem.Click += new System.EventHandler(this.تسديدالمستحقToolStripMenuItem_Click);
            // 
            // مرتجعToolStripMenuItem
            // 
            this.مرتجعToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Products;
            this.مرتجعToolStripMenuItem.Name = "مرتجعToolStripMenuItem";
            this.مرتجعToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.مرتجعToolStripMenuItem.Text = "مرتجع";
            this.مرتجعToolStripMenuItem.Click += new System.EventHandler(this.مرتجعToolStripMenuItem_Click);
            // 
            // تسديدجزءمنالمستحقToolStripMenuItem
            // 
            this.تسديدجزءمنالمستحقToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Sales;
            this.تسديدجزءمنالمستحقToolStripMenuItem.Name = "تسديدجزءمنالمستحقToolStripMenuItem";
            this.تسديدجزءمنالمستحقToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.تسديدجزءمنالمستحقToolStripMenuItem.Text = "تسديد جزء من المستحق";
            this.تسديدجزءمنالمستحقToolStripMenuItem.Click += new System.EventHandler(this.تسديدجزءمنالمستحقToolStripMenuItem_Click);
            // 
            // تسديدالمستحقToolStripMenuItem1
            // 
            this.تسديدالمستحقToolStripMenuItem1.Image = global::FaisalSport.Properties.Resources.Sales;
            this.تسديدالمستحقToolStripMenuItem1.Name = "تسديدالمستحقToolStripMenuItem1";
            this.تسديدالمستحقToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.تسديدالمستحقToolStripMenuItem1.Text = "تسديد المستحق";
            this.تسديدالمستحقToolStripMenuItem1.Click += new System.EventHandler(this.تسديدالمستحقToolStripMenuItem1_Click);
            // 
            // مToolStripMenuItem
            // 
            this.مToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Products;
            this.مToolStripMenuItem.Name = "مToolStripMenuItem";
            this.مToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.مToolStripMenuItem.Text = "مرتجع";
            this.مToolStripMenuItem.Click += new System.EventHandler(this.مToolStripMenuItem_Click);
            // 
            // تسدبدجزءمنالمستحقToolStripMenuItem
            // 
            this.تسدبدجزءمنالمستحقToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Sales;
            this.تسدبدجزءمنالمستحقToolStripMenuItem.Name = "تسدبدجزءمنالمستحقToolStripMenuItem";
            this.تسدبدجزءمنالمستحقToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.تسدبدجزءمنالمستحقToolStripMenuItem.Text = "تسدبد جزء من المستحق";
            this.تسدبدجزءمنالمستحقToolStripMenuItem.Click += new System.EventHandler(this.تسدبدجزءمنالمستحقToolStripMenuItem_Click);
            // 
            // عرضالتفاصيلToolStripMenuItem
            // 
            this.عرضالتفاصيلToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.details;
            this.عرضالتفاصيلToolStripMenuItem.Name = "عرضالتفاصيلToolStripMenuItem";
            this.عرضالتفاصيلToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.عرضالتفاصيلToolStripMenuItem.Text = "عرض التفاصيل";
            this.عرضالتفاصيلToolStripMenuItem.Click += new System.EventHandler(this.عرضالتفاصيلToolStripMenuItem_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.Edit;
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.تعديلToolStripMenuItem.Text = "تعديل";
            this.تعديلToolStripMenuItem.Click += new System.EventHandler(this.تعديلToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.حذفToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(119, 26);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
            // 
            // حذفجميعالسجلاتToolStripMenuItem
            // 
            this.حذفجميعالسجلاتToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.حذفجميعالسجلاتToolStripMenuItem.Name = "حذفجميعالسجلاتToolStripMenuItem";
            this.حذفجميعالسجلاتToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.حذفجميعالسجلاتToolStripMenuItem.Text = "حذف جميع سجلات الخروج";
            this.حذفجميعالسجلاتToolStripMenuItem.Click += new System.EventHandler(this.حذفجميعالسجلاتToolStripMenuItem_Click);
            // 
            // حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem
            // 
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem.Image = global::FaisalSport.Properties.Resources.rubbish;
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem.Name = "حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem";
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem.Size = new System.Drawing.Size(303, 26);
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem.Text = "حذف جميع سجلات تسجيلات الخروج";
            this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem.Click += new System.EventHandler(this.حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FormPricture);
            this.Controls.Add(this.LbFormAddress);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.btnSearchForMultiSales);
            this.Controls.Add(this.BtnSearchOnSingleSales);
            this.Controls.Add(this.TxSearchingForMultiSales);
            this.Controls.Add(this.TxSearchingForSingleSales);
            this.Controls.Add(this.TxSearchingForClients);
            this.Controls.Add(this.TxSearchingForCustmor);
            this.Controls.Add(this.LbSearchingForAll);
            this.Controls.Add(this.TxSearchingForProduct);
            this.Controls.Add(this.DgvForAll);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvForAll)).EndInit();
            this.contextMenuStripForProducts.ResumeLayout(false);
            this.contextMenuStripForClients.ResumeLayout(false);
            this.contextMenuStripForEmployee.ResumeLayout(false);
            this.contextMenuStripForSingleSales.ResumeLayout(false);
            this.contextMenuStripMultiSales.ResumeLayout(false);
            this.contextMenuStripForUsers.ResumeLayout(false);
            this.contextMenuStripForLogIn.ResumeLayout(false);
            this.contextMenuStripForLogOut.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormPricture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvForAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForProducts;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TextBox TxSearchingForProduct;
        private System.Windows.Forms.Label LbSearchingForAll;
        private System.Windows.Forms.TextBox TxSearchingForCustmor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForClients;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.TextBox TxSearchingForClients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForEmployee;
        private System.Windows.Forms.ToolStripMenuItem اضفموظفجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem دفعالراتبالشهريToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem بيعToolStripMenuItem;
        private System.Windows.Forms.TextBox TxSearchingForSingleSales;
        private System.Windows.Forms.TextBox TxSearchingForMultiSales;
        private System.Windows.Forms.Button BtnSearchOnSingleSales;
        private System.Windows.Forms.Button btnSearchForMultiSales;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForSingleSales;
        private System.Windows.Forms.ToolStripMenuItem تسديدالمستحقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مرتجعToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMultiSales;
        private System.Windows.Forms.ToolStripMenuItem تسديدالمستحقToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem مToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForUsers;
        private System.Windows.Forms.ToolStripMenuItem تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForLogIn;
        private System.Windows.Forms.ToolStripMenuItem حذفجميعالسجلاتToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForLogOut;
        private System.Windows.Forms.ToolStripMenuItem حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسديدجزءمنالمستحقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسدبدجزءمنالمستحقToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالتفاصيلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضفعميلجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهعميلجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الموظفينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضجميعالمبيعاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضجميعالفواتيرالمدمجهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem الموظفينToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem عرضالجميعToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اضافهموظفجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضجميعالمستخدمينToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهمستخدمجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلاتالدخولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضوقتتسجيلاتالدخولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسجيلاتالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضوقتتسجيلاتالخروجToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem المنتجاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضالجميعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهمنتججديدToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem تقديمالاستقالهToolStripMenuItem1;
        private Button BtnLogOut;
        private Label LbFormAddress;
        private PictureBox FormPricture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}