using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UhlSportDataAccessLayer;
using System.Drawing.Imaging;
using System.Xml.Linq;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Math;
using Math.Gmp.Native;
using FaisalSport;

namespace FaisalSport
{
    public partial class FrmInvoice : Form
    {

        private class InvoiceInfo
        {
            public string Country, Email, BankAcc, BankName, SalesManagerNumber,ImagePath;
            public DataTable InvoicesTable = new DataTable();
            public float TotalPrice, PayedAmount;
        }
        InvoiceInfo CurrentInvoice = new InvoiceInfo();
        public FrmInvoice(DataTable InvoiceTable, BigInteger InvoiceID, string ClientFullName)
        {
            InitializeComponent();
            LbInvoiceNumber.Text = InvoiceID.ToString();

            //get total amount
            object totalAmount = InvoiceTable.Compute("Sum(الاجمالي)", string.Empty);
            float TotalAmount = float.Parse(totalAmount.ToString());
            CurrentInvoice.TotalPrice = TotalAmount;
            //get total of payed price
            object payedprice = InvoiceTable.Compute("Sum([السعر المدفوع])", string.Empty);
            float PayedPeice = float.Parse(payedprice.ToString());
            CurrentInvoice.PayedAmount = PayedPeice;
            //get total dues
            float totalDues = TotalAmount - PayedPeice;
            //add dues column 
           
            InvoiceTable.Rows.Add(0, "_", 0, 0, 0, PayedPeice, TotalAmount, totalDues);
            CurrentInvoice.InvoicesTable = InvoiceTable;
            this.LbInvoiceTo.Text = ClientFullName;


        }
        private void creatingTableTiSpecifyTheTotalAmountAndTheDues(ref DataTable dt)
        {
            dt.Columns.Add("الاجمالي", typeof(float));
            dt.Columns.Add("المبلغ المدفوع", typeof(float));
            dt.Columns.Add("المستحق", typeof(float));
        }
        private void ResizeTheDataFridVeiwContent()
        {
            DgvInvoice.DataSource = CurrentInvoice.InvoicesTable;
            // تعيين حجم الأعمدة تلقائياً استناداً إلى محتوى الخلايا
            DgvInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // تعيين حجم الصفوف تلقائياً استناداً إلى محتوى الخلايا
            DgvInvoice.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void GetInfoOnInvoiceFromDataAccesLayer()
        {
            //this func will call data access layer
            ClsInvoiceInformation.GetnInvoiceInfo(ref CurrentInvoice.Country, ref CurrentInvoice.Email, ref CurrentInvoice.BankAcc, ref CurrentInvoice.BankName, ref CurrentInvoice.SalesManagerNumber,ref CurrentInvoice.ImagePath);
        }
        private void SetInfoIntoLabelsOnDesign()
        {
            lbCountry.Text = CurrentInvoice.Country;
            LbBankAcoount.Text = CurrentInvoice.BankAcc;
            LbBAnkName.Text = CurrentInvoice.BankName;
            LbSalesManger.Text = CurrentInvoice.SalesManagerNumber;
            LbEmail.Text = CurrentInvoice.Email;
            LogoPicture.ImageLocation = CurrentInvoice.ImagePath;
            
        }
        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            DgvInvoice.RightToLeft = RightToLeft.Yes;
            btnSavePhoto.Text = "Save PDF File";
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.Sizable;
            LbDate.Text = Convert.ToString(DateTime.Now);
            if (CurrentInvoice.TotalPrice - CurrentInvoice.PayedAmount == 0)
            {
                LbPaymentStatue.Text = "مدفوع";
                TxDueDate.Text = "مدفوع";
            }
            else
            {
                LbPaymentStatue.Text = "أجل";

            }
            DataTable DuesAndTotalTable = new DataTable();
            creatingTableTiSpecifyTheTotalAmountAndTheDues(ref DuesAndTotalTable);
            DuesAndTotalTable.Rows.Add(CurrentInvoice.TotalPrice, CurrentInvoice.PayedAmount, CurrentInvoice.TotalPrice - CurrentInvoice.PayedAmount);
            DgvInvoice.DataSource = CurrentInvoice.InvoicesTable;
            ResizeTheDataFridVeiwContent();
            GetInfoOnInvoiceFromDataAccesLayer();
            SetInfoIntoLabelsOnDesign();

        }

        // Hide buttons and other elements




        private void btnSavePhoto_Click(object sender, EventArgs e)
            {
            btnSavePhoto.Hide();
            LbEditINvoice.Hide();
            this.Text = "";
            this.ControlBox = false;

            // Hide all buttons
            foreach (Control control in this.Controls)
            {
                if (control is Button && control is ScrollBars)

                {
                    control.Hide();
                }
            }

            // Calculate the total height needed for the DataGridView
            int totalDataGridViewHeight = DgvInvoice.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + DgvInvoice.ColumnHeadersHeight;

            // Adjust the DataGridView height to fit all rows
            DgvInvoice.Height = totalDataGridViewHeight;

            // Adjust the form height to fit the DataGridView
            this.Height = DgvInvoice.Bottom + 100; // Add some padding for the form

            // Create a bitmap to draw the entire form
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(formBitmap, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));

            // Create a new PDF document
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Invoice as PDF";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    using (Document document = new Document(new iTextSharp.text.Rectangle(0, 0, formBitmap.Width, formBitmap.Height)))
                    {
                        try
                        {
                            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                            document.Open();

                            // Convert the form bitmap to iTextSharp image
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                formBitmap.Save(memoryStream, ImageFormat.Bmp);
                                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(memoryStream.ToArray());

                                // Add the image to the PDF document
                                document.Add(pdfImage);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                        finally
                        {
                            document.Close();
                            foreach (Control control in this.Controls)
                            {
                                if (control is Button && control is ScrollBars)

                                {
                                    control.Show();
                                }
                            }
                        }
                    }
                }
            }

            // Restore the original form size if it was modified
            this.ClientSize = new Size(this.Width, this.Height);

            // Show buttons and other elements again
            btnSavePhoto.Show();
            LbEditINvoice.Show();
            this.ControlBox = true;

            MessageBox.Show("Invoice saved as PDF successfully.");
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LbEditINvoice_Click(object sender, EventArgs e)
        {
            ClsInvoiceInformation.GetnInvoiceInfo(ref CurrentInvoice.Country, ref CurrentInvoice.Email, ref CurrentInvoice.BankAcc, ref CurrentInvoice.BankName, ref CurrentInvoice.SalesManagerNumber, ref CurrentInvoice.ImagePath);
            Form EditInvoiceInfo = new ClsEditInvoice(CurrentInvoice.Country, CurrentInvoice.Email, CurrentInvoice.BankAcc, CurrentInvoice.BankName, CurrentInvoice.SalesManagerNumber, CurrentInvoice.ImagePath);
            EditInvoiceInfo.ShowDialog();
            GetInfoOnInvoiceFromDataAccesLayer();
            SetInfoIntoLabelsOnDesign();
        }
    }
    }
