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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("CategoryName");
            this.cmbCondition.Items.Add("Remark");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from HouseCategory");//Default is to query all Category info.
            if (this.cmbCondition.SelectedIndex == 0) //Perform fuzzy query based on the CategoryName field
            {
                sqlStr = string.Format("select * from HouseCategory where CategoryName like '%{0}%'", this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the Remark field
            {
                sqlStr = string.Format("select * from HouseCategory where Remark like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvCategoryList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }
        private void SetDgvWidth() //Set the width of each column in the dgvUserList
        {
            this.dgvCategoryList.Columns[0].Width = 60;  //Set the width of the first column
            this.dgvCategoryList.Columns[1].Width = 120;
            this.dgvCategoryList.Columns[2].Width = 480;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Insert statement
            string sqlStr = string.Format("insert into HouseCategory(CategoryID,CategoryName,Remark) values('{0}','{1}','{2}')",
                this.tbID.Text, this.tbCategoryName.Text, this.tbRemark.Text);
            //Execute the SQL statement by using the ExecuteCmd method of SQLHelper
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that insert operation is success.
            if (n > 0)
            {
                MessageBox.Show("Insert is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvCategoryList.DataSource = ds1.Tables[0];
                this.SetDgvWidth();
            }
        }
        private DataSet QueryAll()//Retrieve all admin info.
        {
            string sqlStr = string.Format("select * from HouseCategory");
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            return ds1;
        }

        private void dgvUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvCategoryList.CurrentRow.Index;
            //Display user data to the corresponding controls
            this.tbID.Text = this.dgvCategoryList[0, n].Value.ToString(); //the value of Row n and column  0 is assgined to tbID and display it.
            this.tbCategoryName.Text = this.dgvCategoryList[1, n].Value.ToString();
            this.tbRemark.Text = this.dgvCategoryList[2, n].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Form the update statement
            string sqlStr = string.Format("update HouseCategory set CategoryName ='{0}',Remark = '{1}'  where CategoryID = '{2}'",
                this.tbCategoryName.Text, this.tbRemark.Text,this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that update operation is success.
            if (n > 0)
            {
                MessageBox.Show("update is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvCategoryList.DataSource = ds1.Tables[0];

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
            string sqlStr = string.Format("delete from HouseCategory where CategoryID = '{0}'", this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that delete operation is success.
            if (n > 0)
            {
                MessageBox.Show("delete is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvCategoryList.DataSource = ds1.Tables[0];

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
