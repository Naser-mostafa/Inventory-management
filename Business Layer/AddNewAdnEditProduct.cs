using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UhlSportDataAccessLayer;

namespace FaisalSport
{
    public partial class AddNewAdnEditProduct : Form
    {
        public AddNewAdnEditProduct(BigInteger ID)
        {

            InitializeComponent();
            if (ID == -1)
            {
                Mode = EnMode.EnAddNew;
                LbAddAndEdit.Text = "اضافه منتج جديد";

            }
            else
            {
                Mode = EnMode.EnUpdate;
                NewProduct.ID = ID;
                LbAddAndEdit.Text = "تعديل المنتج";
                GetProductInfoThatWillUpdate();

            }
        }
        private class ClsProductInfo
        {
            public BigInteger ID;
            public string ProductName;
            public DateTime DateAndTime;
            public float ProfitAfterSellingAllQuantity, buyingPrice, SellingPrice;
            public int ColorID, SizeID, Quantity;
            public string ImagePath = "";
        }
        private ClsProductInfo NewProduct = new ClsProductInfo();
        enum EnMode
        {
            EnUpdate, EnAddNew
        }
        private EnMode Mode;
        private void SelectProductPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "اختر صوره المنتج";
            openFileDialog1.Filter = "All Files(*,*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ProdutPicture.ImageLocation = openFileDialog1.FileName;
                NewProduct.ImagePath = openFileDialog1.FileName;
            }
        }
        private void GetProductINfoIntoCurrentProduct()
        {
            NewProduct.ProductName = TxProductName.Text;
            NewProduct.Quantity = Convert.ToInt32(Convert.ToString(TxQuantity.Text));
            NewProduct.buyingPrice = float.Parse((TxBuimgPrice.Text));
            NewProduct.SellingPrice = float.Parse(txSellingPrice.Text);
            NewProduct.DateAndTime = DateTime.Today;
            if (ClsSizes.IsThisSizeAlreadyExist(CbProductSize.Text) == 0)
            {
                NewProduct.SizeID = ClsSizes.AddingSizeAndReturnScopeIdentity(CbProductSize.Text);
            }
            else
            {
                NewProduct.SizeID = ClsSizes.IsThisSizeAlreadyExist(CbProductSize.Text);
            }
            if (ClsColor.IsThisColorAlreadyExist(CbProductColor.Text) == 0)
            {
                NewProduct.ColorID = ClsColor.AddingColorAndReturnScopeIdentity(CbProductColor.Text);

            }
            else
            {
                NewProduct.ColorID = ClsColor.IsThisColorAlreadyExist(CbProductColor.Text);

            }
        }
        private void addNewProduct()

        {


            {
                //this function will call data access to add the color on a sparetion table and return Id
                NewProduct.ProfitAfterSellingAllQuantity = (float)((NewProduct.SellingPrice - NewProduct.buyingPrice) * NewProduct.Quantity);
                if (CLsProducts.AddNewProduct(NewProduct.ProductName, NewProduct.DateAndTime = DateTime.Now, NewProduct.buyingPrice, NewProduct.SellingPrice, (short)NewProduct.ColorID, (short)NewProduct.SizeID, NewProduct.ImagePath, NewProduct.ProfitAfterSellingAllQuantity, NewProduct.Quantity))
                {
                    MessageBox.Show("تمت عمليه الاضافه بنجاح");
                }
                else
                {
                    MessageBox.Show("تعذرت الاضافه");

                }




            }
        }
        private void SetColorsAndSizesIntoDropDownListForUserChoice()
        {
            DataTable AllColors = ClsColor.GetAllColorsName();
            DataTable AllSizes = ClsSizes.GetAllSizes();
            foreach (DataRow row in AllColors.Rows)
            {
                CbProductColor.Items.Add(row["اللون"]);
            }
            foreach (DataRow row in AllSizes.Rows)
            {
                CbProductSize.Items.Add(row["المقاس"]);
            }
        }
        private void GetProductInfoThatWillUpdate()
        {
            DataTable AllColors = ClsColor.GetAllColorsName();
            DataTable AllSizes = ClsSizes.GetAllSizes();

            //this will call data access and will return the info of the product by id
            CLsProducts.GetProductInfoByID(NewProduct.ID, ref NewProduct.ProductName, ref NewProduct.buyingPrice, ref NewProduct.SellingPrice, ref NewProduct.ColorID, ref NewProduct.SizeID, ref NewProduct.Quantity, ref NewProduct.ImagePath);
            TxBuimgPrice.Text =Convert.ToString(NewProduct.buyingPrice);
            TxProductName.Text = Convert.ToString(NewProduct.ProductName);
            txSellingPrice.Text = Convert.ToString(NewProduct.SellingPrice);
            TxQuantity.Text = Convert.ToString(NewProduct.Quantity);
            ProdutPicture.ImageLocation = NewProduct.ImagePath;
            if(NewProduct.ImagePath != "")
            {
                LbAddProductPicture.Visible = false;
            }
            else
            {
                LbAddProductPicture.Visible = true;
            }
                foreach (DataRow row in AllColors.Rows)
            {
                CbProductColor.Items.Add(row["اللون"]);
            }
            foreach (DataRow row in AllSizes.Rows)
            {
                CbProductSize.Items.Add(row["المقاس"]);
            }
            //must set the value of the size&color with there ID and set as the selected item on the drop down list
            CbProductColor.SelectedIndex = CbProductColor.FindString( ClsColor.GetColorNameByID(NewProduct.ColorID));
            CbProductSize.SelectedIndex = CbProductSize.FindString(ClsSizes.GetSizeNameByID(NewProduct.SizeID));

        }
        private bool TxProductName_Validating()
        {
            if(string.IsNullOrEmpty(TxProductName.Text))
            {
               // e.Cancel=true;
                TxProductName.Focus();
                errorProvider1.SetError(TxProductName, "ادخال الاسم ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool TxQuantity_Validating()
        {
            if (string.IsNullOrEmpty(TxQuantity.Text))
            {
                // e.Cancel=true;
                TxQuantity.Focus();
                errorProvider1.SetError(TxQuantity, "ادخال الكميه ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool TxBuyingPrice_Validating()

        {
            if (string.IsNullOrEmpty(TxBuimgPrice.Text))
            {
                // e.Cancel=true;
                TxBuimgPrice.Focus();
                errorProvider1.SetError(TxBuimgPrice, "ادخال سعر الشراء ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private bool txSellingPrice_Validating()
        {
            if (string.IsNullOrEmpty(txSellingPrice.Text))
            {
                // e.Cancel=true;
                txSellingPrice.Focus();
                errorProvider1.SetError(txSellingPrice, "ادخال سعر البيع ضروري");
                return false;
            }
            else
            {
                errorProvider1.Clear();
                return true;
            }
        }
        private void UpdateProduct()
        {
            NewProduct.ProductName = TxProductName.Text;
            NewProduct.buyingPrice =(float.Parse(TxBuimgPrice.Text));
            NewProduct.SellingPrice = (float.Parse(txSellingPrice.Text));

            if(ClsColor.GetIdByColorName(CbProductColor.Text)==0)
            {
                NewProduct.ColorID = ClsColor.AddingColorAndReturnScopeIdentity(CbProductColor.Text);
            }
            else{
                NewProduct.ColorID = ClsColor.GetIdByColorName(CbProductColor.Text);
            }
            if(ClsSizes.GetIdBySizeName(CbProductSize.Text)==0)
            {
                NewProduct.SizeID = ClsSizes.AddingSizeAndReturnScopeIdentity(CbProductSize.Text);
            }
            else
            {
                NewProduct.SizeID = ClsSizes.GetIdBySizeName(CbProductSize.Text);
            }
            NewProduct.ImagePath = ProdutPicture.ImageLocation.ToString();
            NewProduct.Quantity =Convert.ToInt32(TxQuantity.Text);
            NewProduct.ProfitAfterSellingAllQuantity = (float)((NewProduct.SellingPrice - NewProduct.buyingPrice) * NewProduct.Quantity);

            NewProduct.DateAndTime = DateTime.Now;
       if(CLsProducts.Update(NewProduct.ID, NewProduct.Quantity,NewProduct.ProductName ,NewProduct.DateAndTime, NewProduct.buyingPrice, NewProduct.SellingPrice, NewProduct.ColorID, NewProduct.SizeID, NewProduct.ImagePath, NewProduct.ProfitAfterSellingAllQuantity))
            {
                MessageBox.Show("تم التحديث بنجاح");
            }
            else
            {
                MessageBox.Show("فشلت العمليه");

            }
        ;
        }
        private void BtnSaveNewProduct_Click(object sender, EventArgs e)

        {
            switch (Mode)
            {
                case EnMode.EnAddNew:
                    if (txSellingPrice_Validating()&& TxQuantity_Validating()&& TxBuyingPrice_Validating()&& TxProductName_Validating())
                    {
                        GetProductINfoIntoCurrentProduct();
                        addNewProduct();
                        this.Close();
                    }
                 
                    break;
                case EnMode.EnUpdate:

                    UpdateProduct();
                    this.Close();
                    break;
            }
        }
        private void AddNewAdnEditProduct_Load(object sender, EventArgs e)
        {
            SetColorsAndSizesIntoDropDownListForUserChoice();
            if (ProdutPicture.ImageLocation == "")
            {
                LbRemoveProductPicturer.Hide();
            }
            else
            {
                LbRemoveProductPicturer.Show();

            }
        }
        private void LbRemoveProductPicturer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewProduct.ImagePath = "";
            ProdutPicture.ImageLocation = "";
        }

  

        private void TxProductName_MouseEnter(object sender, EventArgs e)
        {
           if(TxProductName.Text== "لا يسمح ان يكون الحقل فارغ")
            {
                TxProductName.Text = "";
            }
        }

        private void TxQuantity_MouseEnter(object sender, EventArgs e)
        {
            if (TxQuantity.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxQuantity.Text = "";
            }
        }

        private void TxBuimgPrice_MouseEnter(object sender, EventArgs e)
        {
            if (TxBuimgPrice.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                TxBuimgPrice.Text = "";
            }
        }

        private void txSellingPrice_MouseEnter(object sender, EventArgs e)
        {
            if (txSellingPrice.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                txSellingPrice.Text = "";
            }
        }

        private void CbProductColor_MouseEnter(object sender, EventArgs e)
        {
            if (CbProductColor.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                CbProductColor.Text = "";
            }
        }

        private void CbProductSize_MouseEnter(object sender, EventArgs e)
        {
            if (CbProductSize.Text == "لا يسمح ان يكون الحقل فارغ")
            {
                CbProductSize.Text = "";
            }
        }

        private void TxProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
