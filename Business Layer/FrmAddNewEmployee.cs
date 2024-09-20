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
using System.Xml.Schema;
using UhlSportDataAccessLayer;

namespace FaisalSport
{
              //  CbDepartments.SelectedIndex = 0;
            // CbCountries.SelectedIndex = 0;
    public partial class FrmAddNewEmployee : Form
    {
        DataGridView Dgv;
        public FrmAddNewEmployee(int ID,ref DataGridView dgv)
        {
             Dgv = dgv;
            InitializeComponent();
            if(ID==-1)
            {
                NewEmployee.ID = ID;
                CurrentMode = EnMode.EnAddNew;
                LbAddEditEmployee.Text = "اضافه موظف جديد";

            }
            else
            {
                NewEmployee.ID = ID;
                CurrentMode = EnMode.EnUpdate;
                LbAddEditEmployee.Text = "تعديل معلومات الموظف";
            }
        }
        private class ClsEmployee
        {
            public BigInteger ID, DepartmentID, CountryID;
            public string FirstName="" , LastName , DateOfBirth ="";
           public short  Salary;

        }
         ClsEmployee NewEmployee=new ClsEmployee();
        enum EnMode
        {
            EnUpdate,EnAddNew
        }
        EnMode CurrentMode;

   
        private void GetEmployeeInfoFromTextBoxes()
        {
        //    GetAllCountriesAndDepartmentsAndSetInfoOnComboboxes();
            NewEmployee.FirstName =Convert.ToString(TxFirstName.Text);
            NewEmployee.LastName = TxLastName.Text.ToString();
            if(DtpDAteOfBirth.Value!=DateTime.MinValue)
            {
                NewEmployee.DateOfBirth = DtpDAteOfBirth.Value.ToString();
            }
            // if ==0 mean its not found else founded
            if (ClsDepartments.IsThisDepartmmentIsAlreadyExist(CbDepartments.Text)==0)
            {
                NewEmployee.DepartmentID = ClsDepartments.AddDepartmentAndReturnId(CbDepartments.Text);
            }
            else
            {
                NewEmployee.DepartmentID = ClsDepartments.IsThisDepartmmentIsAlreadyExist(CbDepartments.Text);
            }
           if(ClsCountries.IsThisCountryIsAlreadyExist(CbCountries.Text)==0)
            {
                NewEmployee.CountryID = ClsCountries.AddCountryAndReturnId(CbCountries.Text);
            }
            else
            {
                NewEmployee.CountryID = ClsCountries.IsThisCountryIsAlreadyExist(CbCountries.Text);
            }
            NewEmployee.Salary =Convert.ToInt16(TxSalary.Text);
            
        }
        private void GetAllCountriesAndDepartmentsAndSetInfoOnComboboxes()
        {
            DataTable AllCountries = ClsCountries.GetAllCountriesName();
            DataTable AllDepartments = ClsDepartments.GetAllDepartmentsName();
            SetCountriesONCompoBoxList( AllCountries);
            SetDepartmentsOnCompoBoxList( AllDepartments);
       
        }
        private void SetEmployeeInfoOnTextboxes()
        {
            ClsEmployees.FindEmployeeByID(NewEmployee.ID, ref NewEmployee.FirstName, ref NewEmployee.LastName, ref NewEmployee.DateOfBirth, ref NewEmployee.CountryID, ref NewEmployee.DepartmentID,ref NewEmployee.Salary);
            TxFirstName.Text = NewEmployee.FirstName;
            TxLastName.Text = NewEmployee.LastName;
            if(NewEmployee.DateOfBirth!="")
            {
                DtpDAteOfBirth.Value = Convert.ToDateTime(NewEmployee.DateOfBirth);
                ChkDtpStatue.Checked = true;
                DtpDAteOfBirth.Enabled = true;
            }
            TxSalary.Text =Convert.ToString(NewEmployee.Salary);
            CbCountries.Text = ClsCountries.FindCountryNameByID(NewEmployee.CountryID).ToString();
            CbDepartments.Text = ClsDepartments.FindCountryNameByID(NewEmployee.DepartmentID).ToString();
        }
        private bool AddNewEmployee()
        {
            //this will call data access layer
            return ClsEmployees.AddNewEmployee(NewEmployee.FirstName, NewEmployee.LastName, NewEmployee.DateOfBirth, NewEmployee.CountryID, NewEmployee.DepartmentID,NewEmployee.Salary);
        }
        private void GetNewInfoFromTextBoxes()
        {
            NewEmployee.FirstName = TxFirstName.Text;
            NewEmployee.LastName = TxLastName.Text;
            NewEmployee.DateOfBirth = DtpDAteOfBirth.Value.ToString();
            if(NewEmployee.DateOfBirth!="")
            {
                NewEmployee.DateOfBirth = DtpDAteOfBirth.Value.ToString();
            }
            //if uqual with 0 mean not found
            if (ClsCountries.IsThisCountryIsAlreadyExist(CbCountries.Text)==0)
            {
                NewEmployee.CountryID = ClsCountries.AddCountryAndReturnId(CbCountries.Text);
            }
            else
            {
                NewEmployee.CountryID = ClsCountries.IsThisCountryIsAlreadyExist(CbCountries.Text);
            }
            if(ClsDepartments.IsThisDepartmmentIsAlreadyExist(CbDepartments.Text)==0)
            {
                NewEmployee.DepartmentID = ClsDepartments.AddDepartmentAndReturnId(CbDepartments.Text);
            }
            else
            {
                NewEmployee.DepartmentID = ClsDepartments.IsThisDepartmmentIsAlreadyExist(CbDepartments.Text);
            }
            NewEmployee.Salary = Convert.ToInt16(TxSalary.Text);
        }
        private bool UpdateEMployee()
        {
            //this will call data access layed
            return ClsEmployees.Update(NewEmployee.ID, NewEmployee.FirstName, NewEmployee.LastName, NewEmployee.DateOfBirth, NewEmployee.CountryID, NewEmployee.DepartmentID,NewEmployee.Salary);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch(CurrentMode)
            {
                case EnMode.EnUpdate:
                {
                        GetNewInfoFromTextBoxes();
                        if(UpdateEMployee())
                        {
                            MessageBox.Show("تم التعديل بنجاح","تعديل البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dgv.DataSource = ClsEmployees.GetAllEmployees();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("لم يتم التعديل");
                        }
                    }
                    break;
                case EnMode.EnAddNew:
                    {
                        GetEmployeeInfoFromTextBoxes();
                        if (TxLastName_Validating()&& TxSalary_Validating()&& TxFirstName_Validating ()&& CbDepartments_Validating()&& CbCountries_Validating() && AddNewEmployee())
                        {
                            MessageBox.Show("تمت اضافه الموظف بنجاح الي قاعده البيانات","اضافه الموظف",MessageBoxButtons.OK,MessageBoxIcon.Information);
                             Dgv.DataSource = ClsEmployees.GetAllEmployees();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("فشلت عمليه الاضافه");
                        }
                        this.Close();
                    }
                    break;
            }
        }
        
        private void ChkDtpStatue_CheckedChanged(object sender, EventArgs e)
        {
            if(ChkDtpStatue.Checked)
            {
                DtpDAteOfBirth.Enabled = true;
            }
            else
            {
                DtpDAteOfBirth.Enabled = false;

            }
        }
        private void SetCountriesONCompoBoxList( DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                CbCountries.Items.Add(row["اسم_الدوله"].ToString());
            }
        }
        private void SetDepartmentsOnCompoBoxList(  DataTable dt)
        {
            foreach(DataRow Row in dt.Rows)
            {
                CbDepartments.Items.Add(Row["اسم_التخصص"]);
            }
        }
        private void FrmAddNewEmployee_Load(object sender, EventArgs e)
        {
            GetAllCountriesAndDepartmentsAndSetInfoOnComboboxes();
            //mean the Mode Is Add new mode
            if(NewEmployee.ID==-1)
            {
                DateTime dt = new DateTime(1900, 1, 1);
                DtpDAteOfBirth.Value = dt;
            }
            else
            {
                SetEmployeeInfoOnTextboxes();
            }
          
            if (ChkDtpStatue.Checked)
            {
                DtpDAteOfBirth.Enabled = true;
            }
            else
            {
                DtpDAteOfBirth.Enabled = false;

            }


        }
        private bool TxLastName_Validating()
        {
            if (string.IsNullOrEmpty(TxLastName.Text))
            {
                TxLastName.Focus();
                errorProvider1.SetError(TxLastName, "ادخال الاسم الخير ضروري");
                return false;
            }
            else
            {
               
                errorProvider1.Clear();
                return true;
            }
        }
        private bool CbCountries_Validating()
        {
            if (string.IsNullOrEmpty(CbCountries.Text))
            {
                CbCountries.Focus();
                errorProvider1.SetError(CbCountries, "ادخال البلد ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool CbDepartments_Validating()
        {
            if (string.IsNullOrEmpty(CbDepartments.Text))
            {
                CbDepartments.Focus();
                errorProvider1.SetError(CbDepartments, "ادخال التخصص ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;

            }
        }
        private bool TxFirstName_Validating()
        {
            if (string.IsNullOrEmpty(TxFirstName.Text))
            {
                TxFirstName.Focus();
                errorProvider1.SetError(TxFirstName, "ادخال الاسم الاول ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;

            }
        }
        private bool TxSalary_Validating()
        {
            if (string.IsNullOrEmpty(label.Text))
            {
                errorProvider1.SetError(label, "الراتب ضروري هنا");
                label.Focus();
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }

        private void TxFirstName_MouseEnter(object sender, EventArgs e)
        {
            if (TxFirstName.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxFirstName.Text = "";
            }
        }

        private void TxLastName_MouseEnter(object sender, EventArgs e)
        {
            if (TxLastName.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxLastName.Text = "";
            }
        }

 

        private void CbDepartments_MouseEnter(object sender, EventArgs e)
        {
            if (CbDepartments.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                CbDepartments.Text = "";
            }
        }

        private void CbCountries_MouseEnter(object sender, EventArgs e)
        {
            if (CbCountries.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                CbCountries.Text = "";
            }
        }

        private void TxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxSalary_MouseEnter(object sender, EventArgs e)
        {
            if (TxSalary.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxSalary.Text = "";
            }
        }

        private void TxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
