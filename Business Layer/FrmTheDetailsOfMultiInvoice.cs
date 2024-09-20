using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaisalSport
{
    public partial class FrmTheDetailsOfMultiInvoice : Form
    {
        DataTable Details = new DataTable();
        public FrmTheDetailsOfMultiInvoice(DataTable dt)
        {
            Details = dt;

            InitializeComponent();
        }

        private void FrmTheDetailsOfMultiInvoice_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Details;
        }
    }
}
