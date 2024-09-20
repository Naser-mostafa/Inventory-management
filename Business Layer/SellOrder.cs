using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using UhlSportDataAccessLayer;
using FaisalSport.Properties;
using System.Drawing.Imaging;
using System.IO;

namespace FaisalSport
{
    public partial class SellOrder : Form
    {
        DataGridView DgvForProduct;
        public class ProductInfo
        {
            public BigInteger ProductID;
            public string ProductName, ImagePath;
            public float SellingPrice, BuingPrice;
            public int ColorID, SizeID, Quantity;
        }
        public ProductInfo CurrentProductDetails = new ProductInfo();
        private void _GetProductInfoByIdIntoTheGlobalObject(BigInteger ProductID)
        {
            CLsProducts.GetProductInfoByID(ProductID, ref CurrentProductDetails.ProductName, ref CurrentProductDetails.BuingPrice, ref CurrentProductDetails.SellingPrice, ref CurrentProductDetails.ColorID, ref CurrentProductDetails.SizeID, ref CurrentProductDetails.Quantity, ref CurrentProductDetails.ImagePath);
        }
        public SellOrder(int ProductID, DataGridView dgvForproduct)
        {
            InitializeComponent();
            DgvForProduct = dgvForproduct;
            CurrentProductDetails.ProductID = ProductID;
            _GetProductInfoByIdIntoTheGlobalObject(CurrentProductDetails.ProductID);
           
        }
        public DataTable InvoiceTable = new DataTable();
        public class ClientsInfo
        {
            public int ClientId;
            public string FirstName;
            public string LastName;
            public string Phone;
            public string Country;
        }
        public ClientsInfo CurrentClientDetails = new ClientsInfo();
        private DataTable _GetAllClietnsInfo()
        {
            return ClsCustmors.GetAllCustmors();
        }
        private void _AddProductNameAndImagePath()
        {
            LbClinetName.Text = CurrentClientDetails.FirstName + " " + CurrentClientDetails.LastName;
        }
    
