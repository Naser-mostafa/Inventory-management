using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UhlSportDataAccessLayer;

namespace FaisalSport
{
  
    public partial class ClsEditInvoice : Form
    {
        class ClsIvvoiceInfo
        {
            public string _CountryName, _Email, _SalesMangerNumber, _BankAccNumber, _BankName,_ImagePath;
        }
        public ClsEditInvoice(string CountryName,string Email,string BankAccountNumber,string BankName,string SalesMangerNumber,string ImagePath)
        {
            InitializeComponent();
            CurrentINvoiceINfo._BankAccNumber = BankAccountNumber;
            CurrentINvoiceINfo._BankName = BankName;
            CurrentINvoiceINfo._SalesMangerNumber = SalesMangerNumber;
            CurrentINvoiceINfo._CountryName = CountryName;
            CurrentINvoiceINfo._Email = Email;
            CurrentINvoiceINfo._ImagePath = ImagePath;

        }
        ClsIvvoiceInfo CurrentINvoiceINfo = new ClsIvvoiceInfo();
        private void _SetCurrentInfoIntoTextBoxes()
        {
            TxBankAccNumber.Text = CurrentINvoiceINfo._BankAccNumber;
            TxBankName.Text = CurrentINvoiceINfo._BankName;
            TxCountryName.Text = CurrentINvoiceINfo._CountryName;
            TxEmail.Text = CurrentINvoiceINfo._Email;
            TxSalesManagerName.Text = CurrentINvoiceINfo._SalesMangerNumber;
            LogoPicture.ImageLocation = CurrentINvoiceINfo._ImagePath;
        }
        private void _GetNewInfoFromTexBoxes()
        {

            CurrentINvoiceINfo._BankName = TxBankName.Text;
            CurrentINvoiceINfo._BankAccNumber = TxBankAccNumber.Text;
            CurrentINvoiceINfo._CountryName = TxCountryName.Text;
            CurrentINvoiceINfo._SalesMangerNumber = TxSalesManagerName.Text;
            CurrentINvoiceINfo._Email = TxEmail.Text;
            CurrentINvoiceINfo._ImagePath = LogoPicture.ImageLocation;
        }
        private void UpdateInfoToDataBase()
        {
            ClsInvoiceInformation.Update(CurrentINvoiceINfo._CountryName, CurrentINvoiceINfo._Email, CurrentINvoiceINfo._BankAccNumber, CurrentINvoiceINfo._BankName, CurrentINvoiceINfo._SalesMangerNumber,CurrentINvoiceINfo._ImagePath);
        }
        private void BtnSaveNewInvoiceInfo_Click(object sender, EventArgs e)
        {
            _GetNewInfoFromTexBoxes();
            UpdateInfoToDataBase();
            _SetCurrentInfoIntoTextBoxes();
            MessageBox.Show("تم بنجاح");
            this.Close();
        }
        private void ClsEditInvoice_Load(object sender, EventArgs e)
        {
            _SetCurrentInfoIntoTextBoxes();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "اختر صوره المنتج";
            openFileDialog1.Filter = "All Files(*,*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LogoPicture.ImageLocation = openFileDialog1.FileName;
                CurrentINvoiceINfo._ImagePath = openFileDialog1.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
