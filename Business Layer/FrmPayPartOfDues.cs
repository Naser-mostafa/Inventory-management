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

    public partial class FrmPayPartOfDues : Form
    {
        struct InvoiceInfo
        {
            public BigInteger InvoiceId;
            public DataGridView DgvForAll;
            public float TotalDuesAmount;
            public int PaymentStatueId;
        }
        InvoiceInfo CurrentInvoiceInfo = new InvoiceInfo();

        public FrmPayPartOfDues(BigInteger InvoiceId,ref DataGridView DgvForAll,float TotalDuesPrice,int PaymentStatueId)
        {
            CurrentInvoiceInfo.DgvForAll = DgvForAll;
            CurrentInvoiceInfo.InvoiceId = InvoiceId;
            CurrentInvoiceInfo.PaymentStatueId = PaymentStatueId;
            CurrentInvoiceInfo.TotalDuesAmount = TotalDuesPrice;
            InitializeComponent();
        }
        private bool PayDues()
        {
          return  SingleSales.PayPartOfDues(CurrentInvoiceInfo.InvoiceId, float.Parse(TxPayedDues.Text), CurrentInvoiceInfo.PaymentStatueId);
        }
        private void btnPayDues_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxPayedDues.Text))
            {
                errorProvider1.SetError(TxPayedDues, "الحقل فارغ");
            }
            else
            {
                if (float.Parse(TxPayedDues.Text) < CurrentInvoiceInfo.TotalDuesAmount)
                {
                    if (PayDues())
                    {
                        CurrentInvoiceInfo.DgvForAll.DataSource = SingleSales.GetAllSales();
                        MessageBox.Show("تم الدفع بنجاح وتم زياده السعر المبدئي المدفوع بنسبه  ", TxPayedDues.Text);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("لا يمكنك دفع المبلغ المستحق كامل في قائمه دفع جزء من المبلغ المستحق");
                }
            }
       
        }
    }
}
