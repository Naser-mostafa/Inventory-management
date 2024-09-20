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

namespace UhlSport
{
    public partial class FrmPayPartOfDues : Form
    {
        DataGridView _DgvForAll;
        BigInteger _InvoiceId;
        float _Totalprice;
        int _PaymentStatueID;
        public FrmPayPartOfDues(BigInteger InvoiceId, ref DataGridView dgvForAll,float TotalPrice,int PaymentStatueID)
        {
            _DgvForAll=dgvForAll;
            _PaymentStatueID = PaymentStatueID;
            _InvoiceId = InvoiceId;
            _Totalprice = TotalPrice;
            InitializeComponent();
        }
        private bool PayTheRemainderofDues(float Remainder,BigInteger InvoiceId,int PaymentStatueID)
        {
            return SingleSales.PayPartOfDues(InvoiceId, Remainder, PaymentStatueID);
        }
        private void btnPayRemainderOfDues_Click(object sender, EventArgs e)
        {
            if(float.Parse(txDues.Text)==_Totalprice)
            {
                MessageBox.Show("هذا المبلغ هو كل المستحقات وهنا لتسديد جزء فقط من المستحقات ");
            }
            else
            {
             if(   PayTheRemainderofDues(float.Parse(txDues.Text),_InvoiceId, _PaymentStatueID))
                {
                    MessageBox.Show("تم الدفع بنجاح");
                    _DgvForAll.DataSource = SingleSales.GetAllSales();
                }
                else
                {
                    MessageBox.Show("حدث خطأ");

                }
            }
        }
    }
}
