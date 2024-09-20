using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UhlSportDataAccessLayer;

namespace FaisalSport
{
    public partial class FrmPayPartOfDuesForMultiSales : Form
    {
        struct InvoiceDetails
        {
            public BigInteger InvoiceID;
            public DataGridView dgv;
            public float ItitalPayedPrice, TotalPrice;
            public float DueAmount;
        }
        InvoiceDetails CurrentInvoice=new InvoiceDetails();
        public FrmPayPartOfDuesForMultiSales(BigInteger InvoiceId,ref DataGridView dgv,float totalprice,float intitalPayedPrice)
        {
            CurrentInvoice.InvoiceID = InvoiceId;
            CurrentInvoice.TotalPrice = totalprice;
            CurrentInvoice.dgv = dgv;
            CurrentInvoice.ItitalPayedPrice = intitalPayedPrice;
            CurrentInvoice.DueAmount = totalprice - intitalPayedPrice;
            InitializeComponent();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxpayPartDues.Text))
            {
                errorProvider1.SetError(TxpayPartDues, "الحقل فارغ");
            }
            else
            {
                if (float.Parse(TxpayPartDues.Text) < CurrentInvoice.DueAmount)
                {
                    if (ClsMultipleinvoices.PayPartOfDues(float.Parse(TxpayPartDues.Text), CurrentInvoice.InvoiceID))
                    {
                        MessageBox.Show($"تم زياده السعر المدفوع بنسبه {TxpayPartDues.Text}", TxpayPartDues.Text);
                        CurrentInvoice.dgv.DataSource = ClsMultipleinvoices.GetAllMultipleInvoices();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكنك دفع كامل المبلغ المستحق من قائمه دفع جزء من المستحقات");
                }
            }
      
        }
    }
}
