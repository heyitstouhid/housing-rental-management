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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.cmbCondition.Items.Clear();
            this.cmbCondition.Items.Add("LoginName");
            this.cmbCondition.Items.Add("RealName");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sqlStr = string.Format("select * from Admin");//Default is to query all admin info.
            if (this.cmbCondition.SelectedIndex == 0) //Perform fuzzy query based on the LoginName field
            {
                sqlStr = string.Format("select * from Admin where LoginName like '%{0}%'", this.tbValue.Text);
            }
            if (this.cmbCondition.SelectedIndex == 1) //Perform fuzzy query based on the RealName field
            {
                sqlStr = string.Format("select * from Admin where RealName like '%{0}%'", this.tbValue.Text);
            }
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            this.dgvUserList.DataSource = ds1.Tables[0];
            this.SetDgvWidth();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Insert statement
            string sqlStr = string.Format("insert into Admin(AdminID,LoginName,LoginPwd,RealName,Phone) values('{0}','{1}','{2}','{3}','{4}')",
                this.tbID.Text, this.tbLoginName.Text, this.tbLoginPwd.Text,this.tbRealName.Text, this.tbPhone.Text);
            //Execute the SQL statement by using the ExecuteCmd method of SQLHelper
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that insert operation is success.
            if (n > 0)
            {
                MessageBox.Show("Insert is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvUserList.DataSource = ds1.Tables[0];
                this.SetDgvWidth();
            }
        }
        private DataSet QueryAll()//Retrieve all admin info.
        {
            string sqlStr = string.Format("select AdminID,LoginName,LoginPwd,RealName,Phone,Email from Admin");
            DataSet ds1 = new DataSet();
            ds1 = SQLHelper.GetData(sqlStr);
            return ds1;
        }

        private void dgvUserList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Obtain the index of the selected row
            int n = this.dgvUserList.CurrentRow.Index;
            //Display user data to the corresponding controls
            this.tbID.Text = this.dgvUserList[0, n].Value.ToString(); //the value of Row n and column  0 is assgined to tbID and display it.
            this.tbLoginName.Text = this.dgvUserList[1, n].Value.ToString();
            this.tbLoginPwd.Text = this.dgvUserList[2, n].Value.ToString();
            this.tbRealName.Text = this.dgvUserList[3, n].Value.ToString();
            this.tbPhone.Text = this.dgvUserList[4, n].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Form the update statement
            string sqlStr = string.Format("update Admin set LoginName ='{0}',LoginPwd = '{1}',RealName = '{2}' ,Phone='{3}' where AdminID = '{4}'",
                this.tbLoginName.Text, this.tbLoginPwd.Text,this.tbRealName.Text, this.tbPhone.Text.Trim(), this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that update operation is success.
            if (n > 0)
            {
                MessageBox.Show("update is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvUserList.DataSource = ds1.Tables[0];

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
            string sqlStr = string.Format("delete from Admin where AdminID = '{0}'", this.tbID.Text);
            //Execute the SQL command.
            int n = SQLHelper.ExecuteCmd(sqlStr);
            // If value of n is greater than 0, the meaning is that delete operation is success.
            if (n > 0)
            {
                MessageBox.Show("delete is success.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataSet ds1 = new DataSet();
                ds1 = this.QueryAll();
                this.dgvUserList.DataSource = ds1.Tables[0];

                this.SetDgvWidth();
            }
            else
            {
                MessageBox.Show("delete is failure.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dgvUserList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetDgvWidth() //Set the width of each column in the dgvUserList
        {
            // Ensure there are enough columns
            if (this.dgvUserList.Columns.Count >= 1) this.dgvUserList.Columns[0].Width = 60;  // AdminID
            if (this.dgvUserList.Columns.Count >= 2) this.dgvUserList.Columns[1].Width = 100; // LoginName
            if (this.dgvUserList.Columns.Count >= 3) this.dgvUserList.Columns[2].Width = 100; // LoginPwd
            if (this.dgvUserList.Columns.Count >= 4) this.dgvUserList.Columns[3].Width = 100; // RealName
            if (this.dgvUserList.Columns.Count >= 5) this.dgvUserList.Columns[4].Width = 100; // Phone
            if (this.dgvUserList.Columns.Count >= 6) this.dgvUserList.Columns[5].Width = 180; // Email wider

            // Header text adjustments
            if (this.dgvUserList.Columns.Count >= 1) this.dgvUserList.Columns[0].HeaderText = "User ID";
            if (this.dgvUserList.Columns.Count >= 2) this.dgvUserList.Columns[1].HeaderText = "Login Name";
            if (this.dgvUserList.Columns.Count >= 3) this.dgvUserList.Columns[2].HeaderText = "Login Pass";
            if (this.dgvUserList.Columns.Count >= 4) this.dgvUserList.Columns[3].HeaderText = "Real Name";
            if (this.dgvUserList.Columns.Count >= 5) this.dgvUserList.Columns[4].HeaderText = "Phone";
            if (this.dgvUserList.Columns.Count >= 6) this.dgvUserList.Columns[5].HeaderText = "Email";
        }
    }
}
