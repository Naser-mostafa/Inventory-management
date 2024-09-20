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
    public partial class FrmAddEditCustmor : Form
    {
        DataGridView dgvForAll;
        public FrmAddEditCustmor(BigInteger CustmorID,ref DataGridView dgv)
        {
            InitializeComponent();
            dgvForAll = dgv;
            NewCustmor.CustmorId = CustmorID;
            if (CustmorID== -1)
            {
                LbAddEditClient.Text = "اضافه عميل جديد";
                CurrentMode = EnMode.AddNew;
                
            }
            else
            {
                LbAddEditClient.Text = "تعديل معلومات العميل";

                CurrentMode = EnMode.Update;
                FindByID();
                SetInfoOnTextBoxes();
            }
           
        }

        private enum EnMode
        {
            Update,AddNew
        }
        EnMode CurrentMode;
        private class ClsCustmor
        {
            public BigInteger CustmorId;
            public string FirstName, LastName, Phone="", CountryName="";
        }
        ClsCustmor NewCustmor = new ClsCustmor();

        public object DgvForAll { get; private set; }

        private bool TxFirstName_Validating()
        {
            if(string.IsNullOrEmpty(TxFirstName.Text))
            {
                TxFirstName.Focus();
                errorProvider1.SetError(TxFirstName,"ادخال الاسم الاول اجباري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private bool TxLastName_Validating()
        {
            if (string.IsNullOrEmpty(TxLastName.Text))
            {
                TxLastName.Focus();
                errorProvider1.SetError(TxLastName, "ادخال الاسم الثاني اجباري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void FindByID()
        {
            ClsCustmors.FindCustmorByID(NewCustmor.CustmorId,ref NewCustmor.FirstName,ref NewCustmor.LastName, ref NewCustmor.Phone, ref NewCustmor.CountryName);
}
        private void SetInfoOnTextBoxes()
        {
            TxFirstName.Text = NewCustmor.FirstName;
            TxLastName.Text = NewCustmor.LastName;
            TxPjone.Text = NewCustmor.Phone;
            TxCountryName.Text = NewCustmor.CountryName;
        }
        private void _GetCustmorInfo()
        {
            if(TxFirstName.Text=="لا يسمح ان يكون الحقل فارغ")
            {
                errorProvider1.SetError(TxFirstName, "لا يسمح ان يكون الحقل فارغ");
            }
            else
            {
                NewCustmor.FirstName = TxFirstName.Text;

            }

            ProcessTextboxesIfHaveNullValue();

          
        }
        private bool  _AddNewCustmor()
        {
            return ClsCustmors.AddNewCustmor(NewCustmor.FirstName, NewCustmor.LastName, NewCustmor.CountryName, NewCustmor.Phone);
        }
      private bool _UpdateCustmor()
        {
            return ClsCustmors.UpdateCustomer(NewCustmor.CustmorId, NewCustmor.FirstName, NewCustmor.LastName, NewCustmor.CountryName, NewCustmor.Phone);
        }
        private void ProcessTextboxesIfHaveNullValue()
        {
            if (TxPjone.Text == "مسموح ان يكون فارغ")
            {
                NewCustmor.Phone = "";

            }
            else
            {
                NewCustmor.Phone = TxPjone.Text;

            }
            if(TxLastName.Text== "مسموح ان يكون فارغ")
            {
                NewCustmor.LastName = "";
            }
            else
            {
                NewCustmor.LastName = TxLastName.Text;

            }
            if (TxCountryName.Text == "مسموح ان يكون فارغ")
            {
                NewCustmor.CountryName = "";

            }
            else
            {
                NewCustmor.CountryName = TxCountryName.Text;

            }
        }

        private void GetInfoFromTextBoxesIntoClsCustmors()
        {
            NewCustmor.FirstName = TxFirstName.Text;
            NewCustmor.LastName = TxLastName.Text;
            NewCustmor.CountryName = TxCountryName.Text;
            NewCustmor.Phone = TxPjone.Text;
        }
        private void BtnSaveClient_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case EnMode.AddNew:
                    _GetCustmorInfo();
                  if ( _AddNewCustmor()&& TxFirstName_Validating()&& TxLastName_Validating())
                    {
                        MessageBox.Show("تمت الاضافه بنجاح");
                        dgvForAll.DataSource = ClsCustmors.GetAllCustmors();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("تعذرت عمليه الاضافه");
                        this.Close();
                    }
                    break;
                case EnMode.Update:
                    GetInfoFromTextBoxesIntoClsCustmors();
                    if (_UpdateCustmor())
                    {
                      dgvForAll.DataSource= FrmMain.RefreshAllProducts();
                    //    FrmMain.اضفعميلجديدToolStripMenuItem_Click();
                        MessageBox.Show("تمت التعديل بنجاح");
                        this.Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("فشلت العمليه");
                        
                        this.Close();
                    }
                    
          
                    break;
            }
        }


        private void TxFirstName_MouseEnter(object sender, EventArgs e)
        {
            if(TxFirstName.Text== "لا يسمح ان يكون الحقل فارغ")
            {
                TxFirstName.Text = "";
            }

        }

        private void TxLastName_MouseEnter(object sender, EventArgs e)
        {
            if (TxLastName.Text == "مسموح ان يكون فارغ")
            {
                TxLastName.Text = "";
            }
        }

        private void TxPjone_MouseEnter(object sender, EventArgs e)
        {
            if (TxPjone.Text == "مسموح ان يكون فارغ")
            {
                TxPjone.Text = "";
            }
        }

        private void TxCountryName_MouseEnter(object sender, EventArgs e)
        {
            if (TxCountryName.Text == "مسموح ان يكون فارغ")
            {
                TxCountryName.Text = "";
            }
        }

        private void FrmAddEditCustmor_Load(object sender, EventArgs e)
        {

        }
    }
}
