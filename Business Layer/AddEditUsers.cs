using System;
using System.Windows.Forms;
using UhlSportDataAccessLayer;

namespace FaisalSport
{
    public partial class AddEditUsers : Form
    {
        public AddEditUsers(int UserId)
        {
            UserINfo.UserId = UserId;
            if(UserId == -1)
            {
                EnCurrentMode = Mode.EnAddNew;
            }
            else
            {
                EnCurrentMode = Mode.EnUpdate;
            }
            InitializeComponent();
        }
        enum Mode
        {
            EnAddNew,EnUpdate
        }
        Mode EnCurrentMode;
        public class ClsCurrentUserForAddAndUpdate
        {
            public int UserId;
          public  string FirstName, LastName, UserName, Password;
         public   sbyte PermissionNumber=0;
        }
        ClsCurrentUserForAddAndUpdate UserINfo =new ClsCurrentUserForAddAndUpdate();
        private void GetNewUserInformationFromTextBoxes()
        {
            UserINfo.UserName = TxEmail.Text;
            UserINfo.Password = TxPassword.Text;
            UserINfo.FirstName = TxFirstName.Text;
            UserINfo.LastName = TxLastName.Text;

        }
        private void  GetNumberofPermissionForTheNewUser()
        {
            UserINfo.PermissionNumber = 0;
            if(ChkProducts.Checked)
            {
                UserINfo.PermissionNumber += 1;
            }  
            if(chkClients.Checked)
            {
                UserINfo.PermissionNumber += 2;
            }
            if(ChkSales.Checked)
            {
                UserINfo.PermissionNumber += 4;

            }
            if (ChkEmployees.Checked)
            {
                UserINfo.PermissionNumber += 8;

            }
            if (ChkUsers.Checked)
            {
                UserINfo.PermissionNumber += 16;

            }
            if (chkLogsIn.Checked)
            {
                UserINfo.PermissionNumber += 32;

            }
            if (ChkLogOut.Checked)
            {
                UserINfo.PermissionNumber += 64;

            }
            if(UserINfo.PermissionNumber==127)
            {
                UserINfo.PermissionNumber = -1;
            }

        }
        private  void GetNewAccountINformationFromDesign()
        {
            GetNewUserInformationFromTextBoxes();
            GetNumberofPermissionForTheNewUser();
        }
        private bool AddNewUser()
        {
            //this fumction will call data access layer
          if ( ClsUser.AddNewUser(UserINfo.FirstName,UserINfo.LastName,UserINfo.UserName,UserINfo.Password,UserINfo.PermissionNumber))
            {
                return true;
            }
            return false;
        }
        private bool SetUserInfoThatWillUpdateIntoClsCurrentUserForAddAndUpdate()
        {
         return    ClsUser.GetUserInfoById(UserINfo.UserId,ref UserINfo.FirstName,ref UserINfo.LastName,ref UserINfo.UserName,ref UserINfo.Password,ref UserINfo.PermissionNumber);
        }
        private void SetUserinfoOnTextBoxes()
        {
            TxFirstName.Text = UserINfo.FirstName;
            TxLastName.Text = UserINfo.LastName;
            TxEmail.Text = UserINfo.UserName;
            TxPassword.Text = UserINfo.Password;
        }
       private bool IsThisChkBoxFromUserPermissions(sbyte UserPermissions,sbyte ChkBoxPermissionNumber)
        {
            return (ChkBoxPermissionNumber == (ChkBoxPermissionNumber & UserPermissions));
        }
        private void SetPermissionsOnChkBoxes()
        {
            if (UserINfo.PermissionNumber == -1)
            {
                ChkEmployees.Checked = true;
                ChkLogOut.Checked = true;
                ChkProducts.Checked = true;
                ChkSales.Checked = true;
                ChkUsers.Checked = true;
                chkClients.Checked = true;
                chkLogsIn.Checked = true;
            }
            else
            {
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(ChkEmployees.Tag)))
                {
                    ChkEmployees.Checked = true;
                }
                else
                {
                    ChkEmployees.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(ChkLogOut.Tag)))
                {
                    ChkLogOut.Checked = true;
                }
                else
                {
                    ChkLogOut.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(ChkProducts.Tag)))
                {
                    ChkProducts.Checked = true;
                }
                else
                {
                    ChkProducts.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(ChkSales.Tag)))
                {
                    ChkSales.Checked = true;
                }
                else
                {
                    ChkSales.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(ChkUsers.Tag)))
                {
                    ChkUsers.Checked = true;
                }
                else
                {
                    ChkUsers.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(chkClients.Tag)))
                {
                    chkClients.Checked = true;
                }
                else
                {
                    chkClients.Checked = false;

                }
                if (IsThisChkBoxFromUserPermissions(UserINfo.PermissionNumber, Convert.ToSByte(chkLogsIn.Tag)))
                {
                    chkLogsIn.Checked = true;
                }
                else
                {
                    chkLogsIn.Checked = false;

                }
            }


        }
       
        private bool  _Update()
        {
            return ClsUser.UpdateUserInfo(UserINfo.UserId, UserINfo.FirstName, UserINfo.LastName, UserINfo.UserName, UserINfo.Password, UserINfo.PermissionNumber);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {

            switch (EnCurrentMode)
            {
                case Mode.EnAddNew:
                    {
                        GetNewAccountINformationFromDesign();
                        if (AddNewUser())
                        {
                            MessageBox.Show("تمت االعمليه بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("فشلت الاضافه تأكد من ان المعلومات صحيحه");
                        }
                    }
                    break;
                case Mode.EnUpdate:
                    {

                        GetNewAccountINformationFromDesign();
                        if (_Update())
                        {
                            MessageBox.Show("تم التحديث بنجاح");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("حدث خطا تاكد من المعلومات");
                            this.Close();
                        }

                    }
                    break;
            }
        }

        private void AddNewUSer_Load(object sender, EventArgs e)
        {
            if(UserINfo.UserId==2)
            {
                groupBox1.Enabled = false;
            }
            if (SetUserInfoThatWillUpdateIntoClsCurrentUserForAddAndUpdate())
            {
                SetUserinfoOnTextBoxes();
                SetPermissionsOnChkBoxes();
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
            if (TxLastName.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxLastName.Text = "";
            }
        }

        private void TxEmail_MouseEnter(object sender, EventArgs e)
        {
            if (TxEmail.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxEmail.Text = "";
            }
        }

        private void TxPassword_MouseEnter(object sender, EventArgs e)
        {
            if (TxPassword.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxPassword.Text = "";
            }
        }

        private void TxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
