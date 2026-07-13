using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Housing01
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void RentalForm_Load(object sender, EventArgs e)
        {
            //set the query condition and default is to query all house info.
            this.cmbCondition.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("RealName");
            this.cmbCondition.Items.Add("Phone");

            //
            this.cmbIsReturnDeposit.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbIsReturnDeposit.Items.Clear();
            this.cmbIsReturnDeposit.Items.Add("Yes");
            this.cmbIsReturnDeposit.Items.Add("No");
            this.cmbIsReturnDeposit.SelectedIndex = 1;

            DataSet ds1 =  this.QueryAll();
            this.dgvRentalList.DataSource = ds1.Tables[0];
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //Default is to query all Rental info.
            string sqlStr = string.Format("select Rental.RentalID,Rental.HouseID,Rental.TenantID,TenantInfo.RealName,TenantInfo.Phone,Rental.RentStartDate,Rental.RentEndDate,Rental.MonthlyRent,Rental.DepositPaid,Rental.IsReturnDeposit,Rental.TotalRent,Rental.Remark from Rental,TenantInfo where Rental.TenantID=TenantInfo.TenantID");
            if (this.cmbCondition.SelectedIndex == 0) //Retrieve all Rental info based on RealName of tenant.
            {
                sqlStr = string.Format("select Rental.RentalID,Rental.HouseID,Rental.TenantID,TenantInfo.RealName,TenantInfo.Phone,Rental.RentStartDate,Rental.RentEndDate,Rental.MonthlyRent,Rental.DepositPaid,Rental.IsReturnDeposit,Rental.TotalRent,Rental.Remark from Rental,TenantInfo where Rental.TenantID=TenantInfo.TenantID and TenantInfo.RealName like '%{0}%'"
                    , this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Phone of tenant.
            {
                sqlStr = string.Format("select Rental.RentalID,Rental.HouseID,Rental.TenantID,TenantInfo.RealName,TenantInfo.Phone,Rental.RentStartDate,Rental.RentEndDate,Rental.MonthlyRent,Rental.DepositPaid,Rental.IsReturnDeposit,Rental.TotalRent,Rental.Remark from Rental,TenantInfo where Rental.TenantID=TenantInfo.TenantID and TenantInfo.Phone like '%{0}%'"
                    , this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvRentalList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvRentalList
        {
            this.dgvRentalList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvRentalList.Columns[1].Width = 60;
            this.dgvRentalList.Columns[2].Width = 150;
            this.dgvRentalList.Columns[3].Width = 60;
            this.dgvRentalList.Columns[4].Width = 60;
            this.dgvRentalList.Columns[5].Width = 60;
            this.dgvRentalList.Columns[6].Width = 60;
        }
       
        

      

        private void dgvRentalList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvRentalList.CurrentRow.Index;
            //Display user data to the corresponding controls
            this.tbRentalID.Text = this.dgvRentalList[0, n].Value.ToString(); //the value of Row n and column  0 is assgined to tbID and display it.
            this.tbHouseID.Text = this.dgvRentalList[1, n].Value.ToString();
            this.tbTenantID.Text = this.dgvRentalList[2, n].Value.ToString();
            this.tbStartDate.Text = this.dgvRentalList[5, n].Value.ToString();
            this.tbEndDate.Text = this.dgvRentalList[6, n].Value.ToString();
            this.tbMonthlyRent.Text= this.dgvRentalList[7, n].Value.ToString();
            this.tbDepositPaid.Text = this.dgvRentalList[8, n].Value.ToString();
            this.cmbIsReturnDeposit.Text = this.dgvRentalList[9, n].Value.ToString();
            this.tbRemark.Text = this.dgvRentalList[10, n].Value.ToString();
        }

       

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectCategory_Click(object sender, EventArgs e)
        {
            SelectCategory selCategory = new SelectCategory();
            if (selCategory.ShowDialog() == DialogResult.OK)
            {
                this.tbHouseID.Text = selCategory.CategoryID.ToString(); //Save the CategoryID to tbRentalID control.
            }           
        }

        private void btnSelectHouse_Click(object sender, EventArgs e)
        {
            SelectHouse selHouse = new SelectHouse();
            if (selHouse.ShowDialog() == DialogResult.OK)
            {
                this.tbHouseID.Text = selHouse.HouseID.ToString();   //ID
                this.tbMonthlyRent.Text = selHouse.RentPrice.ToString();//MonthlyRent, RentPrice also.
                this.tbDepositPaid.Text = selHouse.Deposit.ToString();//DepositPaid, Deposit also.
            }
        }

        private void btnSelectTenant_Click(object sender, EventArgs e)
        {
            SelectTenant selTenant = new SelectTenant();
            if (selTenant.ShowDialog() == DialogResult.OK)
            {
                this.tbTenantID.Text = selTenant.TenantID.ToString();
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

        }
        private DataSet QueryAll()//Retrieve all admin info.
        {
            string sqlStr = string.Format("select Rental.RentalID,Rental.HouseID,Rental.TenantID,TenantInfo.RealName,TenantInfo.Phone,Rental.RentStartDate,Rental.RentEndDate,Rental.MonthlyRent,Rental.DepositPaid,Rental.IsReturnDeposit,Rental.Remark from Rental,TenantInfo where Rental.TenantID=TenantInfo.TenantID");
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            return ds1;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // Form the update statement
            string sqlStr = string.Format("update Rental set HouseID='{0}',TenantID='{1}',RentStartDate='{2}',RentEndDate='{3}',MonthlyRent='{4}',DepositPaid='{5}',IsReturnDeposit='{6}',TotalRent='{7}',Remark='{8}' where RentalID = '{9}'",
               this.tbHouseID.Text, this.tbTenantID.Text, Convert.ToDateTime(this.tbStartDate.Text), Convert.ToDateTime(this.tbEndDate.Text), this.tbMonthlyRent.Text, this.tbDepositPaid.Text, this.cmbIsReturnDeposit.Text,this.tbTotalRent.Text, this.tbRemark.Text , this.tbRentalID.Text );
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that update operation is success.
            if (n > 0)
            {
                MessageBox.Show("update is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvRentalList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("update is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Form the delete statement
            string sqlStr = string.Format("delete from Rental where RentalID = '{0}'", this.tbRentalID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that delete operation is success.
            if (n > 0)
            {
                MessageBox.Show("Rental deletion is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvRentalList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("Rental deletion is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //Step 1: Modify the IsReturnDeposit and TotalRent value in Rental table.
            // Form the update statement
            string sqlStr = string.Format("update Rental set IsReturnDeposit='{0}',TotalRent='{1}' where RentalID = '{2}'",
               this.cmbIsReturnDeposit.Text, this.tbTotalRent.Text, this.tbRentalID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that update operation is success.
            if (n > 0)
            {
                MessageBox.Show("update is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvRentalList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("update is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Step 2: Modify the IsVacant value to “Yes” in HouseInfo table.
            string sqlStr1 = string.Format("update HouseInfo set IsVacant='Yes' where HouseID = '{0}'",this.tbHouseID.Text);
            //Execute the SQL command.
            int n1 = SQLHelper.ExecuteCmd(sqlStr1);
            //Step 3: judge the checkout result

            // If value of n and n1 are both greater than 0, the meaning is that update operation is success.
            if (n > 0 && n1>0)
            {
                MessageBox.Show("Checkout is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvRentalList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("Checkout is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //private void btnSelectRental_Click(object sender, EventArgs e)
        //{
        //    SelectRental seRental = new SelectRental();
        //    if (seRental.ShowDialog() == DialogResult.OK)
        //    {
        //        this.tbRentalID.Text = seRental.RentalID.ToString();
        //    }

        //}
    }
}
