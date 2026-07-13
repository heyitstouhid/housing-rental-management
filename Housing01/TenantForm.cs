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

namespace Housing01
{
    public partial class TenantForm : Form
    {
        public TenantForm()
        {
            InitializeComponent();
        }

        private void TenantForm_Load(object sender, EventArgs e)
        {
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("RealName");
            this.cmbCondition.Items.Add("Phone");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from TenantInfo");//Default is to query all Tenant info.
            if (this.cmbCondition.SelectedIndex == 0) //Perform fuzzy query based on the RealName field
            {
                sqlStr = string.Format("select * from TenantInfo where RealName like '%{0}%'", this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Phone field
            {
                sqlStr = string.Format("select * from TenantInfo where Phone like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvTenantList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvUserList
        {
            this.dgvTenantList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvTenantList.Columns[1].Width = 120;
            this.dgvTenantList.Columns[2].Width = 120;
            this.dgvTenantList.Columns[3].Width = 120;
            this.dgvTenantList.Columns[4].Width = 120;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Insert statement
            string sqlStr = string.Format("insert into TenantInfo(TenantID,RealName,IDCard,Phone) values('{0}','{1}','{2}','{3}')",
                this.tbID.Text, this.tbRealName.Text, this.tbIDCard.Text, this.tbPhone.Text);
            //Execute the SQL statement by using the ExecuteCmd method of SQLHelper
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that insert operation is success.
            if (n > 0)
            {
                MessageBox.Show("Insert is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvTenantList.DataSource = ds1.Tables[0];
                this.SetDgvWidth();
            }
        }
        private DataSet QueryAll()//Retrieve all admin info.
        {
            string sqlStr = string.Format("select * from TenantInfo");
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            return ds1;
        }

        private void dgvUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvTenantList.CurrentRow.Index;
            //Display user data to the corresponding controls
            this.tbID.Text = this.dgvTenantList[0, n].Value.ToString(); //the value of Row n and column  0 is assgined to tbID and display it.
            this.tbRealName.Text = this.dgvTenantList[1, n].Value.ToString();
            this.tbIDCard.Text = this.dgvTenantList[2, n].Value.ToString();
            this.tbPhone.Text = this.dgvTenantList[3, n].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Form the update statement
            string sqlStr = string.Format("update TenantInfo set RealName ='{0}',IDCard = '{1}',Phone = '{2}'  where AdminID = '{3}'",
                this.tbRealName.Text, this.tbIDCard.Text,this.tbPhone.Text, this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that update operation is success.
            if (n > 0)
            {
                MessageBox.Show("update is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvTenantList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("update is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Form the delete statement
            string sqlStr = string.Format("delete from TenantInfo where TenantID = '{0}'", this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that delete operation is success.
            if (n > 0)
            {
                MessageBox.Show("delete is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvTenantList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("delete is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//Close this form.
        }
    }
}
