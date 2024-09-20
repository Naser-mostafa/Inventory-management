using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using UhlSportDataAccessLayer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using static UhlSportDataAccessLayer.GlobalCurrentUser;
using System.Diagnostics.Tracing;
using FaisalSport.Properties;

namespace FaisalSport
{
    public partial class FrmMain : Form
    {
        GlobalCurrentUser CurrentUserInfo;
        Form _LogIn = new Form();
        public FrmMain( ref GlobalCurrentUser CurrentUser ,  Form LogIn)
        {
           _LogIn = LogIn;
            CurrentUserInfo = CurrentUser;
            InitializeComponent();
        }

        public static DataTable RefreshAllProducts()
        {
            DataTable AllProducts = CLsProducts.GetAllProductsInfo();
            return AllProducts;
        }
        private void عرضالجميعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 1))
            {
                FormPricture.Image = Resources.Products;
                LbFormAddress.Text = "Products";
               
                LbSearchingForAll.Show();
                BtnSearchOnSingleSales.Visible = false;
                DgvForAll.DataSource = RefreshAllProducts();
                DgvForAll.ContextMenuStrip = contextMenuStripForProducts;
                TxSearchingForMultiSales.Hide();
                TxSearchingForSingleSales.Hide();
                TxSearchingForCustmor.Hide();
                TxSearchingForProduct.Show();
                TxSearchingForClients.Hide();
                LbSearchingForAll.Text = "البحث باستخدام الاسم";
            }
            else
            {
              UhlSportDataAccessLayer.Settings.AccessDenied();
            }

        }
        private void اضافهمنتججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 1))
            {
                Form FrmAddEdit = new AddNewAdnEditProduct(-1);
                FrmAddEdit.ShowDialog();
                DgvForAll.DataSource = RefreshAllProducts();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
               
            }
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmEdit = new AddNewAdnEditProduct(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value));
            frmEdit.ShowDialog();
            DgvForAll.DataSource = RefreshAllProducts();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل أنت متأكد من حذف هذا العنصر؟", "الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                if (CLsProducts.Delete(Convert.ToInt32((DgvForAll.CurrentRow.Cells[0].Value))))
                {
                    MessageBox.Show("تمت العمليه بنجاح");
                    DgvForAll.DataSource = RefreshAllProducts();
                }
                else
                {
                    MessageBox.Show("فشلت العمليه");
                }
            }


        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Products";

            FormPricture.Image = Resources.Products;
            _LogIn.Hide();
            LbSearchingForAll.Show();
            BtnSearchOnSingleSales.Visible = false;
            DgvForAll.DataSource = RefreshAllProducts();
            DgvForAll.ContextMenuStrip = contextMenuStripForProducts;
            DgvForAll.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            DgvForAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            TxSearchingForMultiSales.Hide();
            TxSearchingForSingleSales.Hide();
            TxSearchingForCustmor.Hide();
            TxSearchingForProduct.Show();
            TxSearchingForClients.Hide();
            LbSearchingForAll.Text = "البحث باستخدام الاسم";

        }
        private void TxSearchingForProduct_TextChanged(object sender, EventArgs e)
        {
            DgvForAll.DataSource = CLsProducts.FindByProductThatNameStartWithName(TxSearchingForProduct.Text);
        }
        private void اضافهعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 2))
            {
                //we use -1 for flag and asign to form that we call it for new custmor not update
                Form FrmAddNewClient = new FrmAddEditCustmor(-1, ref DgvForAll);
                FrmAddNewClient.ShowDialog();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        public static DataTable RefreshAllCustmors()
        {
            DataTable allCustmors = ClsCustmors.GetAllCustmors();
            return allCustmors;
        }
        public void اضفعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 2))
            {
                FormPricture.Image = Resources.Clients;
                LbFormAddress.Text = "Clients";

                LbSearchingForAll.Show();
                BtnSearchOnSingleSales.Visible = false;
                LbSearchingForAll.Text = "البحث باستخدام الاسم";
                DgvForAll.DataSource = RefreshAllCustmors();
                DgvForAll.ContextMenuStrip = contextMenuStripForClients;
                TxSearchingForMultiSales.Hide();
                TxSearchingForSingleSales.Hide();
                TxSearchingForCustmor.Show();
                TxSearchingForProduct.Hide();
                TxSearchingForClients.Hide();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }

        }
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmUpdateClient = new FrmAddEditCustmor( Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value), ref DgvForAll);
            frmUpdateClient.Show();
        }
        private void TxSearchingForCustmor_TextChanged(object sender, EventArgs e)
        {
            DgvForAll.DataSource = ClsCustmors.FindCustmorByName(TxSearchingForCustmor.Text);
        }
        private bool DeleteCustmor()
        {
            return ClsCustmors.Delete(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value));
        }
        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = (MessageBox.Show("هل انت متاكد من الحذف", "حذف عميل", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning));
            if (result == DialogResult.OK)
            {
                if (DeleteCustmor())
                {
                    MessageBox.Show("تم الحذف بنجاح");
                    DgvForAll.DataSource = RefreshAllCustmors();
                }
            }
            else
            {
                MessageBox.Show("فشل الحذف");
            }

        }
        public static DataTable RefreshAllEmployees()
        {
            DataTable AllEmployees = ClsEmployees.GetAllEmployees();
            return AllEmployees;
        }
        private void عرضالجميعToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 8))
            {
                LbFormAddress.Text = "Employees";
                FormPricture.Image = Resources.موظفين;
                LbSearchingForAll.Show();
                BtnSearchOnSingleSales.Visible = false;
                LbSearchingForAll.Text = "البحث باستخدام الاسم";
                DgvForAll.DataSource = RefreshAllEmployees();
                DgvForAll.ContextMenuStrip = contextMenuStripForEmployee;
                TxSearchingForMultiSales.Hide();
                TxSearchingForSingleSales.Hide();
                TxSearchingForCustmor.Hide();
                TxSearchingForProduct.Hide();
                TxSearchingForClients.Show();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }

        }
        private void اضافهموظفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 8))
            {

                BtnSearchOnSingleSales.Visible = false;
                Form frmAddNew = new FrmAddNewEmployee(-1, ref DgvForAll);
                frmAddNew.Show();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        // this will select row on mouse over
        private int selectedRowIndex = -1;
        private void DgvForAll_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvForAll.RowCount > 0)
            {
                if (selectedRowIndex != -1 && selectedRowIndex < DgvForAll.RowCount)
                {
                    DgvForAll.Rows[selectedRowIndex].Selected = false;
                }

                // تحديد الصف الجديد
                if (e.RowIndex >= 0 && e.RowIndex < DgvForAll.RowCount)
                {
                    DgvForAll.CurrentCell = DgvForAll.Rows[e.RowIndex].Cells[0]; // اختر الخلية الأولى في الصف
                    DgvForAll.Rows[e.RowIndex].Selected = true;
                    selectedRowIndex = e.RowIndex;
                }
            }
        }
        private void اضفموظفجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmEditEmployee = new FrmAddNewEmployee(Convert.ToInt32(DgvForAll.CurrentRow.Cells[0].Value), ref DgvForAll);
            FrmEditEmployee.Show();
        }
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("سيتم حذف الموظف نهائيا بعد الضغط على زر الموافقة", "حذف الموظف", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (ClsEmployees.DeleteEmployeeByID(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value))) 
                {
                    MessageBox.Show("تمت العملية بنجاح", "نتيجة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvForAll.DataSource = RefreshAllEmployees();
                }

                else
                {
                    MessageBox.Show("لم يتم الحذف", "نتيجة الحذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void TxSearchingForEmployees_TextChanged(object sender, EventArgs e)
        {
            DgvForAll.DataSource = ClsEmployees.GetEmployeesThatNameStartWith(TxSearchingForClients.Text);
        }
        private void بيعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                Form FrmSellorder = new SellOrder(Convert.ToInt32(DgvForAll.CurrentRow.Cells[0].Value), DgvForAll);
                FrmSellorder.ShowDialog();
            
     
        }
        private DataTable RefreshSingleSales()
        {
            return SingleSales.GetAllSales();
        }
        private void عرضجميعالمبيعاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 4))
            {
                FormPricture.Image = Resources.Sales;
                LbFormAddress.Text = "Sales";

                LbSearchingForAll.Show();
                DgvForAll.ContextMenuStrip = contextMenuStripForSingleSales;
                btnSearchForMultiSales.Hide();
                BtnSearchOnSingleSales.Show();
                LbSearchingForAll.Text = "البحث باستخدام رقم الفاتوره";
                DgvForAll.DataSource = RefreshSingleSales();
                TxSearchingForMultiSales.Hide();
                TxSearchingForSingleSales.Show();
                TxSearchingForCustmor.Hide();
                TxSearchingForProduct.Hide();
                TxSearchingForClients.Hide();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        private DataTable _RefreshAllMultipleInvoices()
        {
            return ClsMultipleinvoices.GetAllMultipleInvoices();
        }
        private void عرضجميعالفواتيرالمدمجهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 4))
            {
                LbFormAddress.Text = "Sales";
                FormPricture.Image = Resources.Sales;
                DgvForAll.ContextMenuStrip = contextMenuStripMultiSales;
                btnSearchForMultiSales.Show();
                BtnSearchOnSingleSales.Hide();
                TxSearchingForClients.Hide();
                TxSearchingForCustmor.Hide();
                TxSearchingForProduct.Hide();
                TxSearchingForSingleSales.Hide();
                TxSearchingForMultiSales.Show();
                DgvForAll.DataSource = _RefreshAllMultipleInvoices();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        private void BtnSearchOnSales_Click(object sender, EventArgs e)
        {
            DgvForAll.DataSource = SingleSales.FindInvoiceById(BigInteger.Parse(TxSearchingForSingleSales.Text));
        }
        private void btnSearchForMultiSales_Click(object sender, EventArgs e)
        {
            DgvForAll.DataSource = ClsMultipleinvoices.FindMultiInvoiceById(Convert.ToInt64(TxSearchingForMultiSales.Text));

        }
        private void تسديدالمستحقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد تسديد كافه تسديد المستحقات", "تسديد المستحقات", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                SingleSales.PaymentDuesForSingleSales(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value),Convert.ToInt64(DgvForAll.CurrentRow.Cells["الرقم_الفريد_لطريقه_الدفع"].Value));
                
                MessageBox.Show("تم بنجاح");
            }
            else
            {
                MessageBox.Show("تم الالغاء بنجاح", "cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DgvForAll.DataSource = RefreshSingleSales();
        }
        private void مرتجعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Quantity = Convert.ToInt32(DgvForAll.CurrentRow.Cells["الكميه"].Value);
            string ProductName = Convert.ToString(DgvForAll.CurrentRow.Cells["اسم_المنتج"].Value);
            DialogResult result = MessageBox.Show("هل انت متاكد من استرجاع ذالك العنصر ", "الاسترجاع", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                CLsProducts.returns(Quantity, ProductName);
                SingleSales.Delete(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم بنجاح");
                DgvForAll.DataSource = RefreshSingleSales();
            }
            else
            {
                MessageBox.Show("تم الالغاء بنجاح", "cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool IsThisSingleInvoiceExistsOnBinaryInvouice(BigInteger AllInvoicesWithBinaryForamt, BigInteger SingleInvoiceID)
        {
            return (SingleInvoiceID == (SingleInvoiceID & AllInvoicesWithBinaryForamt));
        }
        private void تسديدالمستحقToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
 
                if (ClsMultipleinvoices.PaymentDues(Convert.ToInt64(DgvForAll.CurrentRow.Cells["رقم_الفاتوره_المدمجه"].Value)))
                {
                if(SingleSales.PaymentDues(Convert.ToInt64(DgvForAll.CurrentRow.Cells["رقم_الفاتوره_المدمجه"].Value)))
                {
                    MessageBox.Show("تم دفع المستحقات", "دفع المستحق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DgvForAll.DataSource = ClsMultipleinvoices.GetAllMultipleInvoices();
                }
                
                }
            
        }
        private void مToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("هل انت متاكر من استرجاع كل الطلبيه ", "استرجاع كامل الطلبيه", MessageBoxButtons.YesNo);
            if(Result==DialogResult.Yes)
            {
                DataTable AllSingleSalesINtoMultiSales =SingleSales.GetAllSingleSalesWhichInMultiInvoice(Convert.ToInt64(DgvForAll.CurrentRow.Cells["رقم_الفاتوره_المدمجه"].Value));
                {
                    foreach (DataRow Row in AllSingleSalesINtoMultiSales.Rows)
                    {
                        CLsProducts.returns(Convert.ToInt32(Row["الكميه"]), Convert.ToString(Row["اسم_المنتج"]));
                        SingleSales.Delete(Convert.ToInt32(Row[0]));
                    }
                }
                ClsMultipleinvoices.Delete(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value));
                MessageBox.Show("تم الاسترجاع وزياده المزون بنجاح");
                DgvForAll.DataSource = _RefreshAllMultipleInvoices();
            }
     
        }
        private DataTable GetAllUser()
        {
            DataTable dt = ClsUser.GetAllUsers();
            return dt;
        }

        private void _RefreshAllUser()
            {
               DgvForAll.DataSource = ClsUser.GetAllUsers();
        }
        private void عرضجميعالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 16))
            {
                LbFormAddress.Text = "Users";
                FormPricture.Image = Resources.Person1;
                DgvForAll.ContextMenuStrip = contextMenuStripForUsers;
                LbSearchingForAll.Hide();
                TxSearchingForClients.Hide();
                TxSearchingForCustmor.Hide();
                TxSearchingForMultiSales.Hide();
                TxSearchingForProduct.Hide();
                TxSearchingForSingleSales.Hide();
                btnSearchForMultiSales.Hide();
                BtnSearchOnSingleSales.Hide();
                _RefreshAllUser();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }

        private void اضافهمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 16))
            {

                Form frmAddNewUser = new AddEditUsers(-1);
                frmAddNewUser.Show();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        private DataTable _refreshAllLogInDate()
        {
            DataTable All = ClsLoginDate.GetAllLogInDates();
            return All;
        }
        private void HideAllControlsNotNeeded()
        {
            DgvForAll.ContextMenuStrip = contextMenuStripForLogIn;
            TxSearchingForClients.Hide();
            btnSearchForMultiSales.Hide();
            BtnSearchOnSingleSales.Hide();
            TxSearchingForCustmor.Hide();
            TxSearchingForMultiSales.Hide();
            TxSearchingForProduct.Hide();
            TxSearchingForSingleSales.Hide();
            LbSearchingForAll.Hide();
        }
        private void عرضوقتتسجيلاتالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Log_in Dates";
            FormPricture.Image = Resources.Login;
            HideAllControlsNotNeeded();
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 32))
            {
                DgvForAll.ContextMenu = null;
                DgvForAll.DataSource = _refreshAllLogInDate();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        private DataTable _RegreshLogoutDates()
        {
            DataTable All = ClsLogOutDates.GetAllLogOutDates();
            return All;
        }
        private void عرضوقتتسجيلاتالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbFormAddress.Text = "Log_Out Dates";
            FormPricture.Image = Resources.LogOut;

            HideAllControlsNotNeeded();
            DgvForAll.ContextMenuStrip = contextMenuStripForLogOut;
            if (IsThisUserHaveAccessToGetHere(CurrentUserInfo.PermissionNumber, 32))
            {
                DgvForAll.DataSource = _RegreshLogoutDates();
            }
            else
            {
                UhlSportDataAccessLayer.Settings.AccessDenied();
            }
        }
        private bool IsThisUserHaveAccessToGetHere(sbyte UserPermissions,sbyte MenuMemberPermission)
        {
            return ((MenuMemberPermission == (MenuMemberPermission & UserPermissions ))|| UserPermissions==-1) ;
        }
    
        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmEditUser = new AddEditUsers(Convert.ToInt32(DgvForAll.CurrentRow.Cells["رقم_المستخدم_الفريد"].Value));
            FrmEditUser.Show();
        }
        private bool _DeleteUser(int UserID)
        {
            return ClsUser.DeleteUser(UserID);
        }
        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DgvForAll.CurrentRow.Cells[0].Value) == 2)
            {
                MessageBox.Show("لا يمكنك حذف المالك", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("هل انت متاكد من حذف المستخدم", "حذف مستخدم", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (_DeleteUser(Convert.ToInt32(DgvForAll.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("تم الحذف بنجاح");
                        DgvForAll.DataSource = GetAllUser();
                    }
                    else
                    {
                        MessageBox.Show("حدث خطأ يرجي التواصل مع مطور البرنامج");


                    }
                }
                else
                {
                    MessageBox.Show("تم الالغاء");

                }
            }
        }

       private bool DeleteAllLogInٌecords()
        {
            return ClsLoginDate.DeleteALL();
        }
        private bool DeleteAllLogOutRecords()
        {
            return ClsLogOutDates.DeleteALL();
        }

        private void حذفجميعالسجلاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف جميع السجلات", "الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); 
            if(result==DialogResult.OK)
            {
                if(DeleteAllLogInٌecords())
                {
                    
                    MessageBox.Show("تم الحذف بنجاح");
                    DgvForAll.DataSource = _refreshAllLogInDate();
                }
                else
                {
                    MessageBox.Show("خطا في التطير يرجي التواصل مع مطور البرنامج");
                }
            }
            else
            {
                MessageBox.Show("تم الغاء الحذف");

            }
        }

        private void حذفجميعسجلاتتسجيلاتالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل انت متأكد من حذف جميع السجلات", "الحذف", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (DeleteAllLogOutRecords())
                {

                    MessageBox.Show("تم الحذف بنجاح");
                    DgvForAll.DataSource = ClsLogOutDates.GetAllLogOutDates();
                }
                else
                {
                    MessageBox.Show("خطا  يرجي التواصل مع مطور البرنامج");
                }
            }
            else
            {
                MessageBox.Show("تم الغاء الحذف");

            }
        }

        private  DataTable GetAllSingleInvoicesThatHaveDues()
        {
            DataTable dt = SingleSales.GetAllInvoicesThatHaveDues();
            return dt;
            
        }
        private DataTable GetAllSMultiInvoicesThatHaveDues()
        {
            DataTable dt = ClsMultipleinvoices.GetAllInvoicesThatHaveDues();
            return dt;

        }
        private void عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DgvForAll.DataSource = GetAllSingleInvoicesThatHaveDues();
        }

        private void عرضالفواتيرالتيعليهامستحقاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DgvForAll.DataSource = GetAllSMultiInvoicesThatHaveDues();
        }

        private void تسدبدجزءمنالمستحقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PayDues = new FrmPayPartOfDuesForMultiSales(Convert.ToInt32(DgvForAll.CurrentRow.Cells[0].Value), ref DgvForAll, float.Parse(DgvForAll.CurrentRow.Cells[2].Value.ToString()), float.Parse(DgvForAll.CurrentRow.Cells[3].Value.ToString()));
            PayDues.ShowDialog();
        }

        private void تسديدجزءمنالمستحقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //send the id , the datageridveiw to refresh it , the total dues price to prevent user from pay all dues when on frmPayPartdues and PaymentStatueTableId to update it
            Form Paydues = new FrmPayPartOfDues(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value), ref DgvForAll, float.Parse(DgvForAll.CurrentRow.Cells["مستحق"].Value.ToString()), Convert.ToInt32(DgvForAll.CurrentRow.Cells[14].Value));
            Paydues.ShowDialog();
        }


        private void AddSingleSalesColoumsToDataTable( ref DataTable dt)
        {
            dt.Columns.Add("مسلسل", typeof(BigInteger));
            dt.Columns.Add("اسم الشاري", typeof(string));
            dt.Columns.Add("اسم المنتج", typeof(string));
            dt.Columns.Add("الكميه", typeof(string));
            dt.Columns.Add("السعر المدفوع", typeof(string));
            dt.Columns.Add("الخصم", typeof(string));
            dt.Columns.Add("السعر بعد الخصم", typeof(string));
            dt.Columns.Add("السعر المتبقي علي العميل", typeof(string));
            dt.Columns.Add("حاله الدفع", typeof(string));
            dt.Columns.Add("التاريخ", typeof(string));
            dt.Columns.Add(" اللون", typeof(string));
            dt.Columns.Add("المقاس", typeof(string));
            dt.Columns.Add("رقم هاتف الشاري", typeof(string));
    


        }
        private void عرضالتفاصيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable AllSingleSalesThatInTheMulti_SalesInvoice =SingleSales.GetAllSingleSalesWhichInMultiInvoice(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value));
       
            Form Frm = new FrmTheDetailsOfMultiInvoice(AllSingleSalesThatInTheMulti_SalesInvoice);
            Frm.ShowDialog(); 
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClsLogOutDates.AddNew(DateTime.Now, CurrentUserInfo.UserId);
            _LogIn.Close();
        }

     
        private bool PayMonthlySalary(BigInteger EmployeeID)
        {
          return  ClsEmployees.MakeSalaryPayedForEmployee(EmployeeID);
        }

        private void دفعالراتبالشهريToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (PayMonthlySalary(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("تم فع الراتب بنجاح وتعين حاله الراتب الي مدفوع");
                DgvForAll.DataSource = RefreshAllEmployees();

            }
            else
            {
                MessageBox.Show("حدث خطا");

            }
        }
        private bool SubmitResignation(BigInteger EmployeeID)
        {
            return ClsEmployees.SubmitResignationForAnEmployee(EmployeeID);
        }
        private void تقديمالاستقالهToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if( SubmitResignation(Convert.ToInt64(DgvForAll.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("تم تقديم الاستقاله بنجاح وتعين تاريخ اليوم في حقل الاستقاله");
                DgvForAll.DataSource = RefreshAllEmployees();
            }
            else
            {
                MessageBox.Show("حدث خطا");

            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            _LogIn.Close();
            this.Close();
       
        }

        private void تسجيلاتالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }
    }

    }



    