        private void SellOrder_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            LbAddNewClient.Show();
       //     ScrollToControl(this);
            DgvForClientsAndProducts.DataSource = _GetAllClietnsInfo();
            _FillDataTableWithColoumsDetails();
            btnInvoices.Visible = false;
            LbClinetName.Text = "";
            LBClinetProductName.Text = "اسم العميل : ";
            NupQuantity.Maximum = CurrentProductDetails.Quantity;
            DgvForClientsAndProducts.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            DgvForClientsAndProducts.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            LbPurchase.Text = CurrentProductDetails.ProductName+"\n";
            NupDiscount.Enabled = false;
            TxGetTheProduct.Hide();
            TxGetTheClientName.Show();
            TxTotalPrice.Enabled = false;
            TxPriceAfterDiscount.Enabled = false;
            // give the struct the intital value
            CurrentMultipleInvoice.ProductsId = 0; CurrentMultipleInvoice.TotalPrice = 0; CurrentMultipleInvoice.intialPayedPrice = 0; CurrentMultipleInvoice.SingleSalesID = 0;

        }
        private void TxGetTheOrderName_TextChanged(object sender, EventArgs e)
        {
            DgvForClientsAndProducts.DataSource = ClsCustmors.FindCustmorByName(TxGetTheClientName.Text);
        }
        private void NupQuantity_ValueChanged(object sender, EventArgs e)
        {
            TxTotalPrice.Text = ((CurrentProductDetails.SellingPrice) * ((float)(NupQuantity.Value))).ToString();
            TxPriceAfterDiscount.Text = TxTotalPrice.Text;
            float totalPrice = CurrentProductDetails.SellingPrice * (float)NupQuantity.Value;
            TxTotalPrice.Text = totalPrice.ToString();

            // حساب قيمة الخصم
            float discountAmount = (totalPrice * (float)NupDiscount.Value) / 100;

            // حساب السعر بعد الخصم
            float priceAfterDiscount = totalPrice - discountAmount;
            TxPriceAfterDiscount.Text = priceAfterDiscount.ToString();
        }
        private bool _TxTotalPrice_Validating()
        {
            if (string.IsNullOrEmpty(TxTotalPrice.Text))
            {
                errorProvider1.SetError(TxTotalPrice, "ادخال السعر الاجمالي مهم");
                TxTotalPrice.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool _TxInitalPrice_Validating()
        {
            if (string.IsNullOrEmpty(TxInitalPrice.Text))
            {
                errorProvider1.SetError(TxInitalPrice, "ادخال السعر المبدئي المدفوع مهم حتي ولو كان صفر");
                TxInitalPrice.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool _TxQuantity_Validating()
        {
            if (NupQuantity.Value == 0)
            {
                errorProvider1.SetError(NupQuantity, "يجب ان تكون الكميه علي لاقل قطعه واحده");
                NupQuantity.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void NupDiscount_ValueChanged(object sender, EventArgs e)
        {
            float totalPrice;
            if (!float.TryParse(TxTotalPrice.Text.ToString(), out totalPrice))
            {
                // إذا فشل التحويل، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                //    MessageBox.Show("Invalid total price value.");
                return;
            }

            // تحويل قيمة الخصم إلى float مباشرةً دون تحويل إلى نص ثم float
            float discount = (float)NupDiscount.Value;

            // حساب السعر بعد الخصم
            float priceAfterDiscount = totalPrice * (1 - (discount / 100));

            // تعيين قيمة السعر بعد الخصم في النص
            TxPriceAfterDiscount.Text = priceAfterDiscount.ToString();

        }
        private void ChkDisCount_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDisCount.Checked)
            {
                NupDiscount.Enabled = true;
            }
            else
            {
                NupDiscount.Enabled = false;

            }
        }
        private bool _ISUSerCHooseTheClientOrProduct()
        {
            if (LbClinetName.Text == "")
            {
                errorProvider1.SetError(LBClinetProductName, "يجب اختيار المنتج او العميل من قاعده البيانات");
                DgvForClientsAndProducts.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }


        private static void QuantityLessSex(string ProductName)
        {
            MessageBox.Show($"    اصبحت الكميه من الصنف ({ProductName})       اقل من ست قطع");

        
            
        }



        private static Icon ConvertBitmapToIcon(Bitmap iconProductLess6)
        {
            throw new NotImplementedException();
        }

        public struct SalesOperation
        {
            public float PriceAfterDisCount, TotalPrice, initialPayedPrice, RemainderPrice;
            public int Quantity;
            public int PaymentStatueID, ClientID;
            public BigInteger ProductID;
        }
        public SalesOperation CurrentOperationDetails = new SalesOperation();
        private void fillCurrentOperationDetailsWithProductInfo()
        {
            CurrentOperationDetails.TotalPrice = float.Parse(TxTotalPrice.Text);
            CurrentOperationDetails.ProductID = CurrentProductDetails.ProductID;
            CurrentOperationDetails.ClientID = CurrentClientDetails.ClientId;
            CurrentOperationDetails.PriceAfterDisCount = float.Parse(TxPriceAfterDiscount.Text);
            CurrentOperationDetails.Quantity = Convert.ToInt32(NupQuantity.Value);
            CurrentOperationDetails.initialPayedPrice = float.Parse(TxInitalPrice.Text);
            CurrentOperationDetails.RemainderPrice = CurrentOperationDetails.PriceAfterDisCount - CurrentOperationDetails.initialPayedPrice;
        }
        private void _InsertIntoPaymentsAndFillStSalesOpertionInfo()
        {
            string[] Payment_Statue = { "مدفوع", "اجل" };
            if (NupQuantity.Value != 0 && _ISUSerCHooseTheClientOrProduct() && _TxTotalPrice_Validating() && _TxInitalPrice_Validating() && _TxQuantity_Validating())
            {
                fillCurrentOperationDetailsWithProductInfo();
                if (ValidateOnPayedPriceShoudBeLessTotalPrice())
                {
                    if (CurrentOperationDetails.RemainderPrice == 0)
                        CurrentOperationDetails.PaymentStatueID = PaymentsStatues.AddNewPayment(CurrentOperationDetails.RemainderPrice, Payment_Statue[0], Notes.Text);
                    else
                        CurrentOperationDetails.PaymentStatueID = PaymentsStatues.AddNewPayment(CurrentOperationDetails.RemainderPrice, Payment_Statue[1], Notes.Text);
                }

            }
        }
        private BigInteger AddInvoiceForMultiSales()
        {
            // inserting the information into the related table first
            _InsertIntoPaymentsAndFillStSalesOpertionInfo();

            //inserting Order On the Sales And Purchases Table
            DateTime now = DateTime.Now;
            // this function will call data access layer to update qyantity on the database
            if (CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity >= 0)
            {

                if (CLsProducts.UpdateQuantity(CurrentOperationDetails.ProductID, (CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity)))
                {
                    //if quantity become less than 6 show notifyicon
                    if ((CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity) <= 6)
                    {
                        QuantityLessSex(CurrentProductDetails.ProductName);
                    }

                    BigInteger MultiSalesID = ClsMultipleinvoices.GetTheLastID();
                    BigInteger SingSalesID = SingleSales.GetTheLastID();

                    {

                        return SingleSales.AddNewOperation(++SingSalesID, CurrentOperationDetails.Quantity, now, CurrentOperationDetails.TotalPrice, CurrentOperationDetails.initialPayedPrice, CurrentOperationDetails.ProductID, CurrentOperationDetails.ClientID, CurrentOperationDetails.PaymentStatueID, Convert.ToByte(NupDiscount.Value), CurrentOperationDetails.PriceAfterDisCount, ++MultiSalesID);

                    }
                
                }


            }
            else
            {
                return 0;
            }

            return 0;


        }
        private BigInteger AddInvoiceForSingleSales()
        {
            // inserting the information into the related table first
            _InsertIntoPaymentsAndFillStSalesOpertionInfo();

            //inserting Order On the Sales And Purchases Table
            DateTime now = DateTime.Now;
            // this function will call data access layer to update qyantity on the database
            if (CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity >= 0)
            {
              
                if (CLsProducts.UpdateQuantity(CurrentOperationDetails.ProductID, (CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity)))
                {
                    //if quantity become less than 6 show notifyicon
                  if( (CurrentProductDetails.Quantity - CurrentOperationDetails.Quantity)<=6)
                    {
                        QuantityLessSex(CurrentProductDetails.ProductName);
                    }

                    //using binary to presend Invoices into Single One by Adding All Id As one
                    
                
                    {
                        BigInteger SingleSalesID = SingleSales.GetTheLastID(); 

                        return SingleSales.AddNewOperation(++SingleSalesID, CurrentOperationDetails.Quantity, now, CurrentOperationDetails.TotalPrice, CurrentOperationDetails.initialPayedPrice, CurrentOperationDetails.ProductID, CurrentOperationDetails.ClientID, CurrentOperationDetails.PaymentStatueID, Convert.ToByte(NupDiscount.Value ), CurrentOperationDetails.PriceAfterDisCount, 0);

                    }
                  
                }
            }
            else
            {
                return 0;
            }

            return 0;


        }
        private void _returnTheDefault()
        {

            DgvForClientsAndProducts.DataSource = CLsProducts.GetAllProductsInfo();

            CurrentProductDetails = new ProductInfo();
            CurrentOperationDetails = new SalesOperation();
            TxTotalPrice.Text = "";
            NupDiscount.Value = 0;
          LbClinetName.Text = "";
            TxPriceAfterDiscount.Text = "";
            TxInitalPrice.Text = "";
            LBClinetProductName.Text = "اسم المنتج";
            BtnGetInvoice.Visible = false;
            btnInvoices.Visible = true;
            NupQuantity.Value = 0;
            DgvForClientsAndProducts.ContextMenuStrip = contextMenuStripForProduct;

        }
        private bool ValidateOnPayedPriceShoudBeLessTotalPrice()
        {
            if (CurrentOperationDetails.initialPayedPrice <= CurrentOperationDetails.PriceAfterDisCount)
            {
                errorProvider1.Clear();
                return true;

            }
            else
            {
                errorProvider1.SetError(TxInitalPrice, "السعر المبدائي يجب ان يكون اصغر من او يساوي السعر بعد الخصم");
                TxInitalPrice.Focus();
                return false;
            }
        }
        short InvoiceNumber = 1;
        public struct MultipleInvoice
        {
            public float TotalPrice, intialPayedPrice, PriceAfterDiscount;
            public BigInteger ProductsId, SingleSalesID;

        }

        MultipleInvoice CurrentMultipleInvoice = new MultipleInvoice();

        private void TxGetTheProduct_TextChanged(object sender, EventArgs e)
        {
            DgvForClientsAndProducts.DataSource=CLsProducts.FindByProductThatNameStartWithName(TxGetTheProduct.Text);
        }
        private void اختياركشاريToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentClientDetails.ClientId = Convert.ToInt32(DgvForClientsAndProducts.CurrentRow.Cells[0].Value);
            ClsCustmors.FindCustmorByID(CurrentClientDetails.ClientId, ref CurrentClientDetails.FirstName, ref CurrentClientDetails.LastName, ref CurrentClientDetails.Phone, ref CurrentClientDetails.Country);
            _AddProductNameAndImagePath();
        }
        private void _FillDataTableWithColoumsDetails()
        {
            InvoiceTable.Columns.Add("الرقم", typeof(int));
            InvoiceTable.Columns.Add("الصنف", typeof(string));
            InvoiceTable.Columns.Add("الكميه", typeof(int));
            InvoiceTable.Columns.Add("سعر القطعه", typeof(float));
            InvoiceTable.Columns.Add("الخصم", typeof(byte));
            InvoiceTable.Columns.Add("السعر المدفوع", typeof(float));
            InvoiceTable.Columns.Add("الاجمالي", typeof(float));
            InvoiceTable.Columns.Add("المستحقات", typeof(float));
        }
        
        private void BtnGetInvoice_Click(object sender, EventArgs e)
        {
            BigInteger InsertedId = AddInvoiceForSingleSales();
            if (InsertedId != 0)
            {
                //if not equal 0 mean that the Opeartion added successfully
                string ClientFullName = CurrentClientDetails.FirstName + ' ' + CurrentClientDetails.LastName;
                InvoiceTable.Rows.Add(InvoiceNumber, CurrentProductDetails.ProductName, CurrentOperationDetails.Quantity,
                    CurrentProductDetails.SellingPrice, NupDiscount.Value.ToString(),
                    CurrentOperationDetails.initialPayedPrice, CurrentOperationDetails.PriceAfterDisCount,
                    (CurrentOperationDetails.PriceAfterDisCount - CurrentOperationDetails.initialPayedPrice)
                   );
                Form GoToINvoiceForm = new FrmInvoice(InvoiceTable, SingleSales.GetTheLastID(), ClientFullName);
                GoToINvoiceForm.ShowDialog();
                DgvForProduct.DataSource = CLsProducts.GetAllProductsInfo();
                this.Close();
            }

        }
        private void _setInfoIntoDesign()
        {
            LbPurchase.Text +=  CurrentProductDetails.ProductName+"\n";
            LbClinetName.Text = CurrentProductDetails.ProductName;
            // حساب السعر الإجمالي
            float totalPrice = CurrentProductDetails.SellingPrice * (float)NupQuantity.Value;
            TxTotalPrice.Text = totalPrice.ToString();

            // حساب قيمة الخصم
            float discountAmount = (totalPrice * (float)NupDiscount.Value) / 100;

            // حساب السعر بعد الخصم
            float priceAfterDiscount = totalPrice - discountAmount;
            TxPriceAfterDiscount.Text = priceAfterDiscount.ToString();

        }
        private void اختيارالمنتجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentProductDetails.ProductID = Convert.ToInt32(DgvForClientsAndProducts.CurrentRow.Cells[0].Value);
            CLsProducts.GetProductInfoByID(CurrentProductDetails.ProductID, ref CurrentProductDetails.ProductName, ref CurrentProductDetails.BuingPrice, ref CurrentProductDetails.SellingPrice, ref CurrentProductDetails.ColorID, ref CurrentProductDetails.SizeID, ref CurrentProductDetails.Quantity, ref CurrentProductDetails.ImagePath);
            NupQuantity.Maximum = CurrentProductDetails.Quantity;
            _setInfoIntoDesign();
        }
        private void BtnAddMore_Click(object sender, EventArgs e)
        {
            LbAddNewClient.Hide();
            TxGetTheProduct.Show();
            TxGetTheClientName.Hide();
            ChooseProductAndClient.Text = "اختر المنتج من فضلك";
            if (NupQuantity.Value != 0 && ValidateOnPayedPriceShoudBeLessTotalPrice() && _ISUSerCHooseTheClientOrProduct() && _TxInitalPrice_Validating() && _TxQuantity_Validating())
            {
                BigInteger Inserted_ID = AddInvoiceForMultiSales();
                if (Inserted_ID != 0)
                {
                    // this is for get the total Information
                    InvoiceTable.Rows.Add(InvoiceNumber, CurrentProductDetails.ProductName, CurrentOperationDetails.Quantity,
                                     CurrentProductDetails.SellingPrice, NupDiscount.Value.ToString(),
                                     CurrentOperationDetails.initialPayedPrice, CurrentOperationDetails.PriceAfterDisCount,
                                     (CurrentOperationDetails.PriceAfterDisCount - CurrentOperationDetails.initialPayedPrice));
                    CurrentMultipleInvoice.SingleSalesID += Inserted_ID;
                    CurrentMultipleInvoice.ProductsId += CurrentProductDetails.ProductID;
                    CurrentMultipleInvoice.TotalPrice += CurrentOperationDetails.PriceAfterDisCount;
                    CurrentMultipleInvoice.PriceAfterDiscount += CurrentOperationDetails.PriceAfterDisCount;
                    CurrentMultipleInvoice.intialPayedPrice += CurrentOperationDetails.initialPayedPrice;
                    InvoiceNumber++;
                    _returnTheDefault();

                }
                else
                {
                    MessageBox.Show("الكميه غير كافيه يرجي الانتباه الي الكميه المتوفره  ");
                    
                }
            }
        }
        private void FillMultiInvoiceWithSingleIncoices(BigInteger InsertedId)
        {
            CurrentMultipleInvoice.SingleSalesID += InsertedId;
            CurrentMultipleInvoice.ProductsId += CurrentProductDetails.ProductID;
            CurrentMultipleInvoice.TotalPrice += CurrentOperationDetails.PriceAfterDisCount;
            CurrentMultipleInvoice.PriceAfterDiscount += CurrentOperationDetails.PriceAfterDisCount;
            CurrentMultipleInvoice.intialPayedPrice += CurrentOperationDetails.initialPayedPrice;
        }
        private void btnInvoices_Click(object sender, EventArgs e)
        {
            //recommented to be notifyIcon instead of messageBox
            
            BigInteger Inserted_ID = AddInvoiceForMultiSales();
            if (Inserted_ID != 0)
            {
                MessageBox.Show("تم اضافه الفاتوره الي قائمه الفواتير المدمجه علما بأن الفاتوره المدمجه هي في الاصل تتكون من فواتير فرديه متداخله لذا تم تسجيل  الفواتير الفرديه ايضا في سجل الفواتير الفرديه   ");
                FillMultiInvoiceWithSingleIncoices(Inserted_ID);
                string ClientFullName = CurrentClientDetails.FirstName + ' ' + CurrentClientDetails.LastName;
                InvoiceTable.Rows.Add(InvoiceNumber, CurrentProductDetails.ProductName, CurrentOperationDetails.Quantity,
                                 CurrentProductDetails.SellingPrice, NupDiscount.Value.ToString(),
                                 CurrentOperationDetails.initialPayedPrice, CurrentOperationDetails.PriceAfterDisCount,
                                 (CurrentOperationDetails.PriceAfterDisCount - CurrentOperationDetails.initialPayedPrice)
                                ); 
                BigInteger InvoiceNumbers = ClsMultipleinvoices.AddNewInvoice(DateTime.Now, CurrentMultipleInvoice.TotalPrice, CurrentMultipleInvoice.intialPayedPrice , CurrentMultipleInvoice.PriceAfterDiscount - CurrentMultipleInvoice.intialPayedPrice); ;
                Form GoToINvoiceForm = new FrmInvoice(InvoiceTable, InvoiceNumbers, ClientFullName);
                GoToINvoiceForm.ShowDialog();
                DgvForProduct.DataSource = CLsProducts.GetAllProductsInfo();
                this.Close();
                
            }

        }
        // this will select the row when mouse will b on the row
        private int selectedRowIndex = -1;
        private void DgvForClientsAndProducts_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvForClientsAndProducts.RowCount > 0)
            {
                if (selectedRowIndex != -1 && selectedRowIndex < DgvForClientsAndProducts.RowCount)
                {
                    DgvForClientsAndProducts.Rows[selectedRowIndex].Selected = false;
                }

                // تحديد الصف الجديد
                if (e.RowIndex >= 0 && e.RowIndex < DgvForClientsAndProducts.RowCount)
                {
                    DgvForClientsAndProducts.CurrentCell = DgvForClientsAndProducts.Rows[e.RowIndex].Cells[0]; // اختر الخلية الأولى في الصف
                    DgvForClientsAndProducts.Rows[e.RowIndex].Selected = true;
                    selectedRowIndex = e.RowIndex;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmAddNewClient = new FrmAddEditCustmor(-1,ref DgvForClientsAndProducts);
            frmAddNewClient.ShowDialog();
        }

   
    }
}
